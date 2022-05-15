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

namespace PC_Reciver_RS232
{
    public partial class ConnectionSettings : Form
    {
        public ConnectionSettings()
        {
            InitializeComponent();
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
            for(int i = 5; i<10; i++)
            {
                comboBox_BitNr.Items.Add(i);
            }
            comboBox_BitNr.Text = "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            //Form1.connectionParameters.UpdateConnectionParameters(Convert.ToInt16(comboBox_Baud.Text), Convert.ToInt16(comboBox_BitNr.Text), comboBox_Port.Text);
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
