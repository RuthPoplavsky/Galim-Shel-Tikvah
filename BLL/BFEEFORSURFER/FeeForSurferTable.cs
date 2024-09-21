using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;


namespace yes.BLL.BFEEFORSURFER
{
    class FeeForSurferTable : GeneralTable
    {
        public FeeForSurferTable()
            : base("tblFeeForSurfer", "feeCode")
        {
        }
        public DataTable GetDoch(string tz)
        {
            return dal.GetQuery("SELECT tblFeeForSurfer.feeCode, tblSurfers.surfersName, tblFeeForSurfer.feesum, tblFeeForSurfer.feeDate, tblFeeForSurfer.modeOfPayment, tblFeeForSurfer.surfersCode FROM tblSurfers INNER JOIN tblFeeForSurfer ON tblSurfers.surfersId = tblFeeForSurfer.surfersCode WHERE (((tblFeeForSurfer.surfersCode)='" + tz + "')) ORDER BY tblFeeForSurfer.feeDate;");
        }
    }
}
