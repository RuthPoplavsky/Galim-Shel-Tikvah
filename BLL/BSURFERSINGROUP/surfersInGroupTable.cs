using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BSURFERSINGROUP
{
    class surfersInGroupTable : GeneralTable
    {
        private string key2;
        public surfersInGroupTable()
            : base("tblSurfersInGroup", "groupCode")
        {
            this.key2 = "surfersCode";
        }
        public string GetPrimaryKey2()
        {
            return this.key2;
        }
        public DataRow Find(object valueKey1, object valueKey2)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[base.key].Equals(valueKey1) && row[this.key2].Equals(valueKey2))
                    return row;
            }
            return null;
        }
    }
}
