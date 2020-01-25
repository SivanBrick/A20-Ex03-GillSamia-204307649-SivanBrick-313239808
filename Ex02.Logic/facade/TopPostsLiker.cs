using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex02.Logic
{
    public class TopPostsLiker
    {
        private User m_LoggedInUser;
        
        public TopPostsLiker(User i_LoggedInUser)
        {
            this.LoggedInUser = i_LoggedInUser;
        }

        public User LoggedInUser { get; set; }

        public Dictionary<User, int> GetYourBestPostFan()
        {
            User bestFriend = null;
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

            return friendsLikes;
        }
    }
}