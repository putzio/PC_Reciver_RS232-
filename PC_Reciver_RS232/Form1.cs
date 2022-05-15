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
    //public class ConnectionParameters
    //{
    //    public int baud, bitNr;
    //    public String port;
    //    public ConnectionParameters(int baudInit = 9600, int bitNrInit = 8, string portInit = null)
    //    {
    //        baud = baudInit;
    //        bitNr = bitNrInit;
    //        port = portInit;
    //    }
    //    public void UpdateConnectionParameters(int newBaud, int newBitNr, string newPort)
    //    {
    //        baud = newBaud;
    //        bitNr = newBitNr;
    //        port = newPort;
    //    }
    //}
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;
        Queue<AltimeterData> dataset = new Queue<AltimeterData>();
        public struct ConnectionParameters
        {
            public int baud, bitNr;
            public String port;
            public ConnectionParameters(int baudInit = 9600, int bitNrInit = 8, string portInit = null)
            {
                baud = baudInit;
                bitNr = bitNrInit;
                port = portInit;
            }
            public void UpdateConnectionParameters(int newBaud, int newBitNr, string newPort)
            {
                baud = newBaud;
                bitNr = newBitNr;
                port = newPort;
            }
        }
        public ConnectionParameters connectionParameters = new ConnectionParameters();
        public Form1()
        {
            InitializeComponent();
            InitialiseConnectionParameters();
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
        }
       private void buttonConnectionSettings_Click(object sender, EventArgs e)
        {
            ConnectionSettings connectionSettings = new ConnectionSettings();
            connectionSettings.ShowDialog();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connectionParameters.UpdateConnectionParameters(Convert.ToInt16(comboBox_Baud.Text), Convert.ToInt16(comboBox_BitNr.Text), comboBox_Port.Text);
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
                serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake),
               "None");
                try
                {
                    serialPort1.Open();
                    serialPort1.Write("START");
                    buttonConnect.Text = "Zamknij";
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
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            PlotAndExport();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {

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
            if (text.Substring(0,3) == "END")
            {
                PlotAndExport();
                return;
            }
            else if (text.Substring(0, 3) == "#t:")
            {
                AltimeterData altimeter = new AltimeterData(text);
                dataset.Enqueue(altimeter);
            }
            else
            {
                MessageBox.Show("Przesłano dane w nieprawidłowym formacie (#t:220&h:1000$):" + text);
            }
        }
        private void PlotAndExport()
        {
            Plot();
            ExportToCSV();
        }

        private void Plot(int xMax = 500, int yMax = 50000)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;

            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = 500;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 50000;
            chart.Series.Clear();

            chart.Series.Add("1st");
            chart.Series["1st"].Color = Color.FromArgb(0, 0, 128);
            //chart.Series["1st"].Legend = "Legenda";
            //chart.Series["1st"].ChartArea = "Chart Area";
            chart.Series["1st"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            textBoxInfo.Text = "";
            foreach (AltimeterData a in dataset)
            {
                chart.Series["1st"].Points.AddXY(a.time, a.hight);
                textBoxInfo.Text += a.hight;
                textBoxInfo.Text += "\r\n";
            }
        }

        private async void ExportToCSV ()
        {
            
            StreamWriter file = new StreamWriter("results.csv");

            foreach (AltimeterData a in dataset)
            {
                file.WriteLine(a.time + ";" + a.hight);
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
    }
}
