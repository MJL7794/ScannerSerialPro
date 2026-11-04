using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace ScannerSerialPro.通信层
{
    public class ScannerComlib
    {
        private SerialPort serialPort = new SerialPort();
        public void OpenCom(string porName, int baudRate, Parity parity, int dataBits, StopBits stopBits) {
            if (serialPort.IsOpen) {
                serialPort.Close();
            }
            serialPort.PortName = porName;
            serialPort.BaudRate = baudRate;
            serialPort.DataBits = dataBits;
            serialPort.StopBits = stopBits;
            serialPort.Parity = parity;
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
        }
        public void CloseCom() {
            if (serialPort.IsOpen) {
                serialPort.Close();
            }
        }
        public event Action<string> CodeReceived;
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50); // 稍微等一下，确保扫码枪的数据（通常带回车换行）完整发过来
            int count = this.serialPort.BytesToRead;

            if (count > 0)
            {
                byte[] data = new byte[count];

                // 把数据真正读入到 data 数组中
                this.serialPort.Read(data, 0, count);

                // 把读出来的字节数组转成字符串，并使用 Trim() 去掉末尾的回车换行符
                string code = Encoding.Default.GetString(data).Trim();

                // 触发事件，把扫到的条码发给主界面
                CodeReceived?.Invoke(code);
            }
        }



    }
}
