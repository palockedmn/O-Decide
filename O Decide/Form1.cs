#region Using
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Configuration;
#endregion

namespace O_Decide
{
    
    public partial class Form1 : Form
    {
        #region Initialization
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Settings_Editable == false)
            {
                tMinute.Enabled = true;
                tMinute_Tick(null,null);
            }
        }
        #endregion

        #region Flashing Support
        // To support flashing.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        //Flash both the window caption and taskbar button.
        //This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags. 
        public const UInt32 FLASHW_ALL = 3;

        // Flash continuously until the window comes to the foreground. 
        public const UInt32 FLASHW_TIMERNOFG = 12;

        [StructLayout(LayoutKind.Sequential)]
        public struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }

        // Do the flashing - this does not involve a raincoat.
        public static bool FlashWindowEx(Form form)
        {
            IntPtr hWnd = form.Handle;
            FLASHWINFO fInfo = new FLASHWINFO();

            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;
            fInfo.dwFlags = FLASHW_ALL | FLASHW_TIMERNOFG;
            fInfo.uCount = UInt32.MaxValue;
            fInfo.dwTimeout = 0;

            return FlashWindowEx(ref fInfo);
        }
        #endregion

        #region Decide Button
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                tMinute.Enabled = true; //Enable the 10 second, problematically named timer

                Double minute = Convert.ToDouble(Properties.Settings.Default.Minute);
                Double hour = Convert.ToDouble(Properties.Settings.Default.Hour);
                Double day = Convert.ToDouble(Properties.Settings.Default.Day);

                if (Properties.Settings.Default.canRetry == true | Properties.Settings.Default.lastCheck == null)
                {
                    Random r = new Random();
                    int rInt = r.Next(0, 100);  //New random number between 0 and 100
                    Properties.Settings.Default.nextCheck = DateTime.UtcNow.AddMinutes(minute).AddHours(hour).AddDays(day); //Save when the user can check again

                    if (rInt <= Properties.Settings.Default.Odds)  //If the random number is lower than or equal to the odds, then grant permission. Congrats!
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Text = "You have my permission to cum!";
                        Properties.Settings.Default.lastCheck = DateTime.UtcNow;
                        Properties.Settings.Default.canRetry = true;
                        Properties.Settings.Default.Settings_Editable = true;

                    }
                    else //If the random number is larger than the odds, then sorry, you'll need to try again later
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox1.Text = "You do not have permission to cum. Check again later.";
                        Properties.Settings.Default.lastCheck = DateTime.UtcNow;
                        Properties.Settings.Default.canRetry = false;
                        Properties.Settings.Default.Settings_Editable = false;

                    }
                }
                else //If you do not have permission, and you try to click decide again, show this.
                {
                    textBox1.ForeColor = Color.Red;
                    textBox1.Text = "You need to wait until you're allowed to ask again.";
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to reset this session? You will lose all progress...", "Reset Session", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Properties.Settings.Default.canRetry = true;
                    Properties.Settings.Default.Settings_Editable = true;
                    Properties.Settings.Default.Save();
                    textBox1.Text = "Open \"Settings\" to tweak your experience, then click \"Decide\" to see if you're allowed an orgasm...";
                    textBox1.ForeColor = Color.Black;
                    tMinute.Enabled = false;
                }
            }
        }
        #endregion

        #region Timer
        private void tMinute_Tick(object sender, EventArgs e)
        {
            //Changed timer to tick every 10 seconds instead of every minute. Seemed to update super slowly...
            
            Double minute = Convert.ToDouble(Properties.Settings.Default.Minute);
            Double hour = Convert.ToDouble(Properties.Settings.Default.Hour);
            Double day = Convert.ToDouble(Properties.Settings.Default.Day);

            DateTime interval = Properties.Settings.Default.lastCheck.AddMinutes(minute).AddHours(hour).AddDays(day); //Not sure why I did this twice? See: nextCheck near line 31
            DateTime now = DateTime.UtcNow;

            if (now > interval)
            {
                Properties.Settings.Default.canRetry = true;
                textBox1.ForeColor = Color.Blue;
                textBox1.Text = "Ready to try again.";
                FlashWindowEx(this);
            }
            else
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "It's not time yet...";
            }
        }
        #endregion

        #region Setup
        private void btn_Setup_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Settings_Editable == true) //Check to make sure that the user isn't being denied before opening the settings...
            {
                Form s = new Setup();
                            s.Show();
            }
            else //Show this if the user is currently being denied
            {
                textBox1.Text = "You cannot change settings until AFTER you've been granted an orgasm.";
            }
        }
        #endregion

        #region OnClose
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
