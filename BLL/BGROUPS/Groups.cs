using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BGROUPS
{
    public class Groups : GeneralItem
    {
        public Groups()
            : base(new groupsTabel())
        {
        }
        public Groups(DataRow dr)
            : base(dr, new groupsTabel())
        {
        }
        public Groups(int Id)
            : base(Id, new groupsTabel())
        {
        }
        private int codeGroup;

        public int CodeGroup
        {
            get { return codeGroup; }
            set { codeGroup = value; }
        }

        private int coachCode;

        public int CoachCode
        {
            get { return coachCode; }
            set { coachCode = value; }
        }
        private int numberOfSurfersInGroup;

        public int NumberOfSurfersInGroup
        {
            get { return numberOfSurfersInGroup; }
            set { numberOfSurfersInGroup = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = codeGroup;
            this.codeGroup = Convert.ToInt32(drow["codeGroup"]);
      
            this.numberOfSurfersInGroup = Convert.ToInt32(drow["numberOfSurfersInGroup"]);
        }
        protected override void FillDataRow()
        {
            drow["codeGroup"] = this.codeGroup;
   
            drow["numberOfSurfersInGroup"] = this.numberOfSurfersInGroup;
        }
    }
}


