using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using ScottPlot;
using ScottPlot.Plottables;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace aquacaredash
{

    public partial class form_Realtime : Form
    {

        int k = 0; string one = "";
        String two = "";
        public void logincredentials()
        {
            //"C:\\Users\\Nishama\\Downloads\\Research\\WindowsApp\\aquacaredash\\logData.txt"
            String line;
            StreamReader sr = new StreamReader("C:\\Users\\Nishama\\Downloads\\Research\\WindowsApp\\aquacaredash\\logData.txt");

            line = sr.ReadLine();
            int counter = 0;

            while (line != null)
            {
                if (counter == 0)
                {
                    one = line;
                }
                else
                {
                    two = line;
                }
                ///updatemaintextbox(line);
                line = sr.ReadLine();
            }
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "EN4gHeiNTavCsIBABYzXmI2Bci99p26BU40GzHuv",
                BasePath = "https://aquacaredevserver-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };

            sr.Close();
        }

        IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "EN4gHeiNTavCsIBABYzXmI2Bci99p26BU40GzHuv",
            BasePath = "https://aquacaredevserver-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public form_Realtime()
        {
            InitializeComponent();

            initializecombobox(); logincredentials(); getinputs();
        }

        /*void checkinternet()
        {
            try
            { client = new FireSharp.FirebaseClient(config); }
            catch
            { updatemaintextbox("Check Internet Boy!!"); }
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {

            updatemaintextbox("Hello and Welcome User!");
            updatemaintextbox("Program Started"); InitializeChart(); logincredentials();
            timer1.Interval = 1000;
            timer1.Start();

        }
        public void updatemaintextbox(string data)
        {

            if (textBox_programdata.InvokeRequired)
            {
                textBox_programdata.Invoke(new Action<string>(updatemaintextbox), new object[] { data });
            }
            else
            {
                textBox_programdata.AppendText(readddateandtime() + " - " + data + Environment.NewLine);
            }
        }
        void connectestablish()
        {

            try
            {
                updatemaintextbox("Authentication Process Started!");
                client = new FirebaseClient(config);
                Livecall();
            }
            catch
            {
                MessageBox.Show("Connection did not establish");
                updatemaintextbox("Authentication Process Failed!");
            }
        }
        int connectionstate = 0;
        private async void btn_realtime_Click(object sender, EventArgs e)
        {
            connectionstate++;
            cancellationTokenSource = new CancellationTokenSource();
            if (connectionstate == 1)
            {
                await Task.Run(() =>
                {

                    connectestablish();
                }
            );
            }
            else
            {

                updatemaintextbox("Stopping Data Retrieving");
                connectionstate = 0; cancellationTokenSource.Cancel(); clearboxes();


            }



        }

        private void initializecombobox()
        {
            string[] bauds = { "AquaCare-Kalalgoda", "AquaCare-Ingiriya" };
            combox_device.Items.AddRange(bauds); combox_device.SelectedIndex = 0;
        }
        public int getinputs()
        {
            int j;
            if (combox_device.Text == "AquaCare-Kalalgoda")
            {
                j = 0;
            }
            else if (combox_device.Text == "AquaCare-Ingiriya")
            {
                j = 1;
            }
            else
            {

                j = 3;
            }
            return j;


        }



        public string readddateandtime()
        {

            string formattedDateTime = "";
            DateTime currentDateTime = DateTime.Now;
            formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            return formattedDateTime;


        }
        public String datetimesettering(String jkll)
        {
            string[] separatingStrings = { "20", "-0", ":0", " ", "-", ":" };
            //2024-03-16 10:23:01
            ///124316101119" one eka

            String newdateandtime = "";
            string[] words = jkll.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);


            try
            { newdateandtime = "1" + words[0] + words[1] + words[2] + words[3] + words[4] + words[5]; }
            catch
            { newdateandtime = "1" + words[0] + words[1] + words[2] + words[3] + words[4]; }


            return newdateandtime;
        }
        private CancellationTokenSource cancellationTokenSource;
        async void Livecall()
        {
            updatemaintextbox("Retrieving Data!");
            while (true)
            {

                FirebaseResponse response = await client.GetTaskAsync(@"aqc00/recent");
                string data = JsonConvert.DeserializeObject<string>(response.Body.ToString());
                if (cancellationTokenSource.IsCancellationRequested)
                {
                    updatemaintextbox("Data retrieve Stopped"); break;
                }
                UpdateRTB(data);




            }
        }


        private void button_stop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();

            updatemaintextbox("Stopping Data Retrieving");
            cancellationTokenSource.Cancel();
            Task.Delay(1000);
            clearboxes();
            updatemaintextbox("Data retrieve Stopped");
        }

        void clearboxes()
        {
            textbox_Cellvoltage.Clear();
            textbox_mpptvoltage.Clear();
            textbox_mpptcurrent.Clear();
            textbox_mpptvoltage.Clear();
            textbox_mpptvoltage.Clear();
            textbox_realtimeCurrent.Clear();
            textbox_realtimevoltage.Clear();
            textbox_cellcurrent.Clear();
        }
        void UpdateRTB(string record)
        {
            try
            { Invoke(new Action(() => UpdateTextBox(record))); }
            catch
            {
                Console.WriteLine("Eroor thrown");
            }

        }
        private void UpdateTextBox(String data)
        {
            try
            {//bv19bc12mpv14mpc4acv189acc15oc63ov3err0000000

                string[] separatingStrings = { "bv", "bc", "mpv", "mpc", "acv", "acc", "oc", "ov", "err" };
                textbox_datetime.Text = readddateandtime();
                string[] words = data.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                if (words.Length >= 8)
                {
                    textbox_Cellvoltage.Text = words[0] + " V";
                    textbox_cellcurrent.Text = words[1] + " A";
                    textbox_mpptvoltage.Text = words[2] + " V";
                    textbox_mpptcurrent.Text = words[3] + " A";
                    textbox_mpptvoltage.Text = words[4] + " V";
                    textbox_mpptvoltage.Text = words[5] + " V";
                    textbox_realtimeCurrent.Text = words[6] + " A";
                    textbox_realtimevoltage.Text = words[7] + " V";
                    UpdateChart(words[6]);
                }
                else
                {
                    MessageBox.Show("Hmmmmm!");
                }

            }
            catch
            {
                MessageBox.Show("Error Data Decoding.");
            }


        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void InitializeChart()
        {
            currentplot.Plot.XLabel("Time[s]");
            currentplot.Plot.YLabel("Current[°A]");
            currentplot.Plot.Title("Current Output");
            for (int i = 0; i < 60; i++)
            {
                dataX[i] = i;
            }

            currentplot.Refresh();
        }


        int j = 0;
        double[] dataX = new double[60];
        double[] dataY = new double[60];



        int num = 0;
        int secondnum = 0;
        private void UpdateChart(string jkop)
        {

            double jui = int.Parse(jkop);
            if (num < 60)
            {

                dataY[num] = jui; num++;
            }
            else
            {
                double[] newdataY = new double[60]; newdataY[59] = jui;
                for (int j = 0; j < 59; j++)
                {
                    newdataY[j] = dataY[j + 1];
                }
                dataY = newdataY;



            }



            //var myscatter = currentplot.Plot.Add.Scatter(dataX[j], jui);
            var myscatter = currentplot.Plot.Add.Scatter(dataX, dataY);
            myscatter.Color = Colors.DarkRed;
            myscatter.LineWidth = 2;
            myscatter.MarkerSize = 5;


            currentplot.Plot.Axes.AutoScale();

            currentplot.Refresh();
            myscatter.Color = Colors.White;

        }
    }
}

