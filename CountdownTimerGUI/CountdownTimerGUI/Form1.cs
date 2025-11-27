using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CountdownTimerGUI
{
    public partial class Form1 : Form
    {
        private TimeSpan remainingTime;
        private PrivateFontCollection customFonts = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "CountdownTimerGUI.Resources.StargateAncient.otf";

            using (Stream fontStream = assembly.GetManifestResourceStream(resourceName))
            {
                if (fontStream != null)
                {
                    byte[] fontData = new byte[fontStream.Length];
                    fontStream.Read(fontData, 0, (int)fontStream.Length);

                    IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                    Marshal.Copy(fontData, 0, data, (int)fontStream.Length);

                    customFonts.AddMemoryFont(data, (int)fontStream.Length);
                    Marshal.FreeCoTaskMem(data);
                }
            }

            labelCountdown.Font = new Font(customFonts.Families[0], 48, FontStyle.Regular);
            labelCountdown.TextAlign = ContentAlignment.MiddleCenter;
            labelCountdown.AutoSize = false;
            labelCountdown.Text = FormatTimeWithSpacing(TimeSpan.Zero);

            textBoxHours.Text = "0";
            textBoxMinutes.Text = "1";
            textBoxSeconds.Text = "30";

            buttonStart.Click += buttonStart_Click;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxHours.Text, out int hours);
            int.TryParse(textBoxMinutes.Text, out int minutes);
            int.TryParse(textBoxSeconds.Text, out int seconds);

            remainingTime = new TimeSpan(hours, minutes, seconds);

            if (remainingTime.TotalSeconds <= 0)
            {
                MessageBox.Show("Enter a valid time.");
                return;
            }

            labelCountdown.Text = FormatTimeWithSpacing(remainingTime);
            timer1.Start();
            buttonStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                labelCountdown.Text = FormatTimeWithSpacing(remainingTime);
            }
            else
            {
                timer1.Stop();
                buttonStart.Enabled = true;
                MessageBox.Show("Time’s up!");
            }
        }

        private string FormatTimeWithSpacing(TimeSpan time)
        {
            string h = time.Hours.ToString("00");
            string m = time.Minutes.ToString("00");
            string s = time.Seconds.ToString("00");

            return $"{h[0]} {h[1]} : {m[0]} {m[1]} : {s[0]} {s[1]}";
        }
    }
}
