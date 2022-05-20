namespace PC_Reciver_RS232
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonConnectionSettings = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonChart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.groupBoxConnected = new System.Windows.Forms.GroupBox();
            this.numericUpDownPreassure = new System.Windows.Forms.NumericUpDown();
            this.buttonWritePreassure = new System.Windows.Forms.Button();
            this.buttonClearFlash = new System.Windows.Forms.Button();
            this.textBoxError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxConnected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreassure)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnectionSettings
            // 
            this.buttonConnectionSettings.Location = new System.Drawing.Point(12, 282);
            this.buttonConnectionSettings.Name = "buttonConnectionSettings";
            this.buttonConnectionSettings.Size = new System.Drawing.Size(168, 35);
            this.buttonConnectionSettings.TabIndex = 0;
            this.buttonConnectionSettings.Text = "Ustawienia połączenia";
            this.buttonConnectionSettings.UseVisualStyleBackColor = true;
            this.buttonConnectionSettings.Click += new System.EventHandler(this.buttonConnectionSettings_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(143, 223);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(273, 35);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Otwórz";
            this.buttonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 358);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1034, 260);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(23, 36);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(336, 29);
            this.buttonChart.TabIndex = 3;
            this.buttonChart.Text = "Rysuj wykres";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_controlProtocol);
            this.groupBox1.Controls.Add(this.comboBox_Parity);
            this.groupBox1.Controls.Add(this.comboBox_Stop);
            this.groupBox1.Controls.Add(this.comboBox_BitNr);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_Baud);
            this.groupBox1.Controls.Add(this.comboBox_Port);
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry połączenia";
            // 
            // comboBox_controlProtocol
            // 
            this.comboBox_controlProtocol.FormattingEnabled = true;
            this.comboBox_controlProtocol.Location = new System.Drawing.Point(144, 189);
            this.comboBox_controlProtocol.Name = "comboBox_controlProtocol";
            this.comboBox_controlProtocol.Size = new System.Drawing.Size(272, 24);
            this.comboBox_controlProtocol.TabIndex = 56;
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
            this.comboBox_Parity.Location = new System.Drawing.Point(143, 126);
            this.comboBox_Parity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(272, 24);
            this.comboBox_Parity.TabIndex = 55;
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
            this.comboBox_Stop.Location = new System.Drawing.Point(143, 158);
            this.comboBox_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Stop.Name = "comboBox_Stop";
            this.comboBox_Stop.Size = new System.Drawing.Size(272, 24);
            this.comboBox_Stop.TabIndex = 54;
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
            this.comboBox_BitNr.Location = new System.Drawing.Point(143, 94);
            this.comboBox_BitNr.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BitNr.Name = "comboBox_BitNr";
            this.comboBox_BitNr.Size = new System.Drawing.Size(272, 24);
            this.comboBox_BitNr.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Protokół konntroli:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Bit stopu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Bit parzystości:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Liczba bitów:";
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Location = new System.Drawing.Point(143, 62);
            this.comboBox_Baud.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(272, 24);
            this.comboBox_Baud.TabIndex = 48;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(146, 26);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Port.TabIndex = 47;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(316, 26);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 28);
            this.button_Refresh.TabIndex = 45;
            this.button_Refresh.Text = "Odśwież";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Port:";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(767, 235);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(238, 107);
            this.textBoxInfo.TabIndex = 5;
            // 
            // groupBoxConnected
            // 
            this.groupBoxConnected.Controls.Add(this.numericUpDownPreassure);
            this.groupBoxConnected.Controls.Add(this.buttonWritePreassure);
            this.groupBoxConnected.Controls.Add(this.buttonClearFlash);
            this.groupBoxConnected.Controls.Add(this.buttonChart);
            this.groupBoxConnected.Enabled = false;
            this.groupBoxConnected.Location = new System.Drawing.Point(647, 35);
            this.groupBoxConnected.Name = "groupBoxConnected";
            this.groupBoxConnected.Size = new System.Drawing.Size(377, 148);
            this.groupBoxConnected.TabIndex = 6;
            this.groupBoxConnected.TabStop = false;
            this.groupBoxConnected.Text = "Operacje po połączeniu";
            // 
            // numericUpDownPreassure
            // 
            this.numericUpDownPreassure.Location = new System.Drawing.Point(23, 113);
            this.numericUpDownPreassure.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownPreassure.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPreassure.Name = "numericUpDownPreassure";
            this.numericUpDownPreassure.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPreassure.TabIndex = 6;
            this.numericUpDownPreassure.Value = new decimal(new int[] {
            1020,
            0,
            0,
            0});
            // 
            // buttonWritePreassure
            // 
            this.buttonWritePreassure.Location = new System.Drawing.Point(168, 107);
            this.buttonWritePreassure.Name = "buttonWritePreassure";
            this.buttonWritePreassure.Size = new System.Drawing.Size(191, 29);
            this.buttonWritePreassure.TabIndex = 5;
            this.buttonWritePreassure.Text = "Ustaw ciśnienie";
            this.buttonWritePreassure.UseVisualStyleBackColor = true;
            this.buttonWritePreassure.Click += new System.EventHandler(this.buttonWritePreassure_Click);
            // 
            // buttonClearFlash
            // 
            this.buttonClearFlash.Location = new System.Drawing.Point(23, 72);
            this.buttonClearFlash.Name = "buttonClearFlash";
            this.buttonClearFlash.Size = new System.Drawing.Size(336, 29);
            this.buttonClearFlash.TabIndex = 4;
            this.buttonClearFlash.Text = "Wyczyść Flash";
            this.buttonClearFlash.UseVisualStyleBackColor = true;
            this.buttonClearFlash.Click += new System.EventHandler(this.buttonClearFlash_Click);
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(468, 235);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(238, 107);
            this.textBoxError.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 630);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.groupBoxConnected);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.buttonConnectionSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxConnected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreassure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectionSettings;
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxConnected;
        private System.Windows.Forms.NumericUpDown numericUpDownPreassure;
        private System.Windows.Forms.Button buttonWritePreassure;
        private System.Windows.Forms.Button buttonClearFlash;
        private System.Windows.Forms.TextBox textBoxError;
    }
}

