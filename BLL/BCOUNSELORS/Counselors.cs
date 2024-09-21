using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BCOUNSELORS
{
        public class Counselors : GeneralItem
    {
         public Counselors()
            : base(new counselorsTable())
        {
        }
        public Counselors(DataRow dr)
             : base(dr, new counselorsTable())
        {
        }
        public Counselors(int Id)
            : base(Id, new counselorsTable())
        {
        }
        private int codeCoach;

        public int CodeCoach
        {
            get { return codeCoach; }
            set { codeCoach = value; }
        }
        private string nameCoach;

        public string NameCoach
        {
            get { return nameCoach; }
            set { nameCoach = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int yearsOfExperience;

        public int YearsOfExperience
        {
            get { return yearsOfExperience; }
            set { yearsOfExperience = value; }
        }
        private string cellPhone;

        public string CellPhone
        {
            get { return cellPhone; }
            set { cellPhone = value; }
        }
        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        protected override void FillFields()
        {
            this.keyValue = codeCoach;
            this.codeCoach = Convert.ToInt32(drow["codeCoach"]);
            this.nameCoach = drow["nameCoach"].ToString();
            this.gender = drow["gender"].ToString();
            this.age = Convert.ToInt32(drow["age"]);
            this.yearsOfExperience = Convert.ToInt32(drow["yearsOfExperience"]);
            this.cellPhone = drow["cellPhone"].ToString();
            this.eMail = drow["eMail"].ToString();
            this.address = drow["address"].ToString();
            this.city = drow["city"].ToString();
        }
        protected override void FillDataRow()
        {
            drow["codeCoach"] = this.codeCoach;
            drow["nameCoach"] = this.nameCoach;
            drow["gender"] = this.gender;
            drow["age"] = this.age;
            drow["yearsOfExperience"] = this.yearsOfExperience;
            drow["cellPhone"] = this.cellPhone;
            drow["eMail"] = this.eMail;
            drow["address"] = this.address;
            drow["city"] = this.city;
        }

    }
}
