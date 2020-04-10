using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class Artists : CollectionBase
    {
        private static Artists instance;
        public void Add(Artist artist)
        {
            List.Add(artist);
        }

        private Artists()
        {

        }

        public static Artists Instance
        {
            get
            {
                if (instance == null)
                    instance = new Artists();

                return instance;
            }
        }

        public Artists this[int ArtistIndex]
        {
            get
            {
                return (Artists)List[ArtistIndex];
            }
            set
            {
                List[ArtistIndex] = value;
            }
        }
    }
}
