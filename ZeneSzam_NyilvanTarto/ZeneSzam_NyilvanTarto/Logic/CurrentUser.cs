using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeneSzam_NyilvanTarto.Logic
{
    class CurrentUser
    {
        // Tárolja az egyetlen példányt, kezdetben null.
        private static CurrentUser instance = new CurrentUser();

        // Glogális hozzáférést biztosító statikus művelet
        public static CurrentUser Instance
        {
            get
            {
                return instance;
            }
        }

        // Védett konstruktor
        protected CurrentUser() {}

        public int getUserId()
        {
            return 1;
        }
    }
}
