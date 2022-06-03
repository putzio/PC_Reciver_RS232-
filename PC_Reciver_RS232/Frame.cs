using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Reciver_RS232
{
    internal class Frame
    {
        public
        enum MessageType
        {
            Time,
            Hight,
            Clear,
            Preassure,
            ReadData
        };
        protected byte frameLength;
        protected byte[] frameNumber = new byte[2]; 
        protected String type;
        protected String message;
        protected byte checkSum;
        
    }

    internal class FrameIn : Frame
    {
        protected string inMessage;
        public FrameIn(String message)
        {
            inMessage = message;
            frameLength = Convert.ToByte(message[0]);
            frameNumber[0] = Convert.ToByte(message[1]);
            frameNumber[1] = Convert.ToByte(message[2]);
            type = message.Substring(3,3);
            this.message = message.Substring(6, message.IndexOf('&') - 7);
            checkSum = Convert.ToByte(message[message.Length - 2]);
        }
        public bool CheckSum()
        {
            UInt16 sum = 0;
            foreach(char c in this.inMessage.Substring(0,inMessage.Length - 2))
            {
                sum += c;
            }
            return (sum % 256 == checkSum);
        }
        //public override String ToString()
        //{

        //}
    }
    internal class FrameOut : Frame
    {
        string outMessage;
        FrameOut(byte frameLength,byte[] frameNumber,String type,String message)
        {
            this.frameLength = frameLength;
            this.frameNumber = frameNumber;
            this.type = type;
            this.message = message;
        }
        void CreateOutMessage()
        {
            String start;
            start = Convert.ToChar(frameLength).ToString();
            start += Convert.ToChar(frameNumber[0]).ToString();
            start += Convert.ToChar(frameNumber[1]).ToString();
            outMessage = start;

            outMessage += type;
            outMessage += message;

            outMessage += CheckSum(outMessage).ToString();
        }
        char CheckSum(string text)
        {
            UInt16 sum = 0;
            foreach (char c in text)
            {
                sum += c;
            }
            return Convert.ToChar(sum % 256);
        }
    }
    //internal class dataFrame : Frame
    //{
    //    AltimeterData altimeterData;
    //}
}
