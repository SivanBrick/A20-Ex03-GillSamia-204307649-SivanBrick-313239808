namespace Ex03.UI
{
    partial class BestFanForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pictureNormalURLLabel;
            this.fanParametersLable = new System.Windows.Forms.Label();
            this.checkedListBoxParametersOfFan1 = new System.Windows.Forms.CheckedListBox();
            this.panelBestPhotosFan1 = new System.Windows.Forms.Panel();
            this.nameOfBestFanLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureNormalURLPictureBox = new System.Windows.Forms.PictureBox();
            this.findTheBestFanButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            pictureNormalURLLabel = new System.Windows.Forms.Label();
            this.panelBestPhotosFan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(41, 125);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // pictureNormalURLLabel
            // 
            pictureNormalURLLabel.AutoSize = true;
            pictureNormalURLLabel.Location = new System.Drawing.Point(41, 38);
            pictureNormalURLLabel.Name = "pictureNormalURLLabel";
            pictureNormalURLLabel.Size = new System.Drawing.Size(62, 20);
            pictureNormalURLLabel.TabIndex = 2;
            pictureNormalURLLabel.Text = "Picture:";
            // 
            // fanParametersLable
            // 
            this.fanParametersLable.AutoSize = true;
            this.fanParametersLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fanParametersLable.Location = new System.Drawing.Point(296, 50);
            this.fanParametersLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fanParametersLable.Name = "fanParametersLable";
            this.fanParametersLable.Size = new System.Drawing.Size(211, 20);
            this.fanParametersLable.TabIndex = 25;
            this.fanParametersLable.Text = "choose your fan parameters:";
            // 
            // checkedListBoxParametersOfFan1
            // 
            this.checkedListBoxParametersOfFan1.BackColor = System.Drawing.Color.SteelBlue;
            this.checkedListBoxParametersOfFan1.FormattingEnabled = true;
            this.checkedListBoxParametersOfFan1.Location = new System.Drawing.Point(332, 83);
            this.checkedListBoxParametersOfFan1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxParametersOfFan1.Name = "checkedListBoxParametersOfFan1";
            this.checkedListBoxParametersOfFan1.Size = new System.Drawing.Size(141, 27);
            this.checkedListBoxParametersOfFan1.TabIndex = 24;
            this.checkedListBoxParametersOfFan1.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxParametersOfFan1_SelectedIndexChanged);
            // 
            // panelBestPhotosFan1
            // 
            this.panelBestPhotosFan1.Controls.Add(nameLabel);
            this.panelBestPhotosFan1.Controls.Add(this.nameOfBestFanLabel1);
            this.panelBestPhotosFan1.Controls.Add(pictureNormalURLLabel);
            this.panelBestPhotosFan1.Controls.Add(this.pictureNormalURLPictureBox);
            this.panelBestPhotosFan1.Location = new System.Drawing.Point(255, 188);
            this.panelBestPhotosFan1.Name = "panelBestPhotosFan1";
            this.panelBestPhotosFan1.Size = new System.Drawing.Size(302, 192);
            this.panelBestPhotosFan1.TabIndex = 23;
            // 
            // nameOfBestFanLabel1
            // 
            this.nameOfBestFanLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameOfBestFanLabel1.Location = new System.Drawing.Point(118, 125);
            this.nameOfBestFanLabel1.Name = "nameOfBestFanLabel1";
            this.nameOfBestFanLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameOfBestFanLabel1.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // pictureNormalURLPictureBox
            // 
            this.pictureNormalURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "PictureNormalURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureNormalURLPictureBox.Location = new System.Drawing.Point(118, 27);
            this.pictureNormalURLPictureBox.Name = "pictureNormalURLPictureBox";
            this.pictureNormalURLPictureBox.Size = new System.Drawing.Size(140, 83);
            this.pictureNormalURLPictureBox.TabIndex = 3;
            this.pictureNormalURLPictureBox.TabStop = false;
            // 
            // findTheBestFanButton1
            // 
            this.findTheBestFanButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.findTheBestFanButton1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.findTheBestFanButton1.Location = new System.Drawing.Point(255, 136);
            this.findTheBestFanButton1.Name = "findTheBestFanButton1";
            this.findTheBestFanButton1.Size = new System.Drawing.Size(296, 38);
            this.findTheBestFanButton1.TabIndex = 22;
            this.findTheBestFanButton1.Text = "Click here to find your best fan";
            this.findTheBestFanButton1.UseVisualStyleBackColor = false;
            this.findTheBestFanButton1.Click += new System.EventHandler(this.FindTheBestFanButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(319, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Find your best fan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex03.UI.Properties.Resources.like_box;
            this.pictureBox1.Location = new System.Drawing.Point(44, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ex03.UI.Properties.Resources.small_facebook_like_icon_26;
            this.pictureBox2.Location = new System.Drawing.Point(168, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ex03.UI.Properties.Resources.small_facebook_like_icon_26;
            this.pictureBox3.Location = new System.Drawing.Point(525, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ex03.UI.Properties.Resources.like_box;
            this.pictureBox4.Location = new System.Drawing.Point(589, 206);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 154);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // BestFanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fanParametersLable);
            this.Controls.Add(this.checkedListBoxParametersOfFan1);
            this.Controls.Add(this.panelBestPhotosFan1);
            this.Controls.Add(this.findTheBestFanButton1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BestFanForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Best Fan";
            this.panelBestPhotosFan1.ResumeLayout(false);
            this.panelBestPhotosFan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fanParametersLable;
        private System.Windows.Forms.CheckedListBox checkedListBoxParametersOfFan1;
        private System.Windows.Forms.Panel panelBestPhotosFan1;
        private System.Windows.Forms.Button findTheBestFanButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameOfBestFanLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox pictureNormalURLPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}