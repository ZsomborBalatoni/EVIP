using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeneSzam_NyilvanTarto.DataAccess;
using ZeneSzam_NyilvanTarto.DataAccess.Memory;

namespace ZeneSzam_NyilvanTarto.Logic
{
    class MusicService
    {
        IMusicRepository musicRepository;
        IUserNameRepository userNameRepository;

        private List<Music> allMusics = new List<Music>();

        public MusicService(IMusicRepository musicRepository, IUserNameRepository userNameRepository)
        {
            this.musicRepository = musicRepository;
            this.userNameRepository = userNameRepository;
            //allMusics = musicRepository.ListAll();

        }

        public List<Music> ListAll()
        {
            return allMusics;
        }

        public void AddNewMusic(Music music)
        {
            if (music.Title == null || music.Title.Length <= 2)
            {
                throw new Exception("A zenecím túl rövid, vagy nem lett megadva!");
            }
            else
            {
                if (music.Authors == null || music.Authors.Count < 1)
                {
                    throw new Exception("Legalább 1 szerzőt meg kell adni!");
                }
                else
                {
                    for (int i = 0; i < music.Authors.Count; i++)
                    {
                        if (music.Authors[i] == null || music.Authors[i].Length <=3)
                        {
                            throw new Exception("A szerző(k) neve(i) túl rövid, vagy nem lett megadva!");
                        }
                    }
                }
            }
            allMusics.Add(music);
            Console.WriteLine($"{music.Title}, Létrehozás, { getUserName()}");
        }

        public void RemoveAuthorFromMusic(string author)
        {
            int removedAuthors = 0;

            for (int i = 0; i < allMusics.Count; i++)
            {
                for (int j = 0; j < allMusics[i].Authors.Count; j++)
                {
                    if (allMusics[i].Authors[j] == author)
                    {
                        allMusics[i].Authors.RemoveAt(j);
                        removedAuthors += 1;
                    }
                }
            }

            if (removedAuthors == 0)
            {
                throw new Exception("A rendszer nem talált ilyen nevű zeneszerzőt!");
            }
        }

        public int getUserNameId()
        {
            return CurrentUser.Instance.getUserId();
        }

        public string getUserName()
        {
            return userNameRepository.getUserNameById(getUserNameId());
        }
    }
}
