using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    public class DictOperations
    {
       
        public static User FindTheBestInDictonary(Dictionary<User, int> i_DictonaryToCheck)
        {
            int maxLikes = 0;
            User bestFriend = null;

            foreach (KeyValuePair<User, int> friend in i_DictonaryToCheck)
            {
                int numOfLikesByThisFriend = friend.Value;
                if (numOfLikesByThisFriend > maxLikes)
                {
                    maxLikes = numOfLikesByThisFriend;
                    bestFriend = friend.Key;
                }
            }

            return bestFriend;
        }
    }
}
