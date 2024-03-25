namespace aquacaredash
{
    partial class form_Realtime
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
            components = new System.ComponentModel.Container();
            btn_realtime = new Button();
            lbl_realtime = new Label();
            textbox_realtimeCurrent = new TextBox();
            textbox_datetime = new TextBox();
            textbox_realtimevoltage = new TextBox();
            label1 = new Label();
            label_voltage = new Label();
            combox_device = new ComboBox();
            textbox_mpptvoltage = new TextBox();
            textbox_mpptcurrent = new TextBox();
            textbox_Cellvoltage = new TextBox();
            textbox_cellcurrent = new TextBox();
            label_devicelocation = new Label();
            label_mpptvoltage = new Label();
            label_mpptcurrent = new Label();
            label_cellACvoltage = new Label();
            label_cellACcurrent = new Label();
            groupboxACDC = new GroupBox();
            groupbox_mppt = new GroupBox();
            textBox_programdata = new TextBox();
            button_stop = new Button();
            groupbox_output = new GroupBox();
            currentplot = new ScottPlot.WinForms.FormsPlot();
            timer1 = new System.Windows.Forms.Timer(components);
            textBOX_CELLPERCENTAGE = new TextBox();
            label_cellpercentage = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labe_ACVoltage = new Label();
            label_ACCurrentDraw = new Label();
            groupBox_ACData = new GroupBox();
            groupboxACDC.SuspendLayout();
            groupbox_mppt.SuspendLayout();
            groupbox_output.SuspendLayout();
            groupBox_ACData.SuspendLayout();
            SuspendLayout();
            // 
            // btn_realtime
            // 
            btn_realtime.Location = new Point(23, 12);
            btn_realtime.Name = "btn_realtime";
            btn_realtime.Size = new Size(75, 23);
            btn_realtime.TabIndex = 0;
            btn_realtime.Text = "Realtime Fetch";
            btn_realtime.UseVisualStyleBackColor = true;
            btn_realtime.Click += btn_realtime_Click;
            // 
            // lbl_realtime
            // 
            lbl_realtime.AutoSize = true;
            lbl_realtime.Location = new Point(57, 96);
            lbl_realtime.Name = "lbl_realtime";
            lbl_realtime.Size = new Size(93, 15);
            lbl_realtime.TabIndex = 1;
            lbl_realtime.Text = "Current Reading";
            // 
            // textbox_realtimeCurrent
            // 
            textbox_realtimeCurrent.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_realtimeCurrent.Location = new Point(7, 22);
            textbox_realtimeCurrent.Name = "textbox_realtimeCurrent";
            textbox_realtimeCurrent.Size = new Size(193, 71);
            textbox_realtimeCurrent.TabIndex = 2;
            textbox_realtimeCurrent.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox_datetime
            // 
            textbox_datetime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_datetime.Location = new Point(394, 12);
            textbox_datetime.Name = "textbox_datetime";
            textbox_datetime.Size = new Size(178, 32);
            textbox_datetime.TabIndex = 3;
            textbox_datetime.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox_realtimevoltage
            // 
            textbox_realtimevoltage.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_realtimevoltage.Location = new Point(231, 34);
            textbox_realtimevoltage.Name = "textbox_realtimevoltage";
            textbox_realtimevoltage.Size = new Size(107, 36);
            textbox_realtimevoltage.TabIndex = 4;
            textbox_realtimevoltage.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 47);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 5;
            label1.Text = "Date and Time";
            // 
            // label_voltage
            // 
            label_voltage.AutoSize = true;
            label_voltage.Location = new Point(263, 73);
            label_voltage.Name = "label_voltage";
            label_voltage.Size = new Size(46, 15);
            label_voltage.TabIndex = 6;
            label_voltage.Text = "Voltage";
            // 
            // combox_device
            // 
            combox_device.FormattingEnabled = true;
            combox_device.Location = new Point(112, 13);
            combox_device.Name = "combox_device";
            combox_device.Size = new Size(163, 23);
            combox_device.TabIndex = 7;
            // 
            // textbox_mpptvoltage
            // 
            textbox_mpptvoltage.Location = new Point(6, 38);
            textbox_mpptvoltage.Name = "textbox_mpptvoltage";
            textbox_mpptvoltage.Size = new Size(108, 23);
            textbox_mpptvoltage.TabIndex = 8;
            textbox_mpptvoltage.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox_mpptcurrent
            // 
            textbox_mpptcurrent.Location = new Point(189, 38);
            textbox_mpptcurrent.Name = "textbox_mpptcurrent";
            textbox_mpptcurrent.Size = new Size(117, 23);
            textbox_mpptcurrent.TabIndex = 9;
            textbox_mpptcurrent.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox_Cellvoltage
            // 
            textbox_Cellvoltage.Location = new Point(33, 40);
            textbox_Cellvoltage.Name = "textbox_Cellvoltage";
            textbox_Cellvoltage.Size = new Size(120, 23);
            textbox_Cellvoltage.TabIndex = 10;
            textbox_Cellvoltage.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox_cellcurrent
            // 
            textbox_cellcurrent.Location = new Point(183, 40);
            textbox_cellcurrent.Name = "textbox_cellcurrent";
            textbox_cellcurrent.Size = new Size(122, 23);
            textbox_cellcurrent.TabIndex = 11;
            textbox_cellcurrent.TextAlign = HorizontalAlignment.Center;
            // 
            // label_devicelocation
            // 
            label_devicelocation.AutoSize = true;
            label_devicelocation.Location = new Point(163, 39);
            label_devicelocation.Name = "label_devicelocation";
            label_devicelocation.Size = new Size(53, 15);
            label_devicelocation.TabIndex = 12;
            label_devicelocation.Text = "Location";
            // 
            // label_mpptvoltage
            // 
            label_mpptvoltage.AutoSize = true;
            label_mpptvoltage.Location = new Point(24, 74);
            label_mpptvoltage.Name = "label_mpptvoltage";
            label_mpptvoltage.Size = new Size(80, 15);
            label_mpptvoltage.TabIndex = 13;
            label_mpptvoltage.Text = "MPPT Voltage";
            // 
            // label_mpptcurrent
            // 
            label_mpptcurrent.AutoSize = true;
            label_mpptcurrent.Location = new Point(211, 74);
            label_mpptcurrent.Name = "label_mpptcurrent";
            label_mpptcurrent.Size = new Size(81, 15);
            label_mpptcurrent.TabIndex = 14;
            label_mpptcurrent.Text = "MPPT Current";
            // 
            // label_cellACvoltage
            // 
            label_cellACvoltage.AutoSize = true;
            label_cellACvoltage.Location = new Point(65, 67);
            label_cellACvoltage.Name = "label_cellACvoltage";
            label_cellACvoltage.Size = new Size(69, 15);
            label_cellACvoltage.TabIndex = 15;
            label_cellACvoltage.Text = "Cell Voltage";
            // 
            // label_cellACcurrent
            // 
            label_cellACcurrent.AutoSize = true;
            label_cellACcurrent.Location = new Point(205, 67);
            label_cellACcurrent.Name = "label_cellACcurrent";
            label_cellACcurrent.Size = new Size(70, 15);
            label_cellACcurrent.TabIndex = 16;
            label_cellACcurrent.Text = "Cell Current";
            // 
            // groupboxACDC
            // 
            groupboxACDC.Controls.Add(label_cellpercentage);
            groupboxACDC.Controls.Add(textBOX_CELLPERCENTAGE);
            groupboxACDC.Controls.Add(label_cellACcurrent);
            groupboxACDC.Controls.Add(label_cellACvoltage);
            groupboxACDC.Controls.Add(textbox_cellcurrent);
            groupboxACDC.Controls.Add(textbox_Cellvoltage);
            groupboxACDC.Location = new Point(390, 201);
            groupboxACDC.Name = "groupboxACDC";
            groupboxACDC.Size = new Size(331, 154);
            groupboxACDC.TabIndex = 17;
            groupboxACDC.TabStop = false;
            groupboxACDC.Text = "Battery Cell Data";
            // 
            // groupbox_mppt
            // 
            groupbox_mppt.Controls.Add(label_mpptcurrent);
            groupbox_mppt.Controls.Add(label_mpptvoltage);
            groupbox_mppt.Controls.Add(textbox_mpptcurrent);
            groupbox_mppt.Controls.Add(textbox_mpptvoltage);
            groupbox_mppt.Location = new Point(23, 201);
            groupbox_mppt.Name = "groupbox_mppt";
            groupbox_mppt.Size = new Size(338, 123);
            groupbox_mppt.TabIndex = 18;
            groupbox_mppt.TabStop = false;
            groupbox_mppt.Text = "MPPT Charging Data";
            // 
            // textBox_programdata
            // 
            textBox_programdata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_programdata.Location = new Point(823, 8);
            textBox_programdata.Multiline = true;
            textBox_programdata.Name = "textBox_programdata";
            textBox_programdata.Size = new Size(429, 205);
            textBox_programdata.TabIndex = 190;
            // 
            // button_stop
            // 
            button_stop.BackColor = Color.Red;
            button_stop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_stop.ForeColor = SystemColors.ControlText;
            button_stop.Location = new Point(304, 13);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(75, 31);
            button_stop.TabIndex = 191;
            button_stop.Text = "STOP";
            button_stop.UseVisualStyleBackColor = false;
            button_stop.Click += button_stop_Click;
            // 
            // groupbox_output
            // 
            groupbox_output.Controls.Add(label_voltage);
            groupbox_output.Controls.Add(textbox_realtimevoltage);
            groupbox_output.Controls.Add(textbox_realtimeCurrent);
            groupbox_output.Controls.Add(lbl_realtime);
            groupbox_output.Location = new Point(163, 74);
            groupbox_output.Name = "groupbox_output";
            groupbox_output.Size = new Size(356, 121);
            groupbox_output.TabIndex = 192;
            groupbox_output.TabStop = false;
            groupbox_output.Text = "Output Data";
            // 
            // currentplot
            // 
            currentplot.DisplayScale = 1F;
            currentplot.Location = new Point(16, 361);
            currentplot.Name = "currentplot";
            currentplot.Size = new Size(705, 300);
            currentplot.TabIndex = 193;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBOX_CELLPERCENTAGE
            // 
            textBOX_CELLPERCENTAGE.Location = new Point(112, 94);
            textBOX_CELLPERCENTAGE.Name = "textBOX_CELLPERCENTAGE";
            textBOX_CELLPERCENTAGE.Size = new Size(119, 23);
            textBOX_CELLPERCENTAGE.TabIndex = 17;
            // 
            // label_cellpercentage
            // 
            label_cellpercentage.AutoSize = true;
            label_cellpercentage.Location = new Point(133, 120);
            label_cellpercentage.Name = "label_cellpercentage";
            label_cellpercentage.Size = new Size(89, 15);
            label_cellpercentage.TabIndex = 18;
            label_cellpercentage.Text = "Cell Percentage";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 194;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 195;
            // 
            // labe_ACVoltage
            // 
            labe_ACVoltage.AutoSize = true;
            labe_ACVoltage.Location = new Point(57, 62);
            labe_ACVoltage.Name = "labe_ACVoltage";
            labe_ACVoltage.Size = new Size(65, 15);
            labe_ACVoltage.TabIndex = 196;
            labe_ACVoltage.Text = "AC Voltage";
            // 
            // label_ACCurrentDraw
            // 
            label_ACCurrentDraw.AutoSize = true;
            label_ACCurrentDraw.Location = new Point(180, 62);
            label_ACCurrentDraw.Name = "label_ACCurrentDraw";
            label_ACCurrentDraw.Size = new Size(96, 15);
            label_ACCurrentDraw.TabIndex = 197;
            label_ACCurrentDraw.Text = "AC Current Draw";
            // 
            // groupBox_ACData
            // 
            groupBox_ACData.Controls.Add(label_ACCurrentDraw);
            groupBox_ACData.Controls.Add(labe_ACVoltage);
            groupBox_ACData.Controls.Add(textBox2);
            groupBox_ACData.Controls.Add(textBox1);
            groupBox_ACData.Location = new Point(740, 239);
            groupBox_ACData.Name = "groupBox_ACData";
            groupBox_ACData.Size = new Size(314, 107);
            groupBox_ACData.TabIndex = 198;
            groupBox_ACData.TabStop = false;
            groupBox_ACData.Text = "AC Grid Data";
            // 
            // form_Realtime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(groupBox_ACData);
            Controls.Add(currentplot);
            Controls.Add(groupbox_output);
            Controls.Add(button_stop);
            Controls.Add(textBox_programdata);
            Controls.Add(groupbox_mppt);
            Controls.Add(groupboxACDC);
            Controls.Add(label_devicelocation);
            Controls.Add(combox_device);
            Controls.Add(label1);
            Controls.Add(textbox_datetime);
            Controls.Add(btn_realtime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Realtime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chlorinator Machine- Dev Software";
            Load += Form1_Load;
            groupboxACDC.ResumeLayout(false);
            groupboxACDC.PerformLayout();
            groupbox_mppt.ResumeLayout(false);
            groupbox_mppt.PerformLayout();
            groupbox_output.ResumeLayout(false);
            groupbox_output.PerformLayout();
            groupBox_ACData.ResumeLayout(false);
            groupBox_ACData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_realtime;
        private Label lbl_realtime;
        private TextBox textbox_realtimeCurrent;
        private TextBox textbox_datetime;
        private TextBox textbox_realtimevoltage;
        private Label label1;
        private Label label_voltage;
        private ComboBox combox_device;
        private TextBox textbox_mpptvoltage;
        private TextBox textbox_mpptcurrent;
        private TextBox textbox_Cellvoltage;
        private TextBox textbox_cellcurrent;
        private Label label_devicelocation;
        private Label label_mpptvoltage;
        private Label label_mpptcurrent;
        private Label label_cellACvoltage;
        private Label label_cellACcurrent;
        private GroupBox groupboxACDC;
        private GroupBox groupbox_mppt;
        private TextBox textBox_programdata;
        private Button button_stop;
        private GroupBox groupbox_output;
        private ScottPlot.WinForms.FormsPlot currentplot;
        private System.Windows.Forms.Timer timer1;
        private Label label_cellpercentage;
        private TextBox textBOX_CELLPERCENTAGE;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labe_ACVoltage;
        private Label label_ACCurrentDraw;
        private GroupBox groupBox_ACData;
    }
}