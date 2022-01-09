
namespace O_Decide
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ts_Odds = new System.Windows.Forms.TrackBar();
            this.tb_Odds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.num_Minute = new System.Windows.Forms.NumericUpDown();
            this.num_Hour = new System.Windows.Forms.NumericUpDown();
            this.num_Day = new System.Windows.Forms.NumericUpDown();
            this.num_Week = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ts_Odds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Week)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Days";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weeks";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(962, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Set how long you\'ll need to wait before being allowed to try again...";
            // 
            // ts_Odds
            // 
            this.ts_Odds.Location = new System.Drawing.Point(13, 135);
            this.ts_Odds.Maximum = 100;
            this.ts_Odds.Minimum = 1;
            this.ts_Odds.Name = "ts_Odds";
            this.ts_Odds.Size = new System.Drawing.Size(1006, 69);
            this.ts_Odds.TabIndex = 6;
            this.ts_Odds.TickFrequency = 10;
            this.ts_Odds.Value = 50;
            this.ts_Odds.ValueChanged += new System.EventHandler(this.ts_Odds_ValueChanged);
            this.ts_Odds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ts_Odds_MouseDown);
            // 
            // tb_Odds
            // 
            this.tb_Odds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Odds.Location = new System.Drawing.Point(149, 85);
            this.tb_Odds.Name = "tb_Odds";
            this.tb_Odds.ReadOnly = true;
            this.tb_Odds.Size = new System.Drawing.Size(154, 44);
            this.tb_Odds.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1005, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "Set the odds of being allowed an orgasm each time you click decide...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(856, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 71);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // num_Minute
            // 
            this.num_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Minute.Location = new System.Drawing.Point(144, 98);
            this.num_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_Minute.Name = "num_Minute";
            this.num_Minute.Size = new System.Drawing.Size(120, 44);
            this.num_Minute.TabIndex = 16;
            // 
            // num_Hour
            // 
            this.num_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Hour.Location = new System.Drawing.Point(390, 98);
            this.num_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_Hour.Name = "num_Hour";
            this.num_Hour.Size = new System.Drawing.Size(120, 44);
            this.num_Hour.TabIndex = 17;
            // 
            // num_Day
            // 
            this.num_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Day.Location = new System.Drawing.Point(630, 98);
            this.num_Day.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_Day.Name = "num_Day";
            this.num_Day.Size = new System.Drawing.Size(120, 44);
            this.num_Day.TabIndex = 18;
            // 
            // num_Week
            // 
            this.num_Week.Enabled = false;
            this.num_Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Week.Location = new System.Drawing.Point(897, 98);
            this.num_Week.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.num_Week.Name = "num_Week";
            this.num_Week.Size = new System.Drawing.Size(120, 44);
            this.num_Week.TabIndex = 19;
            this.num_Week.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ts_Odds);
            this.groupBox1.Controls.Add(this.tb_Odds);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 215);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odds:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.num_Week);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.num_Day);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.num_Hour);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.num_Minute);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 161);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delay:";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.ts_Odds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Week)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar ts_Odds;
        private System.Windows.Forms.TextBox tb_Odds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown num_Minute;
        private System.Windows.Forms.NumericUpDown num_Hour;
        private System.Windows.Forms.NumericUpDown num_Day;
        private System.Windows.Forms.NumericUpDown num_Week;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}