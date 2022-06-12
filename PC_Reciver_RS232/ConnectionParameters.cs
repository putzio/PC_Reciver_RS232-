using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Reciver_RS232
{
    internal class ConnectionParameters
    {
        public int baud, bitNr;
        public String port;
        public ConnectionParameters(int baudInit = 9600, int bitNrInit = 8, string portInit = null)
        {
            baud = baudInit;
            bitNr = bitNrInit;
            port = portInit;
        }
        public void UpdateConnectionParameters(int newBaud, string newPort, int newBitNr = 8)
        {
            baud = newBaud;
            bitNr = newBitNr;
            port = newPort;
        }        
    }
}
