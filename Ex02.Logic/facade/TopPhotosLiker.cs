using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    public class TopPhotosLiker
    {
        private User m_LoggedInUser;

        public TopPhotosLiker(User i_LoggedInUser)
        {
            this.LoggedInUser = i_LoggedInUser;
        }

        public User LoggedInUser { get; set; }

        public Dictionary<User, int> GetYourBestPhotosFan()
        {
            User bestFriend = null;
            Dictionary<User, int> friendsLikes = new Dictionary<User, int>();
            try
            {
                foreach (Photo photo in this.LoggedInUser.PhotosTaggedIn)
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

            return friendsLikes;
        }
    }
}