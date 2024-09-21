using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BCOUNSLERSINGROUP
{
    class CounslersInGroupTable : GeneralTable
    {
         private string key2;
         public CounslersInGroupTable()
             : base("tblCounslersInGroup", "codeGroup")
        {
            this.key2 = "codeCoach";
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
        public DataTable GetCounslersPerGroup(int codeG)
        {

            return dal.GetQuery("SELECT tblCounslersInGroup.codeGroup, tblCounslersInGroup.codeCoach, tblCounslore.nameCoach FROM tblCounslore INNER JOIN tblCounslersInGroup ON tblCounslore.codeCoach = tblCounslersInGroup.codeCoach WHERE (((tblCounslersInGroup.codeGroup)="+codeG+"))");
        }
    }
}
