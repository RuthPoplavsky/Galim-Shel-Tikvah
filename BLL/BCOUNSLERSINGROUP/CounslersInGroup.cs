using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BCOUNSLERSINGROUP
{
   public class CounslersInGroup : GeneralItem
    {
            public CounslersInGroup()
            : base(new CounslersInGroupTable())
        {
        }
        public CounslersInGroup(DataRow dr)
                    : base(dr, new CounslersInGroupTable())
        {
        }
        public CounslersInGroup(string Id)
            : base(Convert.ToInt32(Id), new CounslersInGroupTable())
        {
        }
        private int codeGroup;
        public int CodeGroup
        {
            get { return codeGroup; }
            set { codeGroup = value; }
        }
        private int codeCoach;

        public int CodeCoach
        {
            get { return codeCoach; }
            set { codeCoach = value; }
        }
        protected override void FillFields()
        {
            this.codeGroup = codeGroup;
            this.codeGroup = Convert.ToInt32(drow["codeGroup"]);
            this.codeCoach = Convert.ToInt32(drow["codeCoach"]);
        }
        protected override void FillDataRow()
        {
            drow["codeGroup"] = this.codeGroup;
            drow["codeCoach"] = this.codeCoach;
        }
    }
 
}
