using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquacaredash
{
    public partial class HomeForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "EN4gHeiNTavCsIBABYzXmI2Bci99p26BU40GzHuv",
            BasePath = "https://aquacaredevserver-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        void connectestablish()
        {

            try
            {

                client = new FirebaseClient(config);
                Task.Delay(1000);
                Livecall();
            }
            catch
            {
                MessageBox.Show("Connection did not establish");

            }
        }
        async void Livecall()
        {

            while (true)
            {

                FirebaseResponse response = await client.GetTaskAsync(@"aqc00/onlinestatus");
                try {
                    //string data = "";
                    if (response != null)
                     {
                        string data = JsonConvert.DeserializeObject<string>(response.Body.ToString());
                        if (data == "Online@")
                        { button_aqc00.BackColor = Color.Azure; }
                        else
                        { button_aqc00.BackColor = Color.Black; }
                    }
                      else 
                     {
                        MessageBox.Show("Decode Error!");
                    }

                }
                catch { button_aqc00.BackColor = Color.Black; }
                

            }
        }

        public HomeForm()
        {
            InitializeComponent(); connectestablish();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
class RoundedButton : Button
{
    public int rds = 10;

}