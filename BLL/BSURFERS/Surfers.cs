using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.BLL.classes;

namespace yes.BLL.BSURFERS
{
    public class Surfers : GeneralItem
    {
                public Surfers()
            : base(new surfersTable())
        {
        }
        public Surfers(DataRow dr)
                    : base(dr, new surfersTable())
        {
        }
        public Surfers(string Id)
            : base(Id, new surfersTable())
        {
        }
        private string surfersId;

        public string SurfersId
        {
            get { return surfersId; }
            set { surfersId = value; }
        }
        private string surfersName;

        public string SurfersName
        {
            get { return surfersName; }
            set { surfersName = value; }
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
        private string cellphone;

        public string Cellphone
        {
            get { return cellphone; }
            set { cellphone = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private int fee;

        public int Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        private bool paid;

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }
        protected override void FillFields()
        {
            this.SurfersId = drow["surfersId"].ToString();
             this.keyValue = surfersName;
            this.surfersName = drow["surfersName"].ToString();
            this.gender = drow["gender"].ToString();
            this.age = Convert.ToInt32(drow["age"]);
            this.cellphone = drow["cellphone"].ToString();
            this.telephone = drow["telephone"].ToString();
            this.email = drow["email"].ToString();
            this.adress = drow["adress"].ToString();
            this.city = drow["city"].ToString();
            this.fee = Convert.ToInt32(drow["fee"]);
            this.paid = Convert.ToBoolean(drow["paid"]);
        }
        protected override void FillDataRow()
        {
            drow["surfersId"] = this.surfersId;
            drow["surfersName"] = this.surfersName;
            drow["gender"] = this.gender;
            drow["age"] = this.age;
            drow["cellphone"] = this.cellphone;
            drow["telephone"] = this.telephone;
            drow["email"] = this.email;
            drow["adress"] = this.adress;
            drow["city"] = this.city;
            drow["fee"]=this.fee;
            drow["paid"] = this.paid;
        }
    }
}
