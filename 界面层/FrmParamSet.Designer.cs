namespace ScannerSerialPro.界面层
{
    partial class FrmParamSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_OK = new Button();
            button2 = new Button();
            cmb_Port = new ComboBox();
            cmb_Parity = new ComboBox();
            cmb_StopBits = new ComboBox();
            cmb_BaudRate = new ComboBox();
            cmb_DataBits = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "端口号";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 146);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "校验位";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 225);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 2;
            label3.Text = "停止位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 79);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 3;
            label4.Text = "波特率";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 146);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 4;
            label5.Text = "数据位";
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(408, 282);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(112, 34);
            btn_OK.TabIndex = 5;
            btn_OK.Text = "确定";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // button2
            // 
            button2.Location = new Point(544, 282);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            // 
            // cmb_Port
            // 
            cmb_Port.FormattingEnabled = true;
            cmb_Port.Location = new Point(190, 76);
            cmb_Port.Name = "cmb_Port";
            cmb_Port.Size = new Size(182, 32);
            cmb_Port.TabIndex = 7;
            // 
            // cmb_Parity
            // 
            cmb_Parity.FormattingEnabled = true;
            cmb_Parity.Location = new Point(190, 143);
            cmb_Parity.Name = "cmb_Parity";
            cmb_Parity.Size = new Size(182, 32);
            cmb_Parity.TabIndex = 8;
            // 
            // cmb_StopBits
            // 
            cmb_StopBits.FormattingEnabled = true;
            cmb_StopBits.Location = new Point(190, 222);
            cmb_StopBits.Name = "cmb_StopBits";
            cmb_StopBits.Size = new Size(182, 32);
            cmb_StopBits.TabIndex = 9;
            // 
            // cmb_BaudRate
            // 
            cmb_BaudRate.FormattingEnabled = true;
            cmb_BaudRate.Location = new Point(499, 76);
            cmb_BaudRate.Name = "cmb_BaudRate";
            cmb_BaudRate.Size = new Size(182, 32);
            cmb_BaudRate.TabIndex = 10;
            // 
            // cmb_DataBits
            // 
            cmb_DataBits.FormattingEnabled = true;
            cmb_DataBits.Location = new Point(499, 143);
            cmb_DataBits.Name = "cmb_DataBits";
            cmb_DataBits.Size = new Size(182, 32);
            cmb_DataBits.TabIndex = 11;
            // 
            // FrmParamSet
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_DataBits);
            Controls.Add(cmb_BaudRate);
            Controls.Add(cmb_StopBits);
            Controls.Add(cmb_Parity);
            Controls.Add(cmb_Port);
            Controls.Add(button2);
            Controls.Add(btn_OK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmParamSet";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_OK;
        private Button button2;
        private ComboBox cmb_Port;
        private ComboBox cmb_Parity;
        private ComboBox cmb_StopBits;
        private ComboBox cmb_BaudRate;
        private ComboBox cmb_DataBits;
    }
}