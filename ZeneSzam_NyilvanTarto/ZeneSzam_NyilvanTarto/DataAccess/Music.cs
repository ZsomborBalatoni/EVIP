using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeneSzam_NyilvanTarto.DataAccess
{
    class Music
    {
        public string Title { get; }
        public List<string> Authors { get; }

        public Music(string title, List<string> authors)
        {
            this.Title = title;
            this.Authors = authors;
        }
    }
}
