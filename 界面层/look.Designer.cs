namespace ScannerSerialPro
{
    partial class look
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(look));
            toolStrip1 = new ToolStrip();
            tsb_Connect = new ToolStripButton();
            tsb_DisConnect = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            lst_Info = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Frm_Load = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.AppWorkspace;
            toolStrip1.ImageScalingSize = new Size(160, 160);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_Connect, tsb_DisConnect, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1069, 165);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Connect
            // 
            tsb_Connect.AutoSize = false;
            tsb_Connect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Connect.Image = (Image)resources.GetObject("tsb_Connect.Image");
            tsb_Connect.ImageTransparentColor = Color.Magenta;
            tsb_Connect.Name = "tsb_Connect";
            tsb_Connect.Size = new Size(160, 160);
            tsb_Connect.Text = "toolStripButton1";
            tsb_Connect.Click += tsb_Connect_Click;
            // 
            // tsb_DisConnect
            // 
            tsb_DisConnect.AutoSize = false;
            tsb_DisConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_DisConnect.Image = (Image)resources.GetObject("tsb_DisConnect.Image");
            tsb_DisConnect.ImageTransparentColor = Color.Magenta;
            tsb_DisConnect.Name = "tsb_DisConnect";
            tsb_DisConnect.Size = new Size(160, 160);
            tsb_DisConnect.Text = "toolStripButton2";
            tsb_DisConnect.Click += tsb_DisConnect_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(160, 160);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // lst_Info
            // 
            lst_Info.FormattingEnabled = true;
            lst_Info.Location = new Point(22, 304);
            lst_Info.Name = "lst_Info";
            lst_Info.Size = new Size(1024, 340);
            lst_Info.TabIndex = 1;
            lst_Info.SelectedIndexChanged += lst_Info_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 220);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 2;
            label1.Text = "接收消息【双击清空】";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 30);
            textBox1.TabIndex = 3;
            // 
            // Frm_Load
            // 
            Frm_Load.Location = new Point(606, 216);
            Frm_Load.Name = "Frm_Load";
            Frm_Load.Size = new Size(112, 34);
            Frm_Load.TabIndex = 4;
            Frm_Load.Text = "手动输入";
            Frm_Load.UseVisualStyleBackColor = true;
            Frm_Load.Click += Frm_Load_Click;
            // 
            // look
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1069, 707);
            Controls.Add(toolStrip1);
            Controls.Add(Frm_Load);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lst_Info);
            Name = "look";
            Text = "Form1";
            Load += look_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsb_Connect;
        private ToolStripButton tsb_DisConnect;
        private ToolStripButton toolStripButton3;
        private ListBox lst_Info;
        private Label label1;
        private TextBox textBox1;
        private Button Frm_Load;
    }
}
