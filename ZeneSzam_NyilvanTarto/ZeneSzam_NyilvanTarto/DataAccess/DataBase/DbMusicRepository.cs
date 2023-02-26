using System;
using System.Collections.Generic;
using System.Text;

namespace ZeneSzam_NyilvanTarto.DataAccess.DataBase
{
    // A zenék adatainak adatbázis alapú perzisztálására szolgál.

    class DbMusicRepository : IMusicRepository
    {
        public Music getMusic(string title)
        {
            List<string> authors = new List<string>();
            authors.Add("The Weeknd");
            authors.Add("Ariana Grande");
            //...
            return new Music("sdd", authors);
        }

        public string getMusicTitle(Music music)
        {
            //...
            return "Blinding Lights";
        }

        public List<Music> ListAll()
        {
            //...
            return new List<Music>();
        }
    }
}
