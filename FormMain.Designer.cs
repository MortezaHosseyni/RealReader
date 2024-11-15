namespace RealReader
{
    partial class FormMain
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
            lbl_Port = new Label();
            lbl_BaudRate = new Label();
            lbl_DataBits = new Label();
            txt_BaudRate = new TextBox();
            txt_Bits = new TextBox();
            cmb_Ports = new ComboBox();
            lbl_RealReader = new Label();
            rtb_Logs = new RichTextBox();
            btn_Read = new Button();
            btn_Save = new Button();
            btn_Clear = new Button();
            btn_ReloadPorts = new Button();
            SuspendLayout();
            // 
            // lbl_Port
            // 
            lbl_Port.AutoSize = true;
            lbl_Port.Location = new Point(54, 82);
            lbl_Port.Name = "lbl_Port";
            lbl_Port.Size = new Size(38, 21);
            lbl_Port.TabIndex = 0;
            lbl_Port.Text = "Port";
            // 
            // lbl_BaudRate
            // 
            lbl_BaudRate.AutoSize = true;
            lbl_BaudRate.Location = new Point(12, 117);
            lbl_BaudRate.Name = "lbl_BaudRate";
            lbl_BaudRate.Size = new Size(80, 21);
            lbl_BaudRate.TabIndex = 1;
            lbl_BaudRate.Text = "Baud Rate";
            // 
            // lbl_DataBits
            // 
            lbl_DataBits.AutoSize = true;
            lbl_DataBits.Location = new Point(434, 117);
            lbl_DataBits.Name = "lbl_DataBits";
            lbl_DataBits.Size = new Size(71, 21);
            lbl_DataBits.TabIndex = 2;
            lbl_DataBits.Text = "Data Bits";
            // 
            // txt_BaudRate
            // 
            txt_BaudRate.BackColor = Color.Black;
            txt_BaudRate.ForeColor = Color.Cyan;
            txt_BaudRate.Location = new Point(98, 114);
            txt_BaudRate.Name = "txt_BaudRate";
            txt_BaudRate.Size = new Size(330, 29);
            txt_BaudRate.TabIndex = 3;
            txt_BaudRate.Text = "9600";
            // 
            // txt_Bits
            // 
            txt_Bits.BackColor = Color.Black;
            txt_Bits.ForeColor = Color.Cyan;
            txt_Bits.Location = new Point(511, 114);
            txt_Bits.Name = "txt_Bits";
            txt_Bits.Size = new Size(85, 29);
            txt_Bits.TabIndex = 4;
            txt_Bits.Text = "8";
            // 
            // cmb_Ports
            // 
            cmb_Ports.BackColor = Color.Black;
            cmb_Ports.ForeColor = Color.Cyan;
            cmb_Ports.FormattingEnabled = true;
            cmb_Ports.Location = new Point(98, 79);
            cmb_Ports.Name = "cmb_Ports";
            cmb_Ports.Size = new Size(330, 29);
            cmb_Ports.TabIndex = 5;
            // 
            // lbl_RealReader
            // 
            lbl_RealReader.AutoSize = true;
            lbl_RealReader.Font = new Font("Segoe UI", 18F);
            lbl_RealReader.Location = new Point(236, 9);
            lbl_RealReader.Name = "lbl_RealReader";
            lbl_RealReader.Size = new Size(138, 32);
            lbl_RealReader.TabIndex = 6;
            lbl_RealReader.Text = "Real Reader";
            // 
            // rtb_Logs
            // 
            rtb_Logs.BackColor = Color.Black;
            rtb_Logs.ForeColor = Color.Cyan;
            rtb_Logs.Location = new Point(12, 276);
            rtb_Logs.Name = "rtb_Logs";
            rtb_Logs.Size = new Size(584, 222);
            rtb_Logs.TabIndex = 7;
            rtb_Logs.Text = "";
            // 
            // btn_Read
            // 
            btn_Read.BackColor = Color.Black;
            btn_Read.Location = new Point(12, 161);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(584, 41);
            btn_Read.TabIndex = 8;
            btn_Read.Text = "Read";
            btn_Read.UseVisualStyleBackColor = false;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Black;
            btn_Save.Location = new Point(561, 237);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(35, 33);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "💾";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.Black;
            btn_Clear.Location = new Point(520, 237);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(35, 33);
            btn_Clear.TabIndex = 10;
            btn_Clear.Text = "\U0001f9f9";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_ReloadPorts
            // 
            btn_ReloadPorts.BackColor = Color.Black;
            btn_ReloadPorts.Location = new Point(434, 79);
            btn_ReloadPorts.Name = "btn_ReloadPorts";
            btn_ReloadPorts.Size = new Size(39, 29);
            btn_ReloadPorts.TabIndex = 11;
            btn_ReloadPorts.Text = "🔄";
            btn_ReloadPorts.UseVisualStyleBackColor = false;
            btn_ReloadPorts.Click += btn_ReloadPorts_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(608, 510);
            Controls.Add(btn_ReloadPorts);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(btn_Read);
            Controls.Add(rtb_Logs);
            Controls.Add(lbl_RealReader);
            Controls.Add(cmb_Ports);
            Controls.Add(txt_Bits);
            Controls.Add(txt_BaudRate);
            Controls.Add(lbl_DataBits);
            Controls.Add(lbl_BaudRate);
            Controls.Add(lbl_Port);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(0, 192, 192);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(624, 549);
            MinimumSize = new Size(624, 549);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Reader";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Port;
        private Label lbl_BaudRate;
        private Label lbl_DataBits;
        private TextBox txt_BaudRate;
        private TextBox txt_Bits;
        private ComboBox cmb_Ports;
        private Label lbl_RealReader;
        private RichTextBox rtb_Logs;
        private Button btn_Read;
        private Button btn_Save;
        private Button btn_Clear;
        private Button btn_ReloadPorts;
    }
}
