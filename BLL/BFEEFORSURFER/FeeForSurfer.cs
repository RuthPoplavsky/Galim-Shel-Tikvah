using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BFEEFORSURFER
{
     public class FeeForSurfer : GeneralItem
    {
          public FeeForSurfer()
            : base(new FeeForSurferTable())
        {
        }
        public FeeForSurfer(DataRow dr)
              : base(dr, new FeeForSurferTable())
        {
        }
        public FeeForSurfer(string Id)
            : base(Convert.ToInt32(Id), new FeeForSurferTable())
        {
        }
        private int feeCode;

        public int FeeCode
        {
            get { return feeCode; }
            set { feeCode = value; }
        }
        private string surfersCode;

        public string SurfersCode
        {
            get { return surfersCode; }
            set { surfersCode = value; }
        }
        private int feeSum;

        public int Feesum
        {
            get { return feeSum; }
            set { feeSum = value; }
        }
        private DateTime feeDate;

        public DateTime FeeDate
        {
            get { return feeDate; }
            set { feeDate = value; }
        }
        private String modeOfPayment;

        public String ModeOfPayment
        {
            get { return modeOfPayment; }
            set { modeOfPayment = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = feeCode;
            this.feeCode = Convert.ToInt32(drow["feeCode"]);
            this.surfersCode = drow["surfersCode"].ToString();
            this.feeSum = Convert.ToInt32(drow["feeSum"]);
            this.feeDate = Convert.ToDateTime(drow["feeDate"]);
            this.modeOfPayment = drow["modeOfPayment"].ToString();
        }
        protected override void FillDataRow()
        {
            drow["feeCode"] = this.feeCode;
            drow["surfersCode"] = this.surfersCode;
            drow["feeSum"] = this.feeSum;
            drow["feeDate"] = this.feeDate;
            drow["modeOfPayment"] = this.modeOfPayment;
        }
        

    }
}
