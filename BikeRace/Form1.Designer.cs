
namespace BikeRace{
    partial class Form1 {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BikeRacetrack = new System.Windows.Forms.PictureBox();
            this.Bike1 = new System.Windows.Forms.PictureBox();
            this.Bike2 = new System.Windows.Forms.PictureBox();
            this.Bike3 = new System.Windows.Forms.PictureBox();
            this.Bike4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TomBet = new System.Windows.Forms.Label();
            this.BarryBet = new System.Windows.Forms.Label();
            this.KimBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BikeRace = new System.Windows.Forms.Button();
            this.BikesNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BikeRacerAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.TomRButton = new System.Windows.Forms.RadioButton();
            this.BarryRButton = new System.Windows.Forms.RadioButton();
            this.KimButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BikeRacetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeRacerAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // BikeRacetrack
            // 
            this.BikeRacetrack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BikeRacetrack.Image = global::BikeRace.Properties.Resources.racetrack_Image;
            this.BikeRacetrack.Location = new System.Drawing.Point(-1, -64);
            this.BikeRacetrack.Name = "BikeRacetrack";
            this.BikeRacetrack.Size = new System.Drawing.Size(802, 428);
            this.BikeRacetrack.TabIndex = 0;
            this.BikeRacetrack.TabStop = false;
            this.BikeRacetrack.Click += new System.EventHandler(this.BikeRacetrack_Click);
            // 
            // Bike1
            // 
            this.Bike1.BackColor = System.Drawing.SystemColors.Control;
            this.Bike1.Image = ((System.Drawing.Image)(resources.GetObject("Bike1.Image")));
            this.Bike1.Location = new System.Drawing.Point(40, 3);
            this.Bike1.Name = "Bike1";
            this.Bike1.Size = new System.Drawing.Size(76, 59);
            this.Bike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Bike1.TabIndex = 1;
            this.Bike1.TabStop = false;
            // 
            // Bike2
            // 
            this.Bike2.Image = ((System.Drawing.Image)(resources.GetObject("Bike2.Image")));
            this.Bike2.Location = new System.Drawing.Point(40, 101);
            this.Bike2.Name = "Bike2";
            this.Bike2.Size = new System.Drawing.Size(76, 62);
            this.Bike2.TabIndex = 2;
            this.Bike2.TabStop = false;
            // 
            // Bike3
            // 
            this.Bike3.Image = ((System.Drawing.Image)(resources.GetObject("Bike3.Image")));
            this.Bike3.Location = new System.Drawing.Point(40, 210);
            this.Bike3.Name = "Bike3";
            this.Bike3.Size = new System.Drawing.Size(76, 58);
            this.Bike3.TabIndex = 3;
            this.Bike3.TabStop = false;
            // 
            // Bike4
            // 
            this.Bike4.Image = ((System.Drawing.Image)(resources.GetObject("Bike4.Image")));
            this.Bike4.Location = new System.Drawing.Point(40, 297);
            this.Bike4.Name = "Bike4";
            this.Bike4.Size = new System.Drawing.Size(76, 57);
            this.Bike4.TabIndex = 4;
            this.Bike4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.TomBet);
            this.groupBox1.Controls.Add(this.BarryBet);
            this.groupBox1.Controls.Add(this.KimBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BikeRace);
            this.groupBox1.Controls.Add(this.BikesNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BikeRacerAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.TomRButton);
            this.groupBox1.Controls.Add(this.BarryRButton);
            this.groupBox1.Controls.Add(this.KimButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(-1, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bike race";
            // 
            // TomBet
            // 
            this.TomBet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TomBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TomBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TomBet.Location = new System.Drawing.Point(13, 65);
            this.TomBet.Name = "TomBet";
            this.TomBet.Size = new System.Drawing.Size(218, 17);
            this.TomBet.TabIndex = 13;
            this.TomBet.Text = "label6";
            // 
            // BarryBet
            // 
            this.BarryBet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BarryBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarryBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BarryBet.Location = new System.Drawing.Point(13, 92);
            this.BarryBet.Name = "BarryBet";
            this.BarryBet.Size = new System.Drawing.Size(218, 17);
            this.BarryBet.TabIndex = 12;
            this.BarryBet.Text = "label5";
            // 
            // KimBet
            // 
            this.KimBet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.KimBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KimBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KimBet.Location = new System.Drawing.Point(13, 121);
            this.KimBet.Name = "KimBet";
            this.KimBet.Size = new System.Drawing.Size(217, 17);
            this.KimBet.TabIndex = 11;
            this.KimBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // BikeRace
            // 
            this.BikeRace.BackColor = System.Drawing.Color.Gainsboro;
            this.BikeRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BikeRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BikeRace.ForeColor = System.Drawing.Color.Black;
            this.BikeRace.Location = new System.Drawing.Point(343, 108);
            this.BikeRace.Name = "BikeRace";
            this.BikeRace.Size = new System.Drawing.Size(135, 30);
            this.BikeRace.TabIndex = 9;
            this.BikeRace.Text = "START BikeRace";
            this.BikeRace.UseVisualStyleBackColor = false;
            this.BikeRace.Click += new System.EventHandler(this.BikeRace_Click);
            // 
            // BikesNumber
            // 
            this.BikesNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BikesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BikesNumber.Location = new System.Drawing.Point(460, 59);
            this.BikesNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BikesNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BikesNumber.Name = "BikesNumber";
            this.BikesNumber.Size = new System.Drawing.Size(64, 23);
            this.BikesNumber.TabIndex = 8;
            this.BikesNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BikesNumber.ValueChanged += new System.EventHandler(this.BikesNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(457, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bikes number";
            // 
            // BikeRacerAmount
            // 
            this.BikeRacerAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BikeRacerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BikeRacerAmount.Location = new System.Drawing.Point(276, 59);
            this.BikeRacerAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BikeRacerAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BikeRacerAmount.Name = "BikeRacerAmount";
            this.BikeRacerAmount.Size = new System.Drawing.Size(63, 23);
            this.BikeRacerAmount.TabIndex = 6;
            this.BikeRacerAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BikeRacerAmount.ValueChanged += new System.EventHandler(this.BikeRacerAmount_ValueChanged);
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.Gainsboro;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Bets.Location = new System.Drawing.Point(13, 28);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(126, 30);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // TomRButton
            // 
            this.TomRButton.AutoSize = true;
            this.TomRButton.Checked = true;
            this.TomRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TomRButton.Location = new System.Drawing.Point(626, 61);
            this.TomRButton.Name = "TomRButton";
            this.TomRButton.Size = new System.Drawing.Size(54, 21);
            this.TomRButton.TabIndex = 3;
            this.TomRButton.TabStop = true;
            this.TomRButton.Text = "Tom";
            this.TomRButton.UseVisualStyleBackColor = true;
            this.TomRButton.CheckedChanged += new System.EventHandler(this.TomButton_CheckedChanged);
            // 
            // BarryRButton
            // 
            this.BarryRButton.AutoSize = true;
            this.BarryRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BarryRButton.Location = new System.Drawing.Point(626, 88);
            this.BarryRButton.Name = "BarryRButton";
            this.BarryRButton.Size = new System.Drawing.Size(60, 21);
            this.BarryRButton.TabIndex = 2;
            this.BarryRButton.Text = "Barry";
            this.BarryRButton.UseVisualStyleBackColor = true;
            this.BarryRButton.CheckedChanged += new System.EventHandler(this.BarryButton_CheckedChanged);
            // 
            // KimButton
            // 
            this.KimButton.AutoSize = true;
            this.KimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KimButton.Location = new System.Drawing.Point(626, 114);
            this.KimButton.Name = "KimButton";
            this.KimButton.Size = new System.Drawing.Size(49, 21);
            this.KimButton.TabIndex = 1;
            this.KimButton.Text = "Kim";
            this.KimButton.UseVisualStyleBackColor = true;
            this.KimButton.CheckedChanged += new System.EventHandler(this.KimButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(273, 28);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            this.MaximumBet.Click += new System.EventHandler(this.MaximumBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bike4);
            this.Controls.Add(this.Bike3);
            this.Controls.Add(this.Bike2);
            this.Controls.Add(this.Bike1);
            this.Controls.Add(this.BikeRacetrack);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BikeRace Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BikeRacetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bike4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeRacerAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BikeRacetrack;
        private System.Windows.Forms.PictureBox Bike1;
        private System.Windows.Forms.PictureBox Bike2;
        private System.Windows.Forms.PictureBox Bike3;
        private System.Windows.Forms.PictureBox Bike4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TomRButton;
        private System.Windows.Forms.RadioButton BarryRButton;
        private System.Windows.Forms.RadioButton KimButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BikeRacerAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown BikesNumber;
        private System.Windows.Forms.Button BikeRace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KimBet;
        private System.Windows.Forms.Label TomBet;
        private System.Windows.Forms.Label BarryBet;
    }
}

