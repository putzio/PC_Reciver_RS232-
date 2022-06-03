using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Reciver_RS232
{
    //public struct AltimeterDataRange
    //{
    //    public int time, hight;
    //    AltimeterDataRange(int t = 0, int h=0)
    //    {
    //        time = t;
    //        hight = h;
    //    }
    //}
    internal class AltimeterData
    {
        public UInt32 hight;
        public UInt64 time;
        public enum EndAltimeter
        {
            data,
            series,
            END,
            range
        };
        public EndAltimeter endAltimeter;
        //format:
        //#t:220&h:1000$
        public AltimeterData(string data)
        {
            time = Convert.ToUInt64(data.Substring(3,data.IndexOf('&')-3));
            String hString = data.Substring(data.IndexOf('h') + 2, data.IndexOf('$') - data.IndexOf('h') - 2);
            
            hight = Convert.ToUInt32(hString);
            endAltimeter = EndAltimeter.data;
        }
        public AltimeterData(EndAltimeter end, UInt64 t = 0, UInt32 h = 0)
        {
            time = t;
            hight = h;
            endAltimeter = end;

        }
        public String ReturnData()
        {
            return (time.ToString() + ";" + hight.ToString()+";");
        }
    }
    internal class AltimeterDataRange:AltimeterData
    {
        public AltimeterDataRange(UInt64 t = 0, UInt32 h = 0): base(EndAltimeter.range, t, h)
        {
        }
        public void CheckNewRange(AltimeterData data)
        {
            if (this.time < data.time)
                this.time = data.time;
            if (this.hight < data.hight)
                this.hight = data.hight;
        }
    }
}
