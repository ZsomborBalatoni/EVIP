using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ZeneSzam_NyilvanTarto.DataAccess.Memory
{
    //A zenék adatainak memória alapú perzisztálására szolgál.

    class MemMusicRepository : IMusicRepository
    {
        public List<Music> allMusics;

        public Music getMusic(string title)
        {
            for (int i = 0; i < allMusics.Count; i++)
            {
                if (allMusics[i].Title == title)
                {
                    return allMusics[i];
                }
            }
            throw new Exception("Nincs ilyen zene cím!");
        }

        public string getMusicTitle(Music music)
        {
            for (int i = 0; i < allMusics.Count; i++)
            {
                if (allMusics[i] == music)
                {
                    return allMusics[i].Title;
                }
            }
            throw new Exception("Nincs ilyen zene!");
        }

        public List<Music> ListAll()
        {
            return allMusics;
        }
    }
}
