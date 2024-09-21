using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BCITYS
{
    class citysTable:GeneralTable
    
    {
        public citysTable()
            : base("tblCitys", "cityNames")
        {
        }
    }
}
