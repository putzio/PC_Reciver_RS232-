namespace PC_Reciver_RS232
{
    partial class ConnectionSettings
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_controlProtocol = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.comboBox_Stop = new System.Windows.Forms.ComboBox();
            this.comboBox_BitNr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_controlProtocol
            // 
            this.comboBox_controlProtocol.FormattingEnabled = true;
            this.comboBox_controlProtocol.Location = new System.Drawing.Point(155, 202);
            this.comboBox_controlProtocol.Name = "comboBox_controlProtocol";
            this.comboBox_controlProtocol.Size = new System.Drawing.Size(272, 24);
            this.comboBox_controlProtocol.TabIndex = 42;
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_Parity.Location = new System.Drawing.Point(154, 139);
            this.comboBox_Parity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(272, 24);
            this.comboBox_Parity.TabIndex = 41;
            // 
            // comboBox_Stop
            // 
            this.comboBox_Stop.FormattingEnabled = true;
            this.comboBox_Stop.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_Stop.Location = new System.Drawing.Point(154, 171);
            this.comboBox_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Stop.Name = "comboBox_Stop";
            this.comboBox_Stop.Size = new System.Drawing.Size(272, 24);
            this.comboBox_Stop.TabIndex = 40;
            // 
            // comboBox_BitNr
            // 
            this.comboBox_BitNr.FormattingEnabled = true;
            this.comboBox_BitNr.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_BitNr.Location = new System.Drawing.Point(154, 107);
            this.comboBox_BitNr.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BitNr.Name = "comboBox_BitNr";
            this.comboBox_BitNr.Size = new System.Drawing.Size(272, 24);
            this.comboBox_BitNr.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Protokół konntroli:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Bit stopu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Bit parzystości:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Liczba bitów:";
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Location = new System.Drawing.Point(154, 75);
            this.comboBox_Baud.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(272, 24);
            this.comboBox_Baud.TabIndex = 34;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(157, 39);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Port.TabIndex = 33;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(158, 233);
            this.button_Open.Margin = new System.Windows.Forms.Padding(4);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(269, 28);
            this.button_Open.TabIndex = 32;
            this.button_Open.Text = "Otwórz";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(327, 39);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 28);
            this.button_Refresh.TabIndex = 31;
            this.button_Refresh.Text = "Odśwież";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Port:";
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_controlProtocol);
            this.Controls.Add(this.comboBox_Parity);
            this.Controls.Add(this.comboBox_Stop);
            this.Controls.Add(this.comboBox_BitNr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Baud);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ConnectionSettings";
            this.Text = "ConnectionSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_controlProtocol;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.ComboBox comboBox_Stop;
        private System.Windows.Forms.ComboBox comboBox_BitNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Baud;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}