using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;
using ScannerSerialPro;
using ScannerSerialPro.工具层;
using ScannerSerialPro.通信层;
namespace ScannerSerialPro.实体层
{
    public class ScannerInfoService{
        public ScannerInfo GetScannerInfoFromPath(string path)
        {
            ScannerInfo scannerInfo = new ScannerInfo();
            scannerInfo.PortNname = IniConfigHelper.ReadIniData("配置信息", "端口号", "COM1", path);
            scannerInfo.BaudRate = Convert.ToInt32(IniConfigHelper.ReadIniData("配置信息", "波特率", "9600", path));
            scannerInfo.Parity = (Parity)Enum.Parse(typeof(Parity), IniConfigHelper.ReadIniData("配置信息", "校验位", "None", path), true);
            scannerInfo.DataBits = Convert.ToInt32(IniConfigHelper.ReadIniData("配置信息", "数据位", "8", path));
            scannerInfo.StopBits = (StopBits)Enum.Parse(typeof(StopBits), IniConfigHelper.ReadIniData("配置信息", "停止位", "One", path), true);
            return scannerInfo;
        }
        public bool SetCcannerInfoToPath(ScannerInfo scannerInfo, string path) {
            bool result = true;
            result &= IniConfigHelper.WriteIniData("配置信息", "端口号", scannerInfo.PortNname, path);
            result &= IniConfigHelper.WriteIniData("配置信息", "波特率", scannerInfo.BaudRate.ToString(), path);
            result &= IniConfigHelper.WriteIniData("配置信息", "校验位",scannerInfo.Parity.ToString(), path);
            result &= IniConfigHelper.WriteIniData("配置信息", "数据位", scannerInfo.DataBits.ToString(), path);
            result &= IniConfigHelper.WriteIniData("配置信息", "停止位",scannerInfo.StopBits.ToString(), path);
            return result;
        }
        private ScannerComlib scannerCom = new ScannerComlib();
        [Description("串口连接")]
        public void Connect(ScannerInfo scannerInfo) {
            scannerCom.OpenCom(scannerInfo.PortNname, scannerInfo.BaudRate, scannerInfo.Parity, scannerInfo.DataBits, scannerInfo.StopBits);
            scannerCom.CodeReceived += ScannerCom_CodeReceived;

        }
        public void DaiConn() {
            scannerCom.CloseCom();
        }
        public event Action<string> CodeReceived;
        private void ScannerCom_CodeReceived(string code) {
            CodeReceived?.Invoke(code);
        }

    }
}
