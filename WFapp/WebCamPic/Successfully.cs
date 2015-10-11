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
        private void Successfully_Load(object sender, EventArgs e)
        {
            //string getegn;
            //bool done = true;
            //WebRequest request = WebRequest.Create("http://fanatichacktues.herokuapp.com/voters.json");
            //WebResponse response = request.GetResponse();
            //Stream responseStream = response.GetResponseStream();
            //StreamReader sr = new StreamReader(responseStream);
            //string[] responseString = sr.ReadToEnd().Split('}');
            //Regex pattern = new Regex(@"(\d){10}");
            //foreach (var candidate in responseString)
            //{
            //    Match match = pattern.Match(candidate);
            //    long number = -1;
            //    if (match.Success)
            //    {
            //        number = long.Parse(match.Groups[0].Value);
            //        getegn = Blank.PassingEgnText;
            //        if (getegn == number.ToString())
            //        {
            //            OutputInfoLabel.Text = "Вече сте гласували";
            //            OutputInfoLabel.ForeColor = Color.Red;
            //            done = false;
            //            break;
            //        }
            //    }
            //}
            //if (done == true)
            //{
            //    OutputInfoLabel.Text = "Вие успешно гласувахте";
            //}

          

        }

        private void Successfully_Shown(object sender, EventArgs e)
        {

            string getegn;
            bool done = true;
            WebRequest request = WebRequest.Create("http://fanatichacktues.herokuapp.com/voters.json");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream);
            string[] responseString = sr.ReadToEnd().Split('}');
            Regex pattern = new Regex(@"(\d){10}");
            foreach (var candidate in responseString)
            {
                Match match = pattern.Match(candidate);
                long number = -1;
                if (match.Success)
                {
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



            Thread.Sleep(5000);
            Form1 newpic = new Form1();
            newpic.Show();
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }


    }
}
