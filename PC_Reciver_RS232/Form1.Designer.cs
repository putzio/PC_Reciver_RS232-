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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonChart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.groupBoxConnected = new System.Windows.Forms.GroupBox();
            this.numericUpDownHight = new System.Windows.Forms.NumericUpDown();
            this.buttonPreassureFromHight = new System.Windows.Forms.Button();
            this.numericUpDownPreassure = new System.Windows.Forms.NumericUpDown();
            this.buttonWritePreassure = new System.Windows.Forms.Button();
            this.buttonClearFlash = new System.Windows.Forms.Button();
            this.buttonShowMessages = new System.Windows.Forms.Button();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonActual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxConnected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreassure)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(143, 93);
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
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(12, 307);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1109, 311);
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
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.comboBox_Baud);
            this.groupBox1.Controls.Add(this.comboBox_Port);
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry połączenia";
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
            this.textBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo.Location = new System.Drawing.Point(859, 63);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(262, 238);
            this.textBoxInfo.TabIndex = 5;
            this.textBoxInfo.Visible = false;
            // 
            // groupBoxConnected
            // 
            this.groupBoxConnected.Controls.Add(this.buttonActual);
            this.groupBoxConnected.Controls.Add(this.numericUpDownHight);
            this.groupBoxConnected.Controls.Add(this.buttonPreassureFromHight);
            this.groupBoxConnected.Controls.Add(this.numericUpDownPreassure);
            this.groupBoxConnected.Controls.Add(this.buttonWritePreassure);
            this.groupBoxConnected.Controls.Add(this.buttonClearFlash);
            this.groupBoxConnected.Controls.Add(this.buttonChart);
            this.groupBoxConnected.Enabled = false;
            this.groupBoxConnected.Location = new System.Drawing.Point(460, 14);
            this.groupBoxConnected.Name = "groupBoxConnected";
            this.groupBoxConnected.Size = new System.Drawing.Size(377, 271);
            this.groupBoxConnected.TabIndex = 6;
            this.groupBoxConnected.TabStop = false;
            this.groupBoxConnected.Text = "Operacje po połączeniu";
            // 
            // numericUpDownHight
            // 
            this.numericUpDownHight.Location = new System.Drawing.Point(23, 167);
            this.numericUpDownHight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownHight.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDownHight.Name = "numericUpDownHight";
            this.numericUpDownHight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHight.TabIndex = 8;
            this.numericUpDownHight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // buttonPreassureFromHight
            // 
            this.buttonPreassureFromHight.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonPreassureFromHight.Location = new System.Drawing.Point(149, 152);
            this.buttonPreassureFromHight.Name = "buttonPreassureFromHight";
            this.buttonPreassureFromHight.Size = new System.Drawing.Size(210, 50);
            this.buttonPreassureFromHight.TabIndex = 7;
            this.buttonPreassureFromHight.Text = "Przelicz ciśnienie dla podanej wysokości";
            this.buttonPreassureFromHight.UseVisualStyleBackColor = true;
            this.buttonPreassureFromHight.Click += new System.EventHandler(this.buttonPreassureFromHight_Click);
            // 
            // numericUpDownPreassure
            // 
            this.numericUpDownPreassure.Location = new System.Drawing.Point(23, 111);
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
            this.buttonWritePreassure.Location = new System.Drawing.Point(149, 107);
            this.buttonWritePreassure.Name = "buttonWritePreassure";
            this.buttonWritePreassure.Size = new System.Drawing.Size(210, 29);
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
            // buttonShowMessages
            // 
            this.buttonShowMessages.Location = new System.Drawing.Point(859, 22);
            this.buttonShowMessages.Name = "buttonShowMessages";
            this.buttonShowMessages.Size = new System.Drawing.Size(262, 35);
            this.buttonShowMessages.TabIndex = 7;
            this.buttonShowMessages.Text = "Pokaż odbierane wiadomości";
            this.buttonShowMessages.UseVisualStyleBackColor = true;
            this.buttonShowMessages.Click += new System.EventHandler(this.buttonShowMessages_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(12, 186);
            this.textBoxTest.Multiline = true;
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTest.Size = new System.Drawing.Size(432, 90);
            this.textBoxTest.TabIndex = 8;
            // 
            // buttonActual
            // 
            this.buttonActual.Location = new System.Drawing.Point(23, 219);
            this.buttonActual.Name = "buttonActual";
            this.buttonActual.Size = new System.Drawing.Size(336, 29);
            this.buttonActual.TabIndex = 9;
            this.buttonActual.Text = "Podaj aktualne wskazania";
            this.buttonActual.UseMnemonic = false;
            this.buttonActual.UseVisualStyleBackColor = true;
            this.buttonActual.Click += new System.EventHandler(this.buttonActual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 630);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.buttonShowMessages);
            this.Controls.Add(this.groupBoxConnected);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Połączenie RS232";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxConnected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreassure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button buttonShowMessages;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.NumericUpDown numericUpDownHight;
        private System.Windows.Forms.Button buttonPreassureFromHight;
        private System.Windows.Forms.Button buttonActual;
    }
}

