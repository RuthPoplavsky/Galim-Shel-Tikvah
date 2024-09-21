using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BGROUPS
{
    class groupsTabel : GeneralTable
    {
        public groupsTabel()
            : base("tblGroups", "codeGroup")
        {
        }

        public DataTable GetAllGroup()
        {

            //האם להשאיר בצורה כזו או SELECT 
           //פשוט?
            return dal.GetQuery(@"SELECT tblGroups.codeGroup, tblGroups.numberOfSurfersInGroup
FROM tblCounslore INNER JOIN (tblGroups INNER JOIN tblCounslersInGroup ON tblGroups.codeGroup = tblCounslersInGroup.codeGroup) ON tblCounslore.codeCoach = tblCounslersInGroup.codeCoach;
");
        }
        public DataTable GetGroupsInMiddle()
        {
            return dal.GetQuery(@"SELECT tblGroups.codeGroup, mi.MinמתוךgroupDate, ma.MaxמתוךgroupDate
FROM (SELECT tblDatesForGroup.groupCode, Min(tblDatesForGroup.groupDate) AS MinמתוךgroupDate FROM tblDatesForGroup GROUP BY tblDatesForGroup.groupCode) as mi INNER JOIN ((SELECT tblDatesForGroup.groupCode, Max(tblDatesForGroup.groupDate) AS MaxמתוךgroupDate
FROM tblDatesForGroup GROUP BY tblDatesForGroup.groupCode) as ma INNER JOIN tblGroups ON ma.groupCode = tblGroups.codeGroup) ON mi.groupCode = tblGroups.codeGroup
WHERE (((mi.MinמתוךgroupDate)<Date()) AND ((ma.MaxמתוךgroupDate)>Date()))");
        }
        public DataTable GetGroupsLoHitchilu()
        {
            return dal.GetQuery("SELECT tblDatesForGroup.groupCode, mi.MinמתוךgroupDate, ma.MaxמתוךgroupDate FROM (SELECT tblDatesForGroup.groupCode, Max(tblDatesForGroup.groupDate) AS MaxמתוךgroupDate FROM tblDatesForGroup GROUP BY tblDatesForGroup.groupCode) as ma INNER JOIN ((SELECT tblDatesForGroup.groupCode, Min(tblDatesForGroup.groupDate) AS MinמתוךgroupDate FROM tblDatesForGroup GROUP BY tblDatesForGroup.groupCode) as mi INNER JOIN tblDatesForGroup ON mi.groupCode = tblDatesForGroup.groupCode) ON ma.groupCode = tblDatesForGroup.groupCode GROUP BY tblDatesForGroup.groupCode,mi.MinמתוךgroupDate, ma.MaxמתוךgroupDate HAVING (((mi.MinמתוךgroupDate)>Date()))");
        }
        public DataTable GetGroupDetails(int codeG)
        {
            return dal.GetQuery("SELECT tblDatesForGroup.groupCode, tblDatesForGroup.groupDate, tblDatesForGroup.startingTime, tblDatesForGroup.endingTime, tblDatesForGroup.tookPlace FROM tblDatesForGroup WHERE (((tblDatesForGroup.groupCode)="+codeG+"))");
        }
        public DataTable statusGroup(int codeG)
        {
            return dal.GetQuery(@"SELECT IIf([tblGroups]![numberOfSurfersInGroup]>[h]![CountמתוךsurfersCode],'open','full') AS stattus FROM tblGroups, (SELECT Count(tblSurfersInGroup.surfersCode) AS CountמתוךsurfersCode FROM tblSurfersInGroup GROUP BY tblSurfersInGroup.groupCode HAVING (((tblSurfersInGroup.groupCode)="+codeG+"))) as h WHERE (((tblGroups.codeGroup)="+codeG+"));");
        }
    }
    
}
