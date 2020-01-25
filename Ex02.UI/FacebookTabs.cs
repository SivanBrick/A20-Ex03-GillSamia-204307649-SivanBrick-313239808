using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex03.UI
{
    public partial class FacebookTabs : Form
    {
        private User m_LoggedInUser;
        private string m_ErrorMsg = "OPPS! Somthing went wrong..";

        public FacebookTabs()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            this.InitializeComponent();
            this.LoggedInUser = Singleton.Instance.SingletonLoggedInUser;
            this.Text = string.Format("Logged in as {0} {1}", this.LoggedInUser.FirstName, this.LoggedInUser.LastName);
            this.fetchUserInfo();
        }

        private User LoggedInUser { get; set; }

        public string ErrorMsg { get; set; }

        private void fetchUserInfo()
        {
            try
            {
                welcomeLabel.Text = "Hey " + this.LoggedInUser.FirstName;
                string userProfilePictureUrl = this.LoggedInUser.PictureNormalURL;
                userPictureBox.LoadAsync(userProfilePictureUrl);
                this.userDetailsTextBox.Text = string.Format(
                    "User Name: {0} {1}\n" +
                    "Gender: {2}\n" +
                    "Relationship Status: {3}\n" +
                    "HomeTown : {4}\n" +
                    "Education: {5}\n" +
                    "Email: {6}",
                    this.LoggedInUser.FirstName, 
                    this.LoggedInUser.LastName,
                    this.LoggedInUser.Gender,
                    this.LoggedInUser.RelationshipStatus,
                    this.LoggedInUser.Hometown,
                    this.LoggedInUser.Educations,
                    this.LoggedInUser.Email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fetchFriends()
        {
            try
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
                listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
                
                if (this.LoggedInUser.Friends.Count == 0)
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }

                foreach (User friend in this.LoggedInUser.Friends)
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            catch (Exception ex)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void fetchPosts()
        {
            try
            {
                recentPostListBox.Invoke(new Action(() =>  recentPostListBox.Items.Clear()));
                recentPostListBox.Invoke(new Action(() => recentPostListBox.DisplayMember = "Post"));
                if (this.LoggedInUser.Posts.Count == 0)
                {
                    MessageBox.Show("No post to show :(");
                }

                foreach (Post userPost in this.LoggedInUser.Posts)
                {
                    if (userPost.Message != null)
                    {
                        recentPostListBox.Invoke(new Action(() => recentPostListBox.Items.Add(userPost.Message)));
                    }
                    else if (userPost.Caption != null)
                    {
                        recentPostListBox.Invoke(new Action(() => recentPostListBox.Items.Add(userPost.Caption)));
                    }
                    else
                    {
                        recentPostListBox.Invoke(new Action(() => recentPostListBox.Items.Add(string.Format("[{0}]", userPost.Type))));
                    }
                }
            }
            catch (Exception ex)
            {
                recentPostListBox.Invoke(new Action(() => recentPostListBox.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void fetchPhotos()
        {
            try
            {
                userPhotosBox.Invoke(new Action(() => this.userPhotosBox.Items.Clear()));
                userPhotosBox.Invoke(new Action(() => this.userPhotosBox.DisplayMember = "URL"));

                if (this.LoggedInUser.PhotosTaggedIn.Count == 0)
                {
                    userPhotosBox.Invoke(new Action(() => userPhotosBox.Items.Add("No photos to retrive..")));
                }
                else
                {
                    foreach (Photo userPhoto in this.LoggedInUser.PhotosTaggedIn)
                    {
                        userPhotosBox.Invoke(new Action(() => userPhotosBox.Items.Add(userPhoto.PictureNormalURL)));
                    }

                    if (this.LoggedInUser.PhotosTaggedIn.Count > 3)
                    {
                        userPhoto1.Invoke(new Action(() => this.userPhoto1.LoadAsync(this.LoggedInUser.PhotosTaggedIn[0].PictureNormalURL)));
                        userPhoto2.Invoke(new Action(() => this.userPhoto2.LoadAsync(this.LoggedInUser.PhotosTaggedIn[1].PictureNormalURL)));
                        userPhoto3.Invoke(new Action(() => this.userPhoto3.LoadAsync(this.LoggedInUser.PhotosTaggedIn[2].PictureNormalURL)));
                        userPhoto4.Invoke(new Action(() => this.userPhoto4.LoadAsync(this.LoggedInUser.PhotosTaggedIn[3].PictureNormalURL)));
                    }
                }
            }
            catch (Exception ex)
            {
                userPhotosBox.Invoke(new Action(() => userPhotosBox.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void fetchAlbums()
        {
            try
            {
                userAlbumsBox.Invoke(new Action(() => this.userAlbumsBox.Items.Clear()));
                userAlbumsBox.Invoke(new Action(() => this.userAlbumsBox.DisplayMember = "Album"));

                if (this.LoggedInUser.Albums.Count == 0)
                {
                    MessageBox.Show("No albums to show :(");
                    return;
                }

                foreach (Album userAlbum in this.LoggedInUser.Albums)
                {
                    userAlbumsBox.Invoke(new Action(() => this.userAlbumsBox.Items.Add(userAlbum.Name)));
                }

                if (this.LoggedInUser.Albums.Count > 4)
                {
                    userAlbumPictureBox1.Invoke(new Action(() => this.userAlbumPictureBox1.LoadAsync(this.LoggedInUser.Albums[0].PictureAlbumURL)));
                    userAlbumPictureBox2.Invoke(new Action(() => this.userAlbumPictureBox2.LoadAsync(this.LoggedInUser.Albums[1].PictureAlbumURL)));
                    userAlbumPictureBox3.Invoke(new Action(() => this.userAlbumPictureBox3.LoadAsync(this.LoggedInUser.Albums[2].PictureAlbumURL)));
                    userAlbumPictureBox4.Invoke(new Action(() => this.userAlbumPictureBox4.LoadAsync(this.LoggedInUser.Albums[3].PictureAlbumURL)));
                }
            }
            catch (Exception ex)
            {
                userAlbumsBox.Invoke(new Action(() => this.userAlbumsBox.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void fetchCheckIns()
        {
            try
            {
                userCheckInsBox.Invoke(new Action(() => this.userCheckInsBox.Items.Clear()));
                userCheckInsBox.Invoke(new Action(() => this.userCheckInsBox.DisplayMember = "Location"));
                if (this.LoggedInUser.Checkins.Count == 0)
                {
                    userCheckInsBox.Invoke(new Action(() => userCheckInsBox.Items.Add("No CheckIns to retrive :(")));
                    return;
                }

                foreach (Checkin userCheckIn in this.LoggedInUser.Checkins)
                {
                    if (userCheckIn.Place != null)
                    {
                        userCheckInsBox.Invoke(new Action(() => this.userCheckInsBox.Items.Add(userCheckIn.Place)));
                    }
                }
            }            
            catch (Exception ex)
            {
                userCheckInsBox.Invoke(new Action(() => this.userCheckInsBox.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void fetchPages()
        {
            try
            {
                if (this.LoggedInUser.LikedPages.Count == 0)
                {
                    userPagesBox.Invoke(new Action(() => this.userPagesBox.Items.Add("No Pages to retrive..")));
                }
                else
                {
                    foreach (Page userLikedPage in this.LoggedInUser.LikedPages)
                    {
                        userPagesBox.Invoke(new Action(() => this.userPagesBox.Items.Add(userLikedPage.Name)));
                    }
                }
            }
            catch (Exception ex)
            {
                userPagesBox.Invoke(new Action(() => this.userPagesBox.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void fetchVideos()
        {
            try
            {
                if (this.LoggedInUser.Videos.Count == 0)
                {
                    userVideosBox.Invoke(new Action(() => userVideosBox.Items.Add("No videos to retrive..")));
                }
                else
                {
                    foreach (Video userVideo in this.LoggedInUser.Videos)
                    {
                        userVideosBox.Invoke(new Action(() => userVideosBox.Items.Add(userVideo.Name)));
                    }
                }
            }
            catch (Exception ex)
            {
                userVideosBox.Invoke(new Action(() => this.userVideosBox.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex))));
            }
        }

        private void statusText_TextChanged(object sender, EventArgs e)
        {
            postTextButton.Enabled = !(statusText.Text == "What's on your mind?" || statusText.Text == string.Empty);
        }

        // DEPRECATED function
        private void postTextBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We can't upload your post - Sorry");
        }

        private void recentPostsLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchPosts).Start();
        }

        private void showFriendsLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchFriends).Start();
        }

        private void getUserPhotosLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchPhotos).Start();
        }

        private void getAlbumsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchAlbums).Start();
        }

        private void getUserEventsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchCheckIns).Start();
        }

        private void getUserPagesLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchPages).Start();
        }

        private void getUserVideosLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(this.fetchVideos).Start();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FacebookWrapper.FacebookService.Logout(this.logOutActions);
        }

        private void logOutActions()
        {
            this.Close();
        }

        private void findYourBestFanForm_Click(object sender, EventArgs e)
        {
            try
            {
                Form beatFanForm = FactoryMethod.FeatureFormCreator(this.LoggedInUser, eFacebookFeatures.BestFan);
                beatFanForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zodiacMatchForm_Click(object sender, EventArgs e)
        {
            try
            {
                Form zodiacMatchForm = FactoryMethod.FeatureFormCreator(this.LoggedInUser, eFacebookFeatures.ZodiacMatch);
                zodiacMatchForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
