namespace aquacaredash
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            button_TimeMachine = new Button();
            button_Errors = new Button();
            button_Realtime = new Button();
            button_Home = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label_header = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(button_TimeMachine);
            panel1.Controls.Add(button_Errors);
            panel1.Controls.Add(button_Realtime);
            panel1.Controls.Add(button_Home);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 681);
            panel1.TabIndex = 0;
            // 
            // button_TimeMachine
            // 
            button_TimeMachine.Dock = DockStyle.Top;
            button_TimeMachine.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            button_TimeMachine.FlatAppearance.BorderSize = 0;
            button_TimeMachine.FlatStyle = FlatStyle.Flat;
            button_TimeMachine.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_TimeMachine.ForeColor = SystemColors.ButtonFace;
            button_TimeMachine.Image = (Image)resources.GetObject("button_TimeMachine.Image");
            button_TimeMachine.ImageAlign = ContentAlignment.MiddleLeft;
            button_TimeMachine.Location = new Point(0, 396);
            button_TimeMachine.Name = "button_TimeMachine";
            button_TimeMachine.Padding = new Padding(10, 0, 0, 0);
            button_TimeMachine.Size = new Size(250, 102);
            button_TimeMachine.TabIndex = 4;
            button_TimeMachine.Text = "Time Machine";
            button_TimeMachine.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_TimeMachine.UseVisualStyleBackColor = true;
            button_TimeMachine.Click += button_TimeMachine_Click;
            // 
            // button_Errors
            // 
            button_Errors.Dock = DockStyle.Top;
            button_Errors.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            button_Errors.FlatAppearance.BorderSize = 0;
            button_Errors.FlatStyle = FlatStyle.Flat;
            button_Errors.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_Errors.ForeColor = SystemColors.ButtonFace;
            button_Errors.Image = (Image)resources.GetObject("button_Errors.Image");
            button_Errors.ImageAlign = ContentAlignment.MiddleLeft;
            button_Errors.Location = new Point(0, 294);
            button_Errors.Name = "button_Errors";
            button_Errors.Padding = new Padding(10, 0, 0, 0);
            button_Errors.Size = new Size(250, 102);
            button_Errors.TabIndex = 3;
            button_Errors.Text = "Errors";
            button_Errors.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Errors.UseVisualStyleBackColor = true;
            button_Errors.Click += button_Errors_Click;
            // 
            // button_Realtime
            // 
            button_Realtime.Dock = DockStyle.Top;
            button_Realtime.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            button_Realtime.FlatAppearance.BorderSize = 0;
            button_Realtime.FlatStyle = FlatStyle.Flat;
            button_Realtime.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_Realtime.ForeColor = SystemColors.ButtonFace;
            button_Realtime.Image = (Image)resources.GetObject("button_Realtime.Image");
            button_Realtime.ImageAlign = ContentAlignment.MiddleLeft;
            button_Realtime.Location = new Point(0, 192);
            button_Realtime.Name = "button_Realtime";
            button_Realtime.Padding = new Padding(10, 0, 0, 0);
            button_Realtime.Size = new Size(250, 102);
            button_Realtime.TabIndex = 2;
            button_Realtime.Text = "RealTime";
            button_Realtime.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Realtime.UseVisualStyleBackColor = true;
            button_Realtime.Click += button_Realtime_Click;
            // 
            // button_Home
            // 
            button_Home.Dock = DockStyle.Top;
            button_Home.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            button_Home.FlatAppearance.BorderSize = 0;
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button_Home.ForeColor = SystemColors.ButtonFace;
            button_Home.Image = (Image)resources.GetObject("button_Home.Image");
            button_Home.ImageAlign = ContentAlignment.MiddleLeft;
            button_Home.Location = new Point(0, 90);
            button_Home.Name = "button_Home";
            button_Home.Padding = new Padding(10, 0, 0, 0);
            button_Home.Size = new Size(250, 102);
            button_Home.TabIndex = 1;
            button_Home.Text = "Home";
            button_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Home.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 60);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 90);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 64);
            label1.TabIndex = 0;
            label1.Text = "AquaCare Chlorinator \r\nDashBoard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(label_header);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(250, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 56);
            panel3.TabIndex = 1;
            // 
            // label_header
            // 
            label_header.AutoSize = true;
            label_header.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_header.Location = new Point(255, 9);
            label_header.Name = "label_header";
            label_header.Size = new Size(169, 37);
            label_header.TabIndex = 0;
            label_header.Text = "Howdy User!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_TimeMachine;
        private Button button_Errors;
        private Button button_Realtime;
        private Button button_Home;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label_header;
    }
}