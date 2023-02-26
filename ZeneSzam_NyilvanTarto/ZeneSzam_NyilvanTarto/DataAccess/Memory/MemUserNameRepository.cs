using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeneSzam_NyilvanTarto.DataAccess.Memory
{
    class MemUserNameRepository : IUserNameRepository
    {
        public string getUserNameById(int id)
        {
            return "Gipsz Jakab";
        }
    }
}
