using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeneSzam_NyilvanTarto.DataAccess
{
    interface IUserNameRepository
    {
        string getUserNameById(int id);
    }
}
