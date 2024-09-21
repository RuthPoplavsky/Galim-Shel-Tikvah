using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BDATESFORGROUP
{
    public class DatesForGroup : GeneralItem
    {
          public DatesForGroup() : base(new DatesForGroupTable())
        {
        }
        public DatesForGroup(DataRow dr)
              : base(dr, new DatesForGroupTable())
        {
        }
        public DatesForGroup(int gcode,DateTime gd)
            : base(new DatesForGroupTable())
        {
            drow = new DatesForGroupTable().Find(gcode,gd);
            FillFields();
        }
        private int groupCode;

        public int GroupCode
        {
            get { return groupCode; }
            set { groupCode = value; }
        }
        private DateTime groupDate;

        public DateTime GroupDate
        {
            get { return groupDate; }
            set { groupDate = value; }
        }
        private DateTime startingTime;

        public DateTime StartingTime
        {
            get { return startingTime; }
            set { startingTime = value; }
        }
        private DateTime endingTime;

        public DateTime EndingTime
        {
            get { return endingTime; }
            set { endingTime = value; }
        }
        private bool tookPlace;

        public bool TookPlace
        {
            get { return tookPlace; }
            set { tookPlace = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = groupCode;
            this.groupCode = Convert.ToInt32(drow["groupCode"]);
            this.groupDate = Convert.ToDateTime(drow["groupDate"]);
            this.startingTime = Convert.ToDateTime(drow["startingTime"]);
            this.endingTime = Convert.ToDateTime(drow["endingTime"]);
            this.tookPlace = Convert.ToBoolean(drow["tookPlace"]);
        }
        protected override void FillDataRow()
        {
            drow["groupCode"] = this.groupCode;
            drow["groupDate"] = this.groupDate;
            drow["startingTime"] = this.startingTime;
            drow["endingTime"] = this.endingTime;
            drow["tookPlace"] = this.tookPlace;
        }
    }
}
