namespace aquacaredash
{
    partial class HomeForm
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
            button_aqc00 = new Button();
            button_aqc01 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 57);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // button_aqc00
            // 
            button_aqc00.BackColor = SystemColors.ActiveCaptionText;
            button_aqc00.FlatAppearance.BorderColor = Color.Red;
            button_aqc00.FlatAppearance.BorderSize = 5;
            button_aqc00.FlatStyle = FlatStyle.Popup;
            button_aqc00.ForeColor = SystemColors.ActiveCaption;
            button_aqc00.Location = new Point(58, 92);
            button_aqc00.Name = "button_aqc00";
            button_aqc00.Size = new Size(119, 49);
            button_aqc00.TabIndex = 1;
            button_aqc00.Text = "Dev Machine\r\nKalalgoda";
            button_aqc00.UseVisualStyleBackColor = false;
            button_aqc00.Click += button1_Click;
            // 
            // button_aqc01
            // 
            button_aqc01.BackColor = SystemColors.ActiveCaptionText;
            button_aqc01.FlatAppearance.BorderColor = Color.Red;
            button_aqc01.FlatAppearance.BorderSize = 5;
            button_aqc01.FlatStyle = FlatStyle.Popup;
            button_aqc01.ForeColor = SystemColors.ActiveCaption;
            button_aqc01.Location = new Point(292, 92);
            button_aqc01.Name = "button_aqc01";
            button_aqc01.Size = new Size(119, 49);
            button_aqc01.TabIndex = 2;
            button_aqc01.Text = "Dev Machine\r\nIngiriya";
            button_aqc01.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_aqc01);
            Controls.Add(button_aqc00);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "Home";
            FormClosed += HomeForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_aqc00;
        private Button button_aqc01;
    }
}