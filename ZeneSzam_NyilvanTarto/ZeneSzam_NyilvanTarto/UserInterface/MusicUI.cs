using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeneSzam_NyilvanTarto.DataAccess;
using ZeneSzam_NyilvanTarto.DataAccess.Memory;
using ZeneSzam_NyilvanTarto.Logic;

namespace ZeneSzam_NyilvanTarto.UserInterface
{
    class MusicUI
    {
        private MusicService musicService;
       public MusicUI()
        {
            musicService = new MusicService(new MemMusicRepository(), new MemUserNameRepository());
        }

        public void Program()
        {
            Console.WriteLine("Zenék hozzáadása:");
            MusicAdd();
            Console.WriteLine("Zeneszerző eltávolítása:");
            RemoveAuthor();

            string userName = Console.ReadLine();



        }

        public void MusicAdd()
        {
            List<string> authors1 = new List<string>();
            authors1.Add("The Kid LAROI");
            authors1.Add("Justin Biber");
            Music zene1 = new Music("Stay", authors1);
            musicService.AddNewMusic(zene1);
            Console.WriteLine($"{musicService.ListAll()}");

            List<string> authors2 = new List<string>();
            authors2.Add("Mariah Carey");
            Music zene2 = new Music("All I Want For Christmas Is You", authors2);
            musicService.AddNewMusic(zene2);
            Console.WriteLine($"{musicService.ListAll()}");

            List<string> authors3 = new List<string>();
            authors3.Add("Ed Sheeran");
            Music zene3 = new Music("Shivers", authors3);
            musicService.AddNewMusic(zene3);
            Console.WriteLine($"{musicService.ListAll()}");

            List<string> authors4 = new List<string>();
            authors4.Add("Doja Cat");
            Music zene4 = new Music("Need To Know", authors4);
            musicService.AddNewMusic(zene4);
            Console.WriteLine($"{musicService.ListAll()}");

            List<string> authors5 = new List<string>();
            authors5.Add("Elton John");
            authors5.Add("Dua Lipa");
            Music zene5 = new Music("", authors5);
            //musicService.AddNewMusic(zene5);
            Console.WriteLine($"{musicService.ListAll()}");
        }

        public void RemoveAuthor()
        {
            musicService.RemoveAuthorFromMusic("Justin Biber");
            Console.WriteLine($"{musicService.ListAll()}");
        }
        
    }
}
