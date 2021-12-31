using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Decide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tMinute.Enabled = true; //Enable the 10 second, problematically named timer
        }

        private void button2_Click(object sender, EventArgs e) //Decide Button
        {
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
            }
        }

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
    }
}
