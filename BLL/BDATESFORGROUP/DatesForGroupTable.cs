using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BDATESFORGROUP
{
    class DatesForGroupTable : GeneralTable
    {
        private string key2;
        public DatesForGroupTable()
            : base("tblDatesForGroup", "groupCode")
        {
            this.key2 = "groupDate";
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
     public   DataTable getdatesForGroup(int codeg)
        {
            return dal.GetQuery(@"SELECT tblDatesForGroup.groupCode, tblDatesForGroup.groupDate
FROM tblDatesForGroup
WHERE (((tblDatesForGroup.groupCode)="+codeg+"))");
        }
    }
}
