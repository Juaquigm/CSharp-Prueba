using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HerenciasOpenWebinars
{
    public class PlayList // Va a afectar generico
    {
        ArrayList list = new ArrayList();
        List<Song> mediaList = new List<Song>();

        public void Add(Song media)
        {
            mediaList.Add(media);
        }

        public void PlayAll()
        {
            foreach(Song media in list)
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

        public List<Song> SearchForCategory(string category)
        {
            var songs = mediaList.Where(x => x.Category == category);
            /*
            List<Song> songs = new List<Song>();

            foreach(Song song in mediaList)
            {
                if(song.Category == category)
                {
                    songs.Add(song);
                }
            }
            */
            return songs.ToList();
        }

        public List<Song> SearchForTitle(string title)
        {
            var songs = mediaList.Where(x => x.Title == title);
            /*
            List<Song> songs = new List<Song>();

            foreach (Song song in mediaList)
            {
                if (song.Title.Contains(title))
                {
                    songs.Add(song);
                }
            }
            */
            return songs.ToList();
        }

        public List<String> GimmeTitlesFromSongs()
        {
            var titles = mediaList.Select(x => x.Title);
            /*
            mediaList.Select(x => new Tuple<string, string>(x.Title, x.Category));
            List<string> titles = new List<string>();
            foreach(Song song in mediaList)
            {
                titles.Add(song.Title);
            }
            */
            return titles.ToList();
        }

        public List<String> GimmeNamesOfArtist()
        {
            var namesOfArtists = mediaList.SelectMany(x => x.Artist)
                                          .Select(x => x.Name);

            return namesOfArtists.ToList();
        }

        public bool HaveATitle(string title)
        {
            return mediaList.Any(x => x.Title == title);
        }

        public Song GetFirstSongWithLess1Minute()
        {
            var song = mediaList.FirstOrDefault(x => x.Seconds < 60);

            return song;
        }

        public Song GetLastSongWithLess1Minute()
        {
            var song = mediaList.LastOrDefault(x => x.Seconds < 60);

            return song;
        }

        public List<Song> Top10()
        {
            return mediaList.OrderBy(x => x.Visits)
                            .Take(10).ToList();
        }

        public List<Song> Bottom10()
        {
            return mediaList.OrderByDescending(x => x.Visits)
                            .Take(10).ToList();
        }

        public void GroupFromCategory()
        {
            mediaList.GroupBy(x => x.Category)
                      .ToDictionary(x => x.Key);
        }

        public List<Media> ToConvertMedia()
        {
            return mediaList.OfType<Media>().ToList();
        }
    }
}
