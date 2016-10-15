using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var imgCount = Images.Count()-1;
            var iCount = 0;
            //pictureBox1.Image = Image.FromFile(@"C:\VanCode\Images\1.jpg");
            while (true!=false)
            {
                if (iCount >= imgCount) { iCount = 0; }
                pictureBox1.Image = Image.FromFile(Images[iCount]);
                iCount++;
                await Task.Delay(200);
            }
        }

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
    }
}
