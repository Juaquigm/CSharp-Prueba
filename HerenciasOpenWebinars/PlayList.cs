using System;
using System.Collections;
using System.Collections.Generic;

namespace HerenciasOpenWebinars
{
    public class PlayList<T> // Va a afectar generico
    {
        ArrayList list = new ArrayList();
        List<T> mediaList = new List<T>();

        public void Add(T media)
        {
            list.Add(media);
        }

        public void PlayAll()
        {
            foreach(T media in list)
            {
                Console.WriteLine(media);
            }
        }

        public void Preview()
        {
            if (list.Count > 0)
            {
                // Esto nos hace con el ArrayList T media = (T)list[0];
                // Con las listas no nos hace falta
                Console.WriteLine(mediaList[0]);
            }
        }
    }
}
