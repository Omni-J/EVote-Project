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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamPic
{
    public partial class Blank : Form
    {
        public static string PassingEgnText;
        List<string> candidatesList = new List<string>();
        public string egn;

        public Blank()
        {
            InitializeComponent();
            CandidatesListBox.DataSource = candidatesList;
        }

        private void Blank_Load(object sender, EventArgs e)
        {
            string number1 = string.Empty;
            Regex patternEgn = new Regex(@"(\d){10}");
            using (StreamReader reader = new StreamReader(@"C:\Users\lubo\Desktop\Imaheblack.txt"))
            {
                egn = reader.ReadToEnd().Trim();
                Match match1 = patternEgn.Match(egn);
                number1 = match1.Groups[0].Value;
                egn = number1;
                EGNLabel.Text = "ЕГН: " + number1;
            }
            PassingEgnText = egn;



            WebRequest request = WebRequest.Create("http://fanatichacktues.herokuapp.com/candidates.json");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream);
            string[] responseString = sr.ReadToEnd().Split('}');
            Regex pattern = new Regex(@"""number"":(\d+),""name"":""(.+)"",");
            foreach (var candidate in responseString)
            {
                Match match = pattern.Match(candidate);
                int number = -1;
                string name = "No candidate";
                if (match.Success)
                {
                    number = int.Parse(match.Groups[1].Value);
                    name = match.Groups[2].Value;
                    candidatesList.Add(number + " - " + name);
                    CandidatesListBox.DataSource = null;
                    CandidatesListBox.DataSource = candidatesList;
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string selection = CandidatesListBox.SelectedItem.ToString();
            Regex pattern = new Regex(@"(\d)\s-\s(?:.+)");
            Match match = pattern.Match(selection);
            string number = match.Groups[1].Value.Trim();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://fanatichacktues.herokuapp.com/voters");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"voter\":{\"egn\":\"" + egn + "\",\"vote\":\"" + number + "\"}}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            Successfully succ = new Successfully();
            succ.Show();
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void Blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
