using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MODI;
using System.IO;
using AForge.Imaging.Filters;
using System.Text.RegularExpressions;

namespace WebCamPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BadImageLabel1.Visible = false;
            BadImageLabel2.Visible = false;
            BadImagePlsLabel.Visible = false;
            BadImageExampleLabel.Visible = false;
            ImageTrueExampleBox.Visible = false;
        }
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 1;
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
        }

        

        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            NewMakePicBox.Image = bit;
        }

        private void TakePicBtn_Click(object sender, EventArgs e)
        {
            string number1 = string.Empty;

                cam.Stop();

                NewMakePicBox.Image.Save(@"C:\Users\lubo\Desktop\Image.jpg");

                using (StreamWriter writer = new StreamWriter("C:/Users/lubo/Desktop/Imaheblack.txt"))
                {
                    writer.WriteLine(ExtractTextFromImage("C:/Users/lubo/Desktop/Image.jpg"));
                }

                Regex patternEgn = new Regex(@"(\d){10}");
                string egn;
                using (StreamReader reader = new StreamReader(@"C:\Users\lubo\Desktop\Imaheblack.txt"))
                {
                    egn = reader.ReadToEnd().Trim();
                    Match match1 = patternEgn.Match(egn);
                    number1 = match1.Groups[0].Value;
                }
            if (number1.Length < 10)
            {
                BadImageLabel1.Visible = true;
                BadImageLabel2.Visible = true;
                BadImagePlsLabel.Visible = true;
                BadImageExampleLabel.Visible = true;
                ImageTrueExampleBox.Visible = true;
                cam.Start();
            }
            else
            {
                Blank blank = new Blank();
                blank.Show();
                this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
            
        }
            
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                cam.Stop();
        }


        private string ExtractTextFromImage(string filePath)
        {
            Document modiDocument = new Document();
            modiDocument.Create(filePath);
            modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
            MODI.Image modiImage = (modiDocument.Images[0] as MODI.Image);
            string extractedText = modiImage.Layout.Text;
            modiDocument.Close();
            return extractedText;
        }
    }
}
