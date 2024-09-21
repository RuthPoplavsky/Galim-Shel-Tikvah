using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BCITYS
{
  public class City:GeneralItem
    {
        
        public City()
            : base(new citysTable())
        {
        }
        public City(DataRow dr)
            : base(dr, new citysTable())
        {
        }
        public City(string Id)
            : base(Id, new citysTable())
        {
        }
        
        public string cityNames;

        public string CityNames
        {
            get { return cityNames; }
            set { cityNames = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = CityNames;
            this.CityNames = (drow["cityNames"]).ToString();

        }


        protected override void FillDataRow()
        {
            drow["cityNames"] = this.CityNames;
        }
    }
}
