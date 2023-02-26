using System;
using System.Collections.Generic;
using System.Text;

namespace ZeneSzam_NyilvanTarto.DataAccess
{
    // MusicRepository interfész
    interface IMusicRepository
    {
       Music getMusic(string title);
        string getMusicTitle(Music music);
        List<Music> ListAll();
    }
}
