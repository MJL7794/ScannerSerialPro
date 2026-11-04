using System;
using System.Collections.Generic;
using System.Text;
using ScannerSerialPro.实体层; // 需要引用实体层

namespace ScannerSerialPro.通信层
{
    public class ScannerComService
    {
        // 内部实例化底层的通信类
        private ScannerComlib scannerCom = new ScannerComlib();

        // 对外暴露的事件
        public event Action<string> CodeReceived;

        // 构造函数：绑定底层的事件
        public ScannerComService()
        {
            scannerCom.CodeReceived += ScannerCom_CodeReceived;
        }

        // 连接串口
        public void Connect(ScannerInfo info)
        {
            if (info == null) return;
            scannerCom.OpenCom(info.PortNname, info.BaudRate, info.Parity, info.DataBits, info.StopBits);
        }

        // 断开串口
        public void DisConn()
        {
            scannerCom.CloseCom();
        }

        // 接收底层数据并向上传递
        private void ScannerCom_CodeReceived(string code)
        {
            CodeReceived?.Invoke(code);
        }
    }
}