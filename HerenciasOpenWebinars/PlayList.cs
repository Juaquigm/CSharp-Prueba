using System;
namespace HerenciasOpenWebinars
{
    public class PlayList<T> // Va a afectar generico
    {
        T[] medialist = new T[] { };

        public void Add(T media)
        {

        }

        public void PlayAll()
        {
            foreach(T media in medialist)
            {
                Console.WriteLine(media);
            }
        }
    }
}
