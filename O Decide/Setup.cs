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
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();

            try //Try retreiving the values from the app settings
            {
                ts_Odds.Value = Properties.Settings.Default.Odds;
                num_Minute.Value = Properties.Settings.Default.Minute;
                num_Hour.Value = Properties.Settings.Default.Hour;
                num_Day.Value = Properties.Settings.Default.Day;
                num_Week.Value = Properties.Settings.Default.Week;
                OddsTextUpdate();
            }
            catch (NullReferenceException) //If they're empty, use defaults
            {
                ts_Odds.Value = 50;
                num_Minute.Value = 1;
                num_Hour.Value = 0;
                num_Day.Value = 0;
                num_Week.Value = 0;
                MessageBox.Show("Default Settings have been applied. Customize your settings below, then click save.","Default Settings", MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //Save Button
        {
            DialogResult r = MessageBox.Show("Please check that your settings are correct because you will NOT be able to edit them until after you've been allowed your next orgasm...", "Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                Properties.Settings.Default.Minute = num_Minute.Value;  //Saves the values to the App Settings, then closes the settings window
                Properties.Settings.Default.Hour = num_Hour.Value;
                Properties.Settings.Default.Day = num_Day.Value;
                Properties.Settings.Default.Week = num_Week.Value;
                Properties.Settings.Default.Odds = ts_Odds.Value;
                MessageBox.Show(null, "Save sucessful. Your changes have been saved.", "Save complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(null,"Save terminated. Your changes were not saved.","Save Aborted",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ts_Odds_MouseDown(object sender, MouseEventArgs e)
        {
            //timer1.Enabled = true; //Not needed
        }

        private void ts_Odds_ValueChanged(object sender, EventArgs e)
        {
            OddsTextUpdate();
        }

        private void OddsTextUpdate()
        {
            tb_Odds.Text = ts_Odds.Value.ToString(); //Updates the textbox value to match the slider
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //OddsTextUpdate(); //Not needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Not Needed
        }
    }
}
