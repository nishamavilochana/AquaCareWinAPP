using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquacaredash
{
    public partial class MainForm : Form
    {
        form_Realtime realtime;
        ErrorForm error;
        TimeMachineForm timemachine;
        HomeForm home;

        public MainForm()
        {
            InitializeComponent(); this.IsMdiContainer = true;
        }


        private void button_Realtime_Click(object sender, EventArgs e)
        {
            button_Realtime.BackColor = Color.Red;
            if (realtime == null)
            {
                realtime = new form_Realtime();
                realtime.FormClosed += form_Realtime_FormClosed;

                realtime.MdiParent = this;
                realtime.Dock = DockStyle.Fill; label_header.Text = "RealTime Data Capturing!";
                realtime.Show();

            }
            else
            {
                realtime.Activate();
                ;
            }
        }
        private void form_Realtime_FormClosed(object sender, EventArgs e)
        {
            realtime = null;

        }

        private void button_Errors_Click(object sender, EventArgs e)
        {
            button_Errors.BackColor = Color.Red;
            if (error == null)
            {
                error = new ErrorForm();
                error.FormClosed += ErrorForm_FormClosed;
                error.MdiParent = this;
                error.Dock = DockStyle.Fill; label_header.Text = "RealTime Data Capturing!";
                error.Show();

            }
            else
            {
                realtime.Activate();
                ;
            }
        }

        private void ErrorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            error = null;
        }
        private void button_TimeMachine_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            home = new HomeForm();
            home.MdiParent = this;
            home.Dock = DockStyle.Fill; label_header.Text = "HOME!!";
            home.Show();

        }
    }
}
