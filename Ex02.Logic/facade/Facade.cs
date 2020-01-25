using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    public class Facade
    {
        private User m_LoggedInUser;
        private TopPostsLiker m_TopPostsLiker;
        private TopPhotosLiker m_TopPhotosLiker;
        private BindingSource m_BindingSource;

        public Facade(User i_LoggedInUser, BindingSource i_BindingSource)
        {
            this.LoggedInUser = i_LoggedInUser;
            this.TopPostsLiker = new TopPostsLiker(i_LoggedInUser);
            this.TopPhotosLiker = new TopPhotosLiker(i_LoggedInUser);
            this.BindingSource = i_BindingSource;
        }

        public User LoggedInUser { get; set; }

        public TopPostsLiker TopPostsLiker { get; set; }

        public TopPhotosLiker TopPhotosLiker { get; set; }

        public BindingSource BindingSource { get; set; }

        public void FindYourBestFan(List<string> i_ParametersToCheck)
        {
            User bestFriend = null;
            Dictionary<User, int> finalBestFanDictonary = new Dictionary<User, int>();
            Dictionary<User, int> photosLikeres = new Dictionary<User, int>();
            Dictionary<User, int> postsLikers = new Dictionary<User, int>();
            foreach (string parameter in i_ParametersToCheck)
            {
                switch (parameter)
                {
                    case "photos":
                        photosLikeres = this.TopPhotosLiker.GetYourBestPhotosFan();
                        break;
                    case "posts":
                        postsLikers = this.TopPostsLiker.GetYourBestPostFan();
                        break;
                }
            }

            finalBestFanDictonary = DictOperations.CombineYourDictionaries(photosLikeres, postsLikers);
            bestFriend = DictOperations.FindTheBestInDictonary(finalBestFanDictonary);
            if (bestFriend == null)
            {
                this.BindingSource.DataSource = new User();
            }
            else
            {
                this.BindingSource.DataSource = bestFriend;
            }
        }
    }
}
