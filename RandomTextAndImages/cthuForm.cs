using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTextAndImages
{
    public partial class cthuForm : Form
    {
        public cthuForm()
        {
            InitializeComponent();
            jitterText();
        }
        public async void jitterText()
        {
            var r = new Random();
            var iRandom = 0;
            string text = System.IO.File.ReadAllText(@"C:\VanCode\chthuvian.txt");
            var iCurrent = 0;
            //var miniCounter = 0;
            while (iCurrent < text.Length)
            {
                iRandom = r.Next(1, 4);
                if ((iCurrent + iRandom) > text.Length)
                {
                    iCurrent = 0;
                }
                var s = text.Substring(iCurrent, iRandom);
                cthuText.AppendText(s);
                await Delay(250);
                iCurrent = iCurrent + iRandom;
            }
        }

        private void cthuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
