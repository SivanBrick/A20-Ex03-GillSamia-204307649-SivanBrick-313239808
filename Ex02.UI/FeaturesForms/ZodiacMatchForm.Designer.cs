namespace Ex03.UI
{
    partial class ZodiacMatchForm
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
            this.zodiacHoroscopBox1 = new System.Windows.Forms.RichTextBox();
            this.listBoxFriendsSign1 = new System.Windows.Forms.ListBox();
            this.findMatchButton1 = new System.Windows.Forms.Button();
            this.userZodiacSignLabel1 = new System.Windows.Forms.Label();
            this.userZodiacLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // zodiacHoroscopBox1
            // 
            this.zodiacHoroscopBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zodiacHoroscopBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zodiacHoroscopBox1.Location = new System.Drawing.Point(11, 112);
            this.zodiacHoroscopBox1.Name = "zodiacHoroscopBox1";
            this.zodiacHoroscopBox1.ReadOnly = true;
            this.zodiacHoroscopBox1.Size = new System.Drawing.Size(259, 345);
            this.zodiacHoroscopBox1.TabIndex = 10;
            this.zodiacHoroscopBox1.Text = "";
            // 
            // listBoxFriendsSign1
            // 
            this.listBoxFriendsSign1.BackColor = System.Drawing.Color.SteelBlue;
            this.listBoxFriendsSign1.FormattingEnabled = true;
            this.listBoxFriendsSign1.ItemHeight = 20;
            this.listBoxFriendsSign1.Location = new System.Drawing.Point(343, 204);
            this.listBoxFriendsSign1.Name = "listBoxFriendsSign1";
            this.listBoxFriendsSign1.Size = new System.Drawing.Size(364, 104);
            this.listBoxFriendsSign1.TabIndex = 9;
            // 
            // findMatchButton1
            // 
            this.findMatchButton1.BackColor = System.Drawing.Color.LightCoral;
            this.findMatchButton1.Location = new System.Drawing.Point(378, 160);
            this.findMatchButton1.Name = "findMatchButton1";
            this.findMatchButton1.Size = new System.Drawing.Size(291, 38);
            this.findMatchButton1.TabIndex = 8;
            this.findMatchButton1.Text = "Click here to find your zodiac match";
            this.findMatchButton1.UseVisualStyleBackColor = false;
            this.findMatchButton1.Click += new System.EventHandler(this.FindMatchButton1_Click);
            // 
            // userZodiacSignLabel1
            // 
            this.userZodiacSignLabel1.AutoSize = true;
            this.userZodiacSignLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userZodiacSignLabel1.Location = new System.Drawing.Point(89, 50);
            this.userZodiacSignLabel1.Name = "userZodiacSignLabel1";
            this.userZodiacSignLabel1.Size = new System.Drawing.Size(43, 22);
            this.userZodiacSignLabel1.TabIndex = 7;
            this.userZodiacSignLabel1.Text = "sign";
            // 
            // userZodiacLabel
            // 
            this.userZodiacLabel.AutoSize = true;
            this.userZodiacLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userZodiacLabel.Location = new System.Drawing.Point(11, 24);
            this.userZodiacLabel.Name = "userZodiacLabel";
            this.userZodiacLabel.Size = new System.Drawing.Size(231, 26);
            this.userZodiacLabel.TabIndex = 6;
            this.userZodiacLabel.Text = "Your Zodiac sign is: ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Ex03.UI.Properties.Resources._640px_Zodiac__PSF_;
            this.pictureBox6.Location = new System.Drawing.Point(266, -37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(523, 525);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // ZodiacMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zodiacHoroscopBox1);
            this.Controls.Add(this.listBoxFriendsSign1);
            this.Controls.Add(this.findMatchButton1);
            this.Controls.Add(this.userZodiacSignLabel1);
            this.Controls.Add(this.userZodiacLabel);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZodiacMatchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Zodiac Match";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox zodiacHoroscopBox1;
        private System.Windows.Forms.ListBox listBoxFriendsSign1;
        private System.Windows.Forms.Button findMatchButton1;
        private System.Windows.Forms.Label userZodiacSignLabel1;
        private System.Windows.Forms.Label userZodiacLabel;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}