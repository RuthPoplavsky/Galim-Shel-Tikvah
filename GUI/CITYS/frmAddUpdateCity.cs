using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BCITYS;

namespace yes.GUI.CITYS
{
    public partial class frmAddUpdateCity : Form
    {
        City c = new City();
        string state = "true";

        public frmAddUpdateCity()
        {
            InitializeComponent();
            this.state = "add";

        }
        public frmAddUpdateCity(City c)
        {
            InitializeComponent();
            this.state = "update";
            this.c = c;
            txtCityName.Text = c.CityNames;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.cityNames = txtCityName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCityName, ex.Message);
                ok = false;
            }
            if (ok)
            {
                if (state == "add")
                {
                    try
                    {
                        c.Add();
                        MessageBox.Show("נקלט בהצלחה");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("בעיה בקליטה");
                    }
                }
                else
                {
                    try
                    {
                        c.Update();
                        MessageBox.Show("עודכן בהצלחה");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("בעיה בעדכון");
                    }
                }
            }
            this.Close();
        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       
   
