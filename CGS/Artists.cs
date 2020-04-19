using System.Collections;

namespace CGS
{
    public class Artists : CollectionBase
    {
        private static Artists _instance;
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
                if (_instance == null)
                    _instance = new Artists();

                return _instance;
            }
        }
        public Artists this[int artistIndex]
        {
            get => (Artists)List[artistIndex];
            set => List[artistIndex] = value;
        }
    }
}
