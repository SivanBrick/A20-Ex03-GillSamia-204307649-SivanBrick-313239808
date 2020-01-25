using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex02.Logic
{
    public class DictOperations
    {
        public static Dictionary<User, int> CombineYourDictionaries(Dictionary<User, int> i_FirstDictonary, Dictionary<User, int> i_LastDictonary)
        {
            Dictionary<User, int> combinedDict = new Dictionary<User, int>();
            foreach (KeyValuePair<User, int> friend in i_FirstDictonary)
            {
                combinedDict.Add(friend.Key, friend.Value);
                if (i_LastDictonary.ContainsKey(friend.Key))
                {
                    combinedDict[friend.Key] += friend.Value;
                }
            }

            foreach (KeyValuePair<User, int> friend in i_LastDictonary)
            {
                if (!combinedDict.ContainsKey(friend.Key))
                {
                    combinedDict.Add(friend.Key, friend.Value);
                }
            }

            return combinedDict;
        }

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
