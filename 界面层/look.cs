using ScannerSerialPro.实体层;
using ScannerSerialPro.界面层;
using ScannerSerialPro.通信层;
using ScannerSerialPro.工具层;



namespace ScannerSerialPro
{
    public partial class look : Form
    {
        private string path = Application.StartupPath + "\\scanner.ini";
        private ScannerInfoService infoService = new ScannerInfoService();
        private ScannerInfo scannerInfo = null;

        public look()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmParamSet setForm = new FrmParamSet(this.path, this.scannerInfo, this.infoService);

            // 2. 以模态对话框形式打开（推荐用 ShowDialog，这样关掉设置窗之前不能点主界面）
            if (setForm.ShowDialog() == DialogResult.OK)
            {
                // 3. 当用户在设置界面点击了“确定”，可以在这里重新读取一下配置
                // （可选）重新加载配置：
                // this.scannerInfo = infoService.GetScannerInfoFromPath(path);
            }


        }

        private void Frm_Load_Click(object sender, EventArgs e)
        {

        }

        private ScannerComService comService = null;//声明数据层对象



        private void tsb_Connect_Click(object sender, EventArgs e)
        {
            if (this.scannerInfo == null)
            {
                MessageBox.Show("配置信息为空，请先在'串口设置'里保存参数！");
                return;
            }

            comService = new ScannerComService();
            comService.CodeReceived += ComService_CodeReceived; // 先绑定事件
            comService.Connect(this.scannerInfo); // 再连接
            this.tsb_Connect.Enabled = false;
            this.tsb_DisConnect.Enabled = true;
        }

        private void tsb_DisConnect_Click(object sender, EventArgs e)
        {
            this.comService?.DisConn();
            this.tsb_Connect.Enabled = true;
            this.tsb_DisConnect.Enabled = false;

        }

        private List<string> codeList = new List<string>();
        private void ComService_CodeReceived(string code)
        {
            if (string.IsNullOrEmpty(code)) return;

            // 1. 只要收到数据，立刻显示到界面上！
            AddLog("读取条形码：" + code);

            // 2. 然后存入列表，用于以后防重复（如果你需要去重的话）
            if (!codeList.Contains(code))
            {
                codeList.Add(code);
            }
        }
        private void AddLog(string message)
        {
            if (this.lst_Info.InvokeRequired)
            {
                this.lst_Info.Invoke(new Action<string>(AddLog), message);
            }
            else
            {
                this.lst_Info.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss") + message);
            }
        }

        private void lst_Info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void look_Load(object sender, EventArgs e)
        {
            try
            {
                this.scannerInfo = infoService.GetScannerInfoFromPath(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置信息加载失败！" + ex.Message, "读取配置。");
            }

        }
    }
}
