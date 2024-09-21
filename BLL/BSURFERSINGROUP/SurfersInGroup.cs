using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;


namespace yes.BLL.BSURFERSINGROUP
{
    public class SurfersInGroup : GeneralItem
    {
                public SurfersInGroup()
            : base(new surfersInGroupTable())
        {
        }
        public SurfersInGroup(DataRow dr)
                    : base(dr, new surfersInGroupTable())
        {
        }
        public SurfersInGroup(string Id)
            : base(Convert.ToInt32( Id), new surfersInGroupTable())
        {
        }
        private int groupCode;

        public int GroupCode
        {
            get { return groupCode; }
            set { groupCode = value; }
        }
        private string surfersCode;

        public string SurfersCode
        {
            get { return surfersCode; }
            set { surfersCode = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = groupCode;
            this.groupCode = Convert.ToInt32(drow["groupCode"]);
            this.surfersCode =(drow["surfersCode"]).ToString();
        }
        protected override void FillDataRow()
        {
            drow["groupCode"] = this.groupCode;
            drow["surfersCode"] = this.surfersCode;
        }
    }
}
