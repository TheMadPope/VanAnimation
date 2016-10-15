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
                await Task.Delay(250);
                iCurrent = iCurrent + iRandom;
            }
        }
    }
}
