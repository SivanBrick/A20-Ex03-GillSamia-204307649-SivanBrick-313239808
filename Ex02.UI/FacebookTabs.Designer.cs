namespace Ex03.UI
{
    partial class FacebookTabs
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookTabs));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FeaturesTab = new System.Windows.Forms.TabPage();
            this.FindYourBestFanForm = new System.Windows.Forms.Button();
            this.ZodiacMatchForm = new System.Windows.Forms.Button();
            this.albumsTab = new System.Windows.Forms.TabPage();
            this.userPhotosBox = new System.Windows.Forms.ListBox();
            this.getUserPhotosLabel = new System.Windows.Forms.LinkLabel();
            this.getAlbumsLabel = new System.Windows.Forms.LinkLabel();
            this.userAlbumsBox = new System.Windows.Forms.ListBox();
            this.getUserVideosLable = new System.Windows.Forms.LinkLabel();
            this.userVideosBox = new System.Windows.Forms.ListBox();
            this.userPhoto1 = new System.Windows.Forms.PictureBox();
            this.userPhoto2 = new System.Windows.Forms.PictureBox();
            this.userPhoto3 = new System.Windows.Forms.PictureBox();
            this.userPhoto4 = new System.Windows.Forms.PictureBox();
            this.userAlbumPictureBox1 = new System.Windows.Forms.PictureBox();
            this.userAlbumPictureBox2 = new System.Windows.Forms.PictureBox();
            this.userAlbumPictureBox3 = new System.Windows.Forms.PictureBox();
            this.userAlbumPictureBox4 = new System.Windows.Forms.PictureBox();
            this.timelineTab = new System.Windows.Forms.TabPage();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.userDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.statusText = new System.Windows.Forms.RichTextBox();
            this.postTextButton = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.recentPostsLable = new System.Windows.Forms.LinkLabel();
            this.recentPostListBox = new System.Windows.Forms.ListBox();
            this.showFriendsLable = new System.Windows.Forms.LinkLabel();
            this.getUserPagesLable = new System.Windows.Forms.LinkLabel();
            this.userPagesBox = new System.Windows.Forms.ListBox();
            this.getUserCheckInLabel = new System.Windows.Forms.LinkLabel();
            this.userCheckInsBox = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.facebookTab = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.FeaturesTab.SuspendLayout();
            this.albumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox4)).BeginInit();
            this.timelineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.facebookTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // FeaturesTab
            // 
            this.FeaturesTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FeaturesTab.Controls.Add(this.ZodiacMatchForm);
            this.FeaturesTab.Controls.Add(this.FindYourBestFanForm);
            this.FeaturesTab.Location = new System.Drawing.Point(4, 29);
            this.FeaturesTab.Name = "FeaturesTab";
            this.FeaturesTab.Padding = new System.Windows.Forms.Padding(3);
            this.FeaturesTab.Size = new System.Drawing.Size(784, 496);
            this.FeaturesTab.TabIndex = 4;
            this.FeaturesTab.Text = "Features";
            // 
            // FindYourBestFanForm
            // 
            this.FindYourBestFanForm.BackColor = System.Drawing.Color.Tan;
            this.FindYourBestFanForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindYourBestFanForm.Location = new System.Drawing.Point(128, 115);
            this.FindYourBestFanForm.Name = "FindYourBestFanForm";
            this.FindYourBestFanForm.Size = new System.Drawing.Size(239, 135);
            this.FindYourBestFanForm.TabIndex = 0;
            this.FindYourBestFanForm.Text = "FindYourBestFanForm";
            this.FindYourBestFanForm.UseVisualStyleBackColor = false;
            this.FindYourBestFanForm.Click += new System.EventHandler(this.findYourBestFanForm_Click);
            // 
            // ZodiacMatchForm
            // 
            this.ZodiacMatchForm.BackColor = System.Drawing.Color.Tan;
            this.ZodiacMatchForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZodiacMatchForm.Location = new System.Drawing.Point(416, 115);
            this.ZodiacMatchForm.Name = "ZodiacMatchForm";
            this.ZodiacMatchForm.Size = new System.Drawing.Size(239, 135);
            this.ZodiacMatchForm.TabIndex = 1;
            this.ZodiacMatchForm.Text = "ZodiacMatchForm";
            this.ZodiacMatchForm.UseVisualStyleBackColor = false;
            this.ZodiacMatchForm.Click += new System.EventHandler(this.zodiacMatchForm_Click);
            // 
            // albumsTab
            // 
            this.albumsTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.albumsTab.Controls.Add(this.userAlbumPictureBox4);
            this.albumsTab.Controls.Add(this.userAlbumPictureBox3);
            this.albumsTab.Controls.Add(this.userAlbumPictureBox2);
            this.albumsTab.Controls.Add(this.userAlbumPictureBox1);
            this.albumsTab.Controls.Add(this.userPhoto4);
            this.albumsTab.Controls.Add(this.userPhoto3);
            this.albumsTab.Controls.Add(this.userPhoto2);
            this.albumsTab.Controls.Add(this.userPhoto1);
            this.albumsTab.Controls.Add(this.userVideosBox);
            this.albumsTab.Controls.Add(this.getUserVideosLable);
            this.albumsTab.Controls.Add(this.userAlbumsBox);
            this.albumsTab.Controls.Add(this.getAlbumsLabel);
            this.albumsTab.Controls.Add(this.getUserPhotosLabel);
            this.albumsTab.Controls.Add(this.userPhotosBox);
            this.albumsTab.Location = new System.Drawing.Point(4, 29);
            this.albumsTab.Name = "albumsTab";
            this.albumsTab.Padding = new System.Windows.Forms.Padding(3);
            this.albumsTab.Size = new System.Drawing.Size(784, 496);
            this.albumsTab.TabIndex = 1;
            this.albumsTab.Text = "Albums";
            // 
            // userPhotosBox
            // 
            this.userPhotosBox.BackColor = System.Drawing.Color.SteelBlue;
            this.userPhotosBox.FormattingEnabled = true;
            this.userPhotosBox.ItemHeight = 20;
            this.userPhotosBox.Location = new System.Drawing.Point(16, 46);
            this.userPhotosBox.Name = "userPhotosBox";
            this.userPhotosBox.Size = new System.Drawing.Size(235, 184);
            this.userPhotosBox.TabIndex = 0;
            // 
            // getUserPhotosLabel
            // 
            this.getUserPhotosLabel.AutoSize = true;
            this.getUserPhotosLabel.Location = new System.Drawing.Point(16, 23);
            this.getUserPhotosLabel.Name = "getUserPhotosLabel";
            this.getUserPhotosLabel.Size = new System.Drawing.Size(127, 20);
            this.getUserPhotosLabel.TabIndex = 1;
            this.getUserPhotosLabel.TabStop = true;
            this.getUserPhotosLabel.Text = "Get your photos:";
            this.getUserPhotosLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getUserPhotosLabel_LinkClicked);
            // 
            // getAlbumsLabel
            // 
            this.getAlbumsLabel.AutoSize = true;
            this.getAlbumsLabel.Location = new System.Drawing.Point(266, 23);
            this.getAlbumsLabel.Name = "getAlbumsLabel";
            this.getAlbumsLabel.Size = new System.Drawing.Size(129, 20);
            this.getAlbumsLabel.TabIndex = 2;
            this.getAlbumsLabel.TabStop = true;
            this.getAlbumsLabel.Text = "Get your albums:";
            this.getAlbumsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getAlbumsLabel_LinkClicked);
            // 
            // userAlbumsBox
            // 
            this.userAlbumsBox.BackColor = System.Drawing.Color.SteelBlue;
            this.userAlbumsBox.FormattingEnabled = true;
            this.userAlbumsBox.ItemHeight = 20;
            this.userAlbumsBox.Location = new System.Drawing.Point(270, 46);
            this.userAlbumsBox.Name = "userAlbumsBox";
            this.userAlbumsBox.Size = new System.Drawing.Size(235, 184);
            this.userAlbumsBox.TabIndex = 3;
            // 
            // getUserVideosLable
            // 
            this.getUserVideosLable.AutoSize = true;
            this.getUserVideosLable.Location = new System.Drawing.Point(522, 23);
            this.getUserVideosLable.Name = "getUserVideosLable";
            this.getUserVideosLable.Size = new System.Drawing.Size(123, 20);
            this.getUserVideosLable.TabIndex = 4;
            this.getUserVideosLable.TabStop = true;
            this.getUserVideosLable.Text = "Get your videos:";
            this.getUserVideosLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getUserVideosLable_LinkClicked);
            // 
            // userVideosBox
            // 
            this.userVideosBox.BackColor = System.Drawing.Color.SteelBlue;
            this.userVideosBox.FormattingEnabled = true;
            this.userVideosBox.ItemHeight = 20;
            this.userVideosBox.Location = new System.Drawing.Point(526, 46);
            this.userVideosBox.Name = "userVideosBox";
            this.userVideosBox.Size = new System.Drawing.Size(235, 184);
            this.userVideosBox.TabIndex = 5;
            // 
            // userPhoto1
            // 
            this.userPhoto1.InitialImage = null;
            this.userPhoto1.Location = new System.Drawing.Point(20, 243);
            this.userPhoto1.Name = "userPhoto1";
            this.userPhoto1.Size = new System.Drawing.Size(105, 114);
            this.userPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto1.TabIndex = 6;
            this.userPhoto1.TabStop = false;
            // 
            // userPhoto2
            // 
            this.userPhoto2.InitialImage = null;
            this.userPhoto2.Location = new System.Drawing.Point(146, 243);
            this.userPhoto2.Name = "userPhoto2";
            this.userPhoto2.Size = new System.Drawing.Size(105, 114);
            this.userPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto2.TabIndex = 7;
            this.userPhoto2.TabStop = false;
            // 
            // userPhoto3
            // 
            this.userPhoto3.InitialImage = null;
            this.userPhoto3.Location = new System.Drawing.Point(20, 376);
            this.userPhoto3.Name = "userPhoto3";
            this.userPhoto3.Size = new System.Drawing.Size(105, 114);
            this.userPhoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto3.TabIndex = 8;
            this.userPhoto3.TabStop = false;
            // 
            // userPhoto4
            // 
            this.userPhoto4.InitialImage = null;
            this.userPhoto4.Location = new System.Drawing.Point(146, 376);
            this.userPhoto4.Name = "userPhoto4";
            this.userPhoto4.Size = new System.Drawing.Size(105, 114);
            this.userPhoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto4.TabIndex = 9;
            this.userPhoto4.TabStop = false;
            // 
            // userAlbumPictureBox1
            // 
            this.userAlbumPictureBox1.InitialImage = null;
            this.userAlbumPictureBox1.Location = new System.Drawing.Point(270, 243);
            this.userAlbumPictureBox1.Name = "userAlbumPictureBox1";
            this.userAlbumPictureBox1.Size = new System.Drawing.Size(105, 114);
            this.userAlbumPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAlbumPictureBox1.TabIndex = 10;
            this.userAlbumPictureBox1.TabStop = false;
            // 
            // userAlbumPictureBox2
            // 
            this.userAlbumPictureBox2.InitialImage = null;
            this.userAlbumPictureBox2.Location = new System.Drawing.Point(396, 243);
            this.userAlbumPictureBox2.Name = "userAlbumPictureBox2";
            this.userAlbumPictureBox2.Size = new System.Drawing.Size(105, 114);
            this.userAlbumPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAlbumPictureBox2.TabIndex = 11;
            this.userAlbumPictureBox2.TabStop = false;
            // 
            // userAlbumPictureBox3
            // 
            this.userAlbumPictureBox3.InitialImage = null;
            this.userAlbumPictureBox3.Location = new System.Drawing.Point(270, 376);
            this.userAlbumPictureBox3.Name = "userAlbumPictureBox3";
            this.userAlbumPictureBox3.Size = new System.Drawing.Size(105, 114);
            this.userAlbumPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAlbumPictureBox3.TabIndex = 12;
            this.userAlbumPictureBox3.TabStop = false;
            // 
            // userAlbumPictureBox4
            // 
            this.userAlbumPictureBox4.InitialImage = null;
            this.userAlbumPictureBox4.Location = new System.Drawing.Point(396, 376);
            this.userAlbumPictureBox4.Name = "userAlbumPictureBox4";
            this.userAlbumPictureBox4.Size = new System.Drawing.Size(105, 114);
            this.userAlbumPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAlbumPictureBox4.TabIndex = 13;
            this.userAlbumPictureBox4.TabStop = false;
            // 
            // timelineTab
            // 
            this.timelineTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timelineTab.Controls.Add(this.logoutButton);
            this.timelineTab.Controls.Add(this.userCheckInsBox);
            this.timelineTab.Controls.Add(this.getUserCheckInLabel);
            this.timelineTab.Controls.Add(this.userPagesBox);
            this.timelineTab.Controls.Add(this.getUserPagesLable);
            this.timelineTab.Controls.Add(this.showFriendsLable);
            this.timelineTab.Controls.Add(this.recentPostListBox);
            this.timelineTab.Controls.Add(this.recentPostsLable);
            this.timelineTab.Controls.Add(this.welcomeLabel);
            this.timelineTab.Controls.Add(this.infoLabel);
            this.timelineTab.Controls.Add(this.listBoxFriends);
            this.timelineTab.Controls.Add(this.postTextButton);
            this.timelineTab.Controls.Add(this.statusText);
            this.timelineTab.Controls.Add(this.userDetailsTextBox);
            this.timelineTab.Controls.Add(this.userPictureBox);
            this.timelineTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timelineTab.Location = new System.Drawing.Point(4, 29);
            this.timelineTab.Name = "timelineTab";
            this.timelineTab.Padding = new System.Windows.Forms.Padding(3);
            this.timelineTab.Size = new System.Drawing.Size(784, 496);
            this.timelineTab.TabIndex = 0;
            this.timelineTab.Text = "Timeline";
            this.timelineTab.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.ImageLocation = "";
            this.userPictureBox.InitialImage = null;
            this.userPictureBox.Location = new System.Drawing.Point(6, 6);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(137, 135);
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // userDetailsTextBox
            // 
            this.userDetailsTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.userDetailsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userDetailsTextBox.Location = new System.Drawing.Point(461, 41);
            this.userDetailsTextBox.Name = "userDetailsTextBox";
            this.userDetailsTextBox.ReadOnly = true;
            this.userDetailsTextBox.Size = new System.Drawing.Size(317, 148);
            this.userDetailsTextBox.TabIndex = 1;
            this.userDetailsTextBox.Text = "";
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(6, 147);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(445, 84);
            this.statusText.TabIndex = 2;
            this.statusText.Text = "What\'s on your mind?";
            this.statusText.UseWaitCursor = true;
            this.statusText.TextChanged += new System.EventHandler(this.statusText_TextChanged);
            // 
            // postTextButton
            // 
            this.postTextButton.Enabled = false;
            this.postTextButton.Location = new System.Drawing.Point(376, 198);
            this.postTextButton.Name = "postTextButton";
            this.postTextButton.Size = new System.Drawing.Size(75, 33);
            this.postTextButton.TabIndex = 3;
            this.postTextButton.Text = "Post";
            this.postTextButton.UseVisualStyleBackColor = true;
            this.postTextButton.Click += new System.EventHandler(this.postTextBox_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.SteelBlue;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(457, 218);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(321, 124);
            this.listBoxFriends.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(457, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(46, 20);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Info:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Enabled = false;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomeLabel.Location = new System.Drawing.Point(149, 115);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(209, 26);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "welcome message";
            // 
            // recentPostsLable
            // 
            this.recentPostsLable.AutoSize = true;
            this.recentPostsLable.Location = new System.Drawing.Point(6, 232);
            this.recentPostsLable.Name = "recentPostsLable";
            this.recentPostsLable.Size = new System.Drawing.Size(153, 20);
            this.recentPostsLable.TabIndex = 8;
            this.recentPostsLable.TabStop = true;
            this.recentPostsLable.Text = "Show Recent Posts:";
            this.recentPostsLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recentPostsLable_LinkClicked);
            // 
            // recentPostListBox
            // 
            this.recentPostListBox.BackColor = System.Drawing.Color.SteelBlue;
            this.recentPostListBox.FormattingEnabled = true;
            this.recentPostListBox.HorizontalScrollbar = true;
            this.recentPostListBox.ItemHeight = 20;
            this.recentPostListBox.Location = new System.Drawing.Point(6, 258);
            this.recentPostListBox.Name = "recentPostListBox";
            this.recentPostListBox.Size = new System.Drawing.Size(445, 104);
            this.recentPostListBox.TabIndex = 9;
            // 
            // showFriendsLable
            // 
            this.showFriendsLable.AutoSize = true;
            this.showFriendsLable.Location = new System.Drawing.Point(458, 195);
            this.showFriendsLable.Name = "showFriendsLable";
            this.showFriendsLable.Size = new System.Drawing.Size(110, 20);
            this.showFriendsLable.TabIndex = 10;
            this.showFriendsLable.TabStop = true;
            this.showFriendsLable.Text = "Show Friends:";
            this.showFriendsLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showFriendsLable_LinkClicked);
            // 
            // getUserPagesLable
            // 
            this.getUserPagesLable.AutoSize = true;
            this.getUserPagesLable.Location = new System.Drawing.Point(6, 365);
            this.getUserPagesLable.Name = "getUserPagesLable";
            this.getUserPagesLable.Size = new System.Drawing.Size(144, 20);
            this.getUserPagesLable.TabIndex = 11;
            this.getUserPagesLable.TabStop = true;
            this.getUserPagesLable.Text = "Show Liked Pages:";
            this.getUserPagesLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getUserPagesLable_LinkClicked);
            // 
            // userPagesBox
            // 
            this.userPagesBox.BackColor = System.Drawing.Color.SteelBlue;
            this.userPagesBox.FormattingEnabled = true;
            this.userPagesBox.HorizontalScrollbar = true;
            this.userPagesBox.ItemHeight = 20;
            this.userPagesBox.Location = new System.Drawing.Point(6, 388);
            this.userPagesBox.Name = "userPagesBox";
            this.userPagesBox.Size = new System.Drawing.Size(445, 104);
            this.userPagesBox.TabIndex = 12;
            // 
            // getUserCheckInLabel
            // 
            this.getUserCheckInLabel.AutoSize = true;
            this.getUserCheckInLabel.Location = new System.Drawing.Point(458, 345);
            this.getUserCheckInLabel.Name = "getUserCheckInLabel";
            this.getUserCheckInLabel.Size = new System.Drawing.Size(120, 20);
            this.getUserCheckInLabel.TabIndex = 13;
            this.getUserCheckInLabel.TabStop = true;
            this.getUserCheckInLabel.Text = "Show Check In:";
            this.getUserCheckInLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.getUserEventsLabel_LinkClicked);
            // 
            // userCheckInsBox
            // 
            this.userCheckInsBox.BackColor = System.Drawing.Color.SteelBlue;
            this.userCheckInsBox.FormattingEnabled = true;
            this.userCheckInsBox.HorizontalScrollbar = true;
            this.userCheckInsBox.ItemHeight = 20;
            this.userCheckInsBox.Location = new System.Drawing.Point(457, 368);
            this.userCheckInsBox.Name = "userCheckInsBox";
            this.userCheckInsBox.Size = new System.Drawing.Size(321, 124);
            this.userCheckInsBox.TabIndex = 14;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logoutButton.Location = new System.Drawing.Point(149, 6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(84, 36);
            this.logoutButton.TabIndex = 15;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // facebookTab
            // 
            this.facebookTab.CausesValidation = false;
            this.facebookTab.Controls.Add(this.timelineTab);
            this.facebookTab.Controls.Add(this.albumsTab);
            this.facebookTab.Controls.Add(this.FeaturesTab);
            this.facebookTab.Location = new System.Drawing.Point(4, 3);
            this.facebookTab.Name = "facebookTab";
            this.facebookTab.SelectedIndex = 0;
            this.facebookTab.Size = new System.Drawing.Size(792, 529);
            this.facebookTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.facebookTab.TabIndex = 0;
            // 
            // FacebookTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.facebookTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookTabs";
            this.Text = "FaceBook";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.FeaturesTab.ResumeLayout(false);
            this.albumsTab.ResumeLayout(false);
            this.albumsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumPictureBox4)).EndInit();
            this.timelineTab.ResumeLayout(false);
            this.timelineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.facebookTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TabPage FeaturesTab;
        private System.Windows.Forms.Button ZodiacMatchForm;
        private System.Windows.Forms.Button FindYourBestFanForm;
        private System.Windows.Forms.TabPage albumsTab;
        private System.Windows.Forms.PictureBox userAlbumPictureBox4;
        private System.Windows.Forms.PictureBox userAlbumPictureBox3;
        private System.Windows.Forms.PictureBox userAlbumPictureBox2;
        private System.Windows.Forms.PictureBox userAlbumPictureBox1;
        private System.Windows.Forms.PictureBox userPhoto4;
        private System.Windows.Forms.PictureBox userPhoto3;
        private System.Windows.Forms.PictureBox userPhoto2;
        private System.Windows.Forms.PictureBox userPhoto1;
        private System.Windows.Forms.ListBox userVideosBox;
        private System.Windows.Forms.LinkLabel getUserVideosLable;
        private System.Windows.Forms.ListBox userAlbumsBox;
        private System.Windows.Forms.LinkLabel getAlbumsLabel;
        private System.Windows.Forms.LinkLabel getUserPhotosLabel;
        private System.Windows.Forms.ListBox userPhotosBox;
        private System.Windows.Forms.TabPage timelineTab;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox userCheckInsBox;
        private System.Windows.Forms.LinkLabel getUserCheckInLabel;
        private System.Windows.Forms.ListBox userPagesBox;
        private System.Windows.Forms.LinkLabel getUserPagesLable;
        private System.Windows.Forms.LinkLabel showFriendsLable;
        private System.Windows.Forms.ListBox recentPostListBox;
        private System.Windows.Forms.LinkLabel recentPostsLable;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button postTextButton;
        private System.Windows.Forms.RichTextBox statusText;
        private System.Windows.Forms.RichTextBox userDetailsTextBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TabControl facebookTab;
    }
}