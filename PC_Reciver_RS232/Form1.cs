using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace PC_Reciver_RS232
{
    public partial class Form1 : Form
    {       
        string InputData = String.Empty;
        Queue<AltimeterData> altimeterDatas = new Queue<AltimeterData>();
        AltimeterDataRange altimeterDataRange = new AltimeterDataRange();        
        ConnectionParameters connectionParameters = new ConnectionParameters();

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            InitialiseConnectionParameters();
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
        }
               

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connectionParameters.UpdateConnectionParameters(Convert.ToInt32(comboBox_Baud.Text), Convert.ToInt16(comboBox_BitNr.Text), comboBox_Port.Text);
            if(connectionParameters.port == null)
            {
                MessageBox.Show("Nieprawidłowe parametry połączenia");
                return;
            }
            if (buttonConnect.Text == "Otwórz")
            {
                serialPort1.PortName = connectionParameters.port;
                serialPort1.BaudRate = connectionParameters.baud;
                serialPort1.DataBits = connectionParameters.bitNr;
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
                try
                {
                    serialPort1.Open();
                    serialPort1.Write("START");
                    buttonConnect.Text = "Zamknij";
                    groupBoxConnected.Enabled = true;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (buttonConnect.Text == "Zamknij")
            {

                try
                {
                    serialPort1.Close();
                    buttonConnect.Text = "Otwórz";
                    groupBoxConnected.Enabled = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            //Command to get the measured data from the  device
            serialPort1.Write("#MD");
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            comboBox_Port.Items.Clear();
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                do
                {
                    index += 1;
                    comboBox_Port.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index ==
                ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
                comboBox_Port.Text = comboBox_Port.Items[0].ToString();
            }
        }
        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }
        private void SetText(string text)
        {
            textBoxInfo.Text += text;
            if (text.Length < 3)
            {
                MessageBox.Show("Przesłany tekst: \t" + text + "\t Jest za krótki");
                return;
            }
            if (text.Substring(0, 3) == "END")
            {
                //end of the last data series
                AltimeterData altimeterData = new AltimeterData(AltimeterData.EndAltimeter.END, 2137);
                altimeterDatas.Enqueue(altimeterData);
                PlotAndExport();
                return;
            }
            else if (text.Substring(0, 3) == "end")
            { 
                //End of data series
                AltimeterData altimeterData = new AltimeterData(AltimeterData.EndAltimeter.series);
                altimeterDatas.Enqueue(altimeterData);
                return;
            }
            else if (text.Substring(0, 3) == "#t:")
            {
                AltimeterData altimeterData = new AltimeterData(text);
                altimeterDatas.Enqueue(altimeterData);
                altimeterDataRange.CheckNewRange(altimeterData);
                serialPort1.Write("ok");
            }
            else if(text.Substring(0, 3) =="TST")
            {
                textBoxTest.Text+=text.Substring(4);
            }

            //else if()
            //{
            //    MessageBox.Show("Przesłano dane w nieprawidłowym formacie (#t:220&h:1000$):" + text);
            //}
        }
        private async void PlotAndExport()
        {
            List<Task> tasks = new List<Task>();
            
            tasks.Add(Task.Run(()=>ExportToCSV()));
            Plot();
            await Task.WhenAll(tasks);
        }

        private void Plot()
        {
            //Chart axis setup
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = altimeterDataRange.time + 10;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = altimeterDataRange.hight + 10;

            chart.Series.Clear();
            //Create the first chart Series            
            int chartNr = 0;
            chartNr++;
            String chartName = "Seria: " + chartNr.ToString();
            chart.Series.Add(chartName);
            Random rnd = new Random();
            chart.Series[chartName].Color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            chart.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (AltimeterData altimeterData in altimeterDatas)
            {
                if (altimeterData.endAltimeter == AltimeterData.EndAltimeter.END)
                    break;
                if (altimeterData.endAltimeter == AltimeterData.EndAltimeter.series)
                {
                    //create new series
                    chartNr++;
                    chartName = "Seria: " + chartNr.ToString();
                    chart.Series.Add(chartName);
                    chart.Series[chartName].Color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    chart.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                else
                {
                    //draw a point in current series
                    chart.Series[chartName].Points.AddXY(altimeterData.time, altimeterData.hight);
                    textBoxInfo.Text += altimeterData.hight;
                    textBoxInfo.Text += "\r\n";
                }
            }
            
        }

        private void ExportToCSV ()
        {
            List<String> linesCSV = new List<string>();
            int dataSeriesNumber = 1;
            linesCSV.Add("");
            int line = 1;
            //read data and write them to the coresponding line in the right place
            foreach(AltimeterData altimeterData in altimeterDatas)
            {
                if (altimeterData.endAltimeter == AltimeterData.EndAltimeter.END)
                {
                    break;
                }
                if (altimeterData.endAltimeter == AltimeterData.EndAltimeter.series)
                {
                    line = 1;
                    dataSeriesNumber++;
                }
                if (linesCSV.Count < line + 1)
                {
                    //if needed create a new line
                    linesCSV.Add("");
                    //and if it is not the first series add right amount of ";" to put the data in the right place 
                    for(int j = 1; j < dataSeriesNumber; j++)
                    {
                        linesCSV[line] += ";;";
                    }
                }
                String newText = altimeterData.ReturnData();
                linesCSV[line] += newText;
                line++;
            }

            //create the first line:
            //"T0;H0;T1;H1" etc.
            String firstLine = "";
            for (int i = 0; i < dataSeriesNumber; i++)
            {
                firstLine += "T";
                firstLine += (i + 1).ToString();
                firstLine += ";H";
                firstLine += (i + 1).ToString();
                firstLine += ";";
            }
            firstLine.Substring(0, firstLine.Length - 1);
            linesCSV[0] = firstLine;
            StreamWriter file = new StreamWriter("results.csv");
            foreach (String writeLine in linesCSV)
            {
                file.WriteLine(writeLine);
            }
            file.Close();
        }
        private void InitialiseConnectionParameters()
        {
            comboBox_Baud.Items.Clear();
            comboBox_BitNr.Items.Clear();
            comboBox_Port.Items.Clear();
            //Baud rates
            comboBox_Baud.Items.Add(300);
            comboBox_Baud.Items.Add(600);
            comboBox_Baud.Items.Add(1200);
            comboBox_Baud.Items.Add(2400);
            comboBox_Baud.Items.Add(9600);
            comboBox_Baud.Items.Add(14400);
            comboBox_Baud.Items.Add(19200);
            comboBox_Baud.Items.Add(38400);
            comboBox_Baud.Items.Add(57600);
            comboBox_Baud.Items.Add(115200);
            comboBox_Baud.Items.ToString();
            comboBox_Baud.Text = "9600";

            //Available Serial Ports
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                do
                {
                    index += 1;
                    comboBox_Port.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index ==
                ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
                comboBox_Port.Text = comboBox_Port.Items[0].ToString();
            }


            //Setting number of bits
            for (int i = 5; i < 10; i++)
            {
                comboBox_BitNr.Items.Add(i);
            }
            comboBox_BitNr.Text = "8";
        }

        private void buttonClearFlash_Click(object sender, EventArgs e)
        {
            serialPort1.Write("###");
        }

        private void buttonWritePreassure_Click(object sender, EventArgs e)
        {
            String message = "#P:";
            message += numericUpDownPreassure.Value.ToString();
            message += "&";
            serialPort1.Write(message);
        }

        private void buttonShowMessages_Click(object sender, EventArgs e)
        {
            if (buttonShowMessages.Text == "Pokaż odbierane wiadomości")
            {
                buttonShowMessages.Text = "Ukryj odbierane wiadomości";
                textBoxInfo.Visible = true;
            }
            else
            {
                buttonShowMessages.Text = "Pokaż odbierane wiadomości";
                textBoxInfo.Visible = false;
            }
        }
    }
}
