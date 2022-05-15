using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Reciver_RS232
{
    internal class AltimeterData
    {
        public int hight;
        public int time;
        //format:
        //#t:220&h:1000$
        public AltimeterData(string data)
        {
            time = Convert.ToInt32(data.Substring(3,data.IndexOf('&')-3));
            hight = Convert.ToInt32(data.Substring(data.IndexOf('h') + 2, data.IndexOf('$') - data.IndexOf('h') - 2));
        }

    }
}
