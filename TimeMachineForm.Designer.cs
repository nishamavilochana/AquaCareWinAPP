namespace aquacaredash
{
    partial class TimeMachineForm
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
            monthCalendar1 = new MonthCalendar();
            progressBar_timemachine = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(441, 208);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Time machine";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(95, 45);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.TabIndex = 1;
            // 
            // progressBar_timemachine
            // 
            progressBar_timemachine.Location = new Point(457, 43);
            progressBar_timemachine.Name = "progressBar_timemachine";
            progressBar_timemachine.Size = new Size(100, 23);
            progressBar_timemachine.TabIndex = 2;
            // 
            // TimeMachineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar_timemachine);
            Controls.Add(monthCalendar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimeMachineForm";
            Text = "TimeMachineForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendar1;
        private ProgressBar progressBar_timemachine;
    }
}