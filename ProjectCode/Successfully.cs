using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamPic
{

    public partial class Successfully : Form
    {
        public Successfully()
        {
            InitializeComponent();
        }
        static Thread t;
        static string printlabel;
        private void Successfully_Load(object sender, EventArgs e)
        {
            string getegn;
            bool done = true;
            WebRequest request = WebRequest.Create("http://fanatichacktues.herokuapp.com/voters.json");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream);
            string[] responseString = sr.ReadToEnd().Split('}');
            Regex pattern = new Regex(@"(\d){10}");
            int counter = 1;
            foreach (var candidate in responseString)
            {
                counter++;
                Match match = pattern.Match(candidate);
                long number = -1;
                if (match.Success)
                {
                    if (counter == responseString.Length)
                    {
                        break;
                    }
                    number = long.Parse(match.Groups[0].Value);
                    getegn = Blank.PassingEgnText;
                    if (getegn == number.ToString())
                    {
                        OutputInfoLabel.Text = "Вече сте гласували";
                        OutputInfoLabel.ForeColor = Color.Red;
                        done = false;
                        break;
                    }
                }
            }
            if (done == true)
            {
                OutputInfoLabel.Text = "Вие успешно гласувахте";
                OutputInfoLabel.ForeColor = Color.Green;
            }
        }

        private void Successfully_Shown(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 newpic = new Form1();
            newpic.Show();
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            timer1.Enabled = false;
        }
    }
}
