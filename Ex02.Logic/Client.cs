using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    public class Client
    {
        private User m_LoggedInUser;
        private BindingSource m_BindingSource;
        private User m_BestFan;

        public Client(User i_LoggedInUser, BindingSource i_BindingSource)
        {
            this.LoggedInUser = i_LoggedInUser;
            this.BindingSource = i_BindingSource;
            this.m_BestFan = i_LoggedInUser; //first initiallize in case there is no friends who like
        }

        public User LoggedInUser { get => m_LoggedInUser; set => m_LoggedInUser = value; }

        public BindingSource BindingSource { get => m_BindingSource; set => m_BindingSource = value; }

        public void GetYourBestPhotosFan()
        {
          
            Dictionary<User, int> friendsLikes = new Dictionary<User, int>();
            try
            {
                foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
                {
                    foreach (User whoLike in photo.LikedBy)
                    {
                        if (friendsLikes.ContainsKey(whoLike))
                        {
                            friendsLikes[whoLike] += 1;
                        }
                        else
                        {
                            friendsLikes.Add(whoLike, 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
     
            updateBestFan(DictOperations.FindTheBestInDictonary(friendsLikes));
        }

 
        public void GetYourBestPostFan()
        {
            Dictionary<User, int> friendsLikes = new Dictionary<User, int>();

            try
            {
                foreach (Post userPost in this.LoggedInUser.Posts)
                {
                    foreach (User whoLike in userPost.LikedBy)
                    {
                        if (friendsLikes.ContainsKey(whoLike))
                        {
                            friendsLikes[whoLike] += 1;
                        }
                        else
                        {
                            friendsLikes.Add(whoLike, 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            updateBestFan(DictOperations.FindTheBestInDictonary(friendsLikes));
        }

        private void updateBestFan(User i_BestFan)
        {
            m_BestFan = i_BestFan;
            if (m_BestFan == null)
            {
                this.BindingSource.DataSource = new User();
            }
            else
            {
                this.BindingSource.DataSource = m_BestFan;
            }
        }
    }
}
