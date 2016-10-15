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
//using System.Timers;

namespace RandomTextAndImages
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            var i = new ImageForm();
            i.Show();
            var c = new cthuForm();
            c.Show();
            c.jitterText();
        }

        public async void jitterText()
        {
            var r = new Random();
            var iRandom = 0;
            string text = System.IO.File.ReadAllText(@"C:\VanCode\textfile.txt");
            var iCurrent = 0;
            var miniCounter = 0;
            var text3Counter = 0;
            var text2Counter = 0;
            string sup;
            while (true)
            {
                iRandom = r.Next(1, 5);
                if((iCurrent + iRandom) > text.Length)
                {
                    iCurrent = 0;
                }
                var s = text.Substring(iCurrent, iRandom);
                textBox1.AppendText(s);
                if (miniCounter >= 60)
                {
                    textBox2.Text = null;
                    miniCounter = 0;
                }
                sup = s.ToUpper();
                textBox3.Text = string.Format("{0}:{1} -- {2}", sup, sup, sup);
                textBox2.AppendText(s);
                iCurrent = iCurrent + iRandom;
                miniCounter++;
                text2Counter++;
                text3Counter++;

                if (text3Counter>= r.Next(0, 200))
                {
                    textBox3.Location = new Point(r.Next(0,600), r.Next(0,1000));
                    text3Counter = 0;
                }

                if (text2Counter >= r.Next(400, 1500))
                {
                    textBox2.Location = new Point(r.Next(0, 600), r.Next(0, 800));
                    text2Counter = 0;
                }

                await Task.Delay(1);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            jitterText();
        }
        

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
