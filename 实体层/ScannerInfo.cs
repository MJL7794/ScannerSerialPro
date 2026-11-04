using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ScannerSerialPro.实体层
{
     public class ScannerInfo{
        public string PortNname { get; set; } = "COM1";
        public int BaudRate { get; set; } = 9600;
        public Parity Parity { get; set; } = Parity.None;
        public int DataBits { get; set; } = 8;
        public StopBits StopBits { get; set; } = StopBits.One;


    }
}
