using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL;
using yes.BLL.BCITYS;
using yes.BLL.BCOUNSELORS;
using yes.BLL.classes;




 namespace yes.GUI.COUNSELORS
{
    public partial class frmAddUpdateCounselors : Form
    {
        Counselors color=new Counselors();
        string state = "true";

        public frmAddUpdateCounselors()
        {
            InitializeComponent();
            this.state = "add";
            support.FillComboBox(comboBox2, new citysTable().GetDataTable(), "cityNames", "cityNames");
            txtNew.Text = new counselorsTable().GetNewKey().ToString();
        }
      
        public frmAddUpdateCounselors(Counselors c)
        {
            
            InitializeComponent();
            this.state = "update";
            support.FillComboBox(comboBox2, new citysTable().GetDataTable(), "cityNames", "cityNames");
            this.color = c;
            txtNew.Text = c.CodeCoach.ToString();
            textBox5.Text = c.NameCoach;
            comboBox1.SelectedItem = c.Gender;
            textBox2.Text = c.Age.ToString();
            textBox3.Text = c.YearsOfExperience.ToString();
            textBox4.Text = c.CellPhone;
            textBox7.Text = c.EMail;
            textBox6.Text = c.Address;
            comboBox2.Text = c.City;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                color.CodeCoach = Convert.ToInt32(txtNew.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNew, ex.Message);
                ok = false;
            }
            try
            {
                color.NameCoach = textBox5.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox5, ex.Message);
                ok = false;
            }
            try
            {
                color.Gender = (string)comboBox1.SelectedItem;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox1, ex.Message);
                ok = false;
            }
            try
            {
                color.Age = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                ok = false;
            }
            try
            {
                color.YearsOfExperience = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                ok = false;
            }
            try
            {
                color.CellPhone = textBox4.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox4, ex.Message);
                ok = false;
            }
            try
            {
               color.EMail = textBox7.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox7, ex.Message);
                ok = false;
            }
            try
            {
                color.Address = textBox6.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox6, ex.Message);
                ok = false;
            }
            try
            {
                color.City = (string)comboBox2.SelectedValue;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox2, ex.Message);
                ok = false;
            }
            if (ok)
            {
                if (state == "add")
                {
                    try
                    {
                        var t = color;
                        color.Add();
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
                        color.Update();
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

        private void frmAddUpdateCounselors_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}