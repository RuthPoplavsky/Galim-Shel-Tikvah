using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BCOUNSELORS
{
   public class counselorsTable : GeneralTable
    {
        public counselorsTable()
            : base("tblCounslore", "codeCoach")
        {
        }
        public DataTable GetDoch(int code)
        {
            return dal.GetQuery("SELECT tblSurfers.surfersId, tblSurfers.surfersName, tblSurfers.gender, tblSurfers.age, tblSurfers.cellphone, tblSurfers.telephone, tblSurfers.email, tblSurfers.adress, tblSurfers.city, tblSurfers.fee, tblSurfersInGroup.groupCode, tblGroups.numberOfSurfersInGroup, tblCounslersInGroup.codeCoach, tblCounslore.nameCoach FROM tblSurfers INNER JOIN ((tblGroups INNER JOIN (tblCounslore INNER JOIN tblCounslersInGroup ON tblCounslore.codeCoach = tblCounslersInGroup.codeCoach) ON tblGroups.codeGroup = tblCounslersInGroup.codeGroup) INNER JOIN tblSurfersInGroup ON tblGroups.codeGroup = tblSurfersInGroup.groupCode) ON tblSurfers.surfersId = tblSurfersInGroup.surfersCode WHERE (((tblCounslersInGroup.codeCoach)=" + code + "));");
        }
    }
}
