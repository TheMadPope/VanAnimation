using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RandomTextAndImages
{
    public partial class ImageForm : Form
    {
        public List<string> Images { get; set; }
        public ImageForm()
        {
            InitializeComponent();
            getImages();
        }

        private async void ImageForm_Load(object sender, EventArgs e)
        {
            var r = new Random();
            var imgCount = Images.Count()-1;
            var iCount = 0;
            var rdmImage = string.Empty;
            var lastImage = string.Empty;
            while (true!=false)
            {
                while (lastImage == rdmImage)
                {
                    rdmImage = Images[r.Next(0, imgCount)];
                }
                lastImage = rdmImage;
                pictureBox1.Image = Image.FromFile(rdmImage);
                Size = new Size(pictureBox1.Image.Size.Width, pictureBox1.Image.Size.Height);
                pictureBox1.Size = new Size(pictureBox1.Image.Size.Width, pictureBox1.Image.Size.Height);
                Opacity = 100;
                iCount++;
                await Delay(r.Next(1000,4000));
                //FadeOut(this); Couldn't get this to work.
            }
        }
        public static Task Delay(double milliseconds)
        {
            var tcs = new TaskCompletionSource<bool>();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (obj, args) =>
            {
                tcs.TrySetResult(true);
            };
            timer.Interval = milliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }

        //private void FadeOut(Form o, int interval = 100)
        //{
        //    var t = new Timer();
        //    t.Interval = interval;
        //    t.Start();
        //    t.Tick += new EventHandler(fade_Tick);
        //}

        //private void fade_Tick(object sender, EventArgs e)
        //{
        //    if (Opacity > 0.0)
        //    {

        //        //await Task.Delay(interval);
        //        Opacity -= 0.05;
        //        t.Start();
        //        if (t.Tick)
        //        {

        //        }
        //    }
        //    o.Opacity = 0; //make fully invisible       
        //}

        private void getImages()
        {
            Images = new List<string>();
            string filepath = @"C:\VanCode\Images\";
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles())
            {
                Images.Add(file.FullName.ToString());
            }
        }

        private void ImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
