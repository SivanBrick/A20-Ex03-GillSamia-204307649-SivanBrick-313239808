using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    class PhotoIterator 
    {
        private FacebookObjectCollection<Album> m_UserAlbums;

        public PhotoIterator(FacebookObjectCollection<Album> i_UserAlbums)
        {
            this.m_UserAlbums = i_UserAlbums;
        }


        public IEnumerator<Photo> GetEnumerator(int i_MaxItemCount)
        {
            int itemCounter = 0;
            int max = i_MaxItemCount;
            foreach (Album album in this.m_UserAlbums)
            {
                foreach (Photo photo in album.Photos)
                {
                    yield return photo;

                    itemCounter++;
                    if (itemCounter == max)
                    {
                        break;
                    }
                }

                if (itemCounter == max)
                {
                    break;
                }
            }
        }
    }
}
