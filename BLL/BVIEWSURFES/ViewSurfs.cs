using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BVIEWSURFES
{
    public  class ViewSurfs : GeneralItem
    {
                public ViewSurfs()
            : base(new ViewSurfsTable())
        {
        }
        public ViewSurfs(DataRow dr)
                    : base(dr, new ViewSurfsTable())
        {
        }
        public ViewSurfs(string Id)
            : base(Id, new ViewSurfsTable())
        {
        }
        private int codeAmounOfCodes;

        public int CodeAmounOfCodes
        {
            get { return codeAmounOfCodes; }
            set { codeAmounOfCodes = value; }
        }
        private int codeOfSurfer;

        public int CodeOfSurfer
        {
            get { return codeOfSurfer; }
            set { codeOfSurfer = value; }
        }
        private int numberOfSurfs;

        public int NumberOfSurfs
        {
            get { return numberOfSurfs; }
            set { numberOfSurfs = value; }
        }
        private int waveHeight;

        public int WaveHeight
        {
            get { return waveHeight; }
            set { waveHeight = value; }
        }
        private DateTime dated;

        public DateTime Dated
        {
            get { return dated; }
            set { dated = value; }
        }
        private int groupCode;

        public int GroupCode
        {
            get { return groupCode; }
            set { groupCode = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = codeAmounOfCodes;
            this.codeAmounOfCodes = Convert.ToInt32(drow["codeAmounOfCodes"]);
            this.codeOfSurfer = Convert.ToInt32(drow["codeOfSurfer"]);
            this.numberOfSurfs = Convert.ToInt32(drow["numberOfSurfs"]);
            this.waveHeight = Convert.ToInt32(drow["waveHeight"]);
            this.dated = Convert.ToDateTime(drow["dated"]);
            this.groupCode = Convert.ToInt32(drow["groupCode"]);
        }
        protected override void FillDataRow()
        {
            drow["codeAmounOfCodes"] = this.codeAmounOfCodes;
            drow["codeOfSurfer"] = this.codeOfSurfer;
            drow["numberOfSurfs"] = this.numberOfSurfs;
            drow["waveHeight"] = this.waveHeight;
            drow["dated"] = this.dated;
            drow["groupCode"] = this.groupCode;
        }

        public int codeAmounOfSurfes { get; set; }
    }
}
