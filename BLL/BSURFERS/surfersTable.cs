using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;


namespace yes.BLL.BSURFERS
{
    class surfersTable : GeneralTable
    {
        public surfersTable()
            : base("tblSurfers", "surfersId")
        {
        }
    }
}
