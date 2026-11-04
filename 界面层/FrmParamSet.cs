using ScannerSerialPro.实体层;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ScannerSerialPro.界面层
{
    public partial class FrmParamSet : Form
    {
        private string path;// 保存 ini 文件的路径
        private ScannerInfo scannerInfo; // 保存配置信息的实体类
        private ScannerInfoService infoService;// 保存处理读写配置的服务类

        public FrmParamSet(string path, ScannerInfo scannerInfo, ScannerInfoService infoService)
        {
            InitializeComponent();
            this.cmb_Port.Items.AddRange(SerialPort.GetPortNames());
            this.cmb_BaudRate.Items.AddRange(new string[] { "9600", "19200" });
            this.cmb_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            this.cmb_DataBits.Items.AddRange(new string[] { "7", "8" });
            this.cmb_StopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            this.path = path;
            this.scannerInfo = scannerInfo;
            this.infoService = infoService;
            if (this.scannerInfo != null)
            {
                this.cmb_Port.Text = this.scannerInfo.PortNname;
                this.cmb_BaudRate.Text = this.scannerInfo.BaudRate.ToString();
                this.cmb_Parity.Text = this.scannerInfo.Parity.ToString();
                this.cmb_DataBits.Text = this.scannerInfo.DataBits.ToString();
                this.cmb_StopBits.Text = this.scannerInfo.StopBits.ToString();//
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (this.scannerInfo == null) 
             this.scannerInfo = new ScannerInfo();
            this.scannerInfo.PortNname = this.cmb_Port.Text.Trim();
            this.scannerInfo.BaudRate = Convert.ToInt32(this.cmb_BaudRate.Text.Trim());
            this.scannerInfo.Parity = (Parity)Enum.Parse(typeof(Parity), this.cmb_Parity.Text.Trim(), true);
            this.scannerInfo.DataBits = Convert.ToInt32(this.cmb_DataBits.Text.Trim());
            this.scannerInfo.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cmb_StopBits.Text.Trim(), true);
            bool result = this.infoService.SetCcannerInfoToPath(this.scannerInfo, this.path);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else { MessageBox.Show("拍照信息保存失败", "保存配置"); }

        }
    }
}
