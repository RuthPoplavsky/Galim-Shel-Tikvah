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
using yes.BLL.BSURFERS;
using yes.GUI.GROUPS;

namespace yes.GUI.SURFERS
{
    public partial class frmAddUpdateSurfers : Form
    {
        Surfers c = new Surfers();
        string state = "add",taalich;

        public frmAddUpdateSurfers()
        {
            InitializeComponent();
            this.state = "add";
            support.FillComboBox(comboBox2, new citysTable().GetDataTable(), "CityNames", "CityNames");
        }
        public frmAddUpdateSurfers(string taalich)
        {
            InitializeComponent();
            this.state = "add";
            support.FillComboBox(comboBox2, new citysTable().GetDataTable(), "CityNames", "CityNames");
            this.taalich = taalich;
        }
        public frmAddUpdateSurfers(Surfers c)
        {
            InitializeComponent();
            this.state = "update";
            support.FillComboBox(comboBox2, new citysTable().GetDataTable(), "CityNames", "CityNames");
            this.c = c;
            textBox9.Text = c.SurfersId;
            textBox5.Text = c.SurfersName;
            comboBox3.SelectedItem = c.Gender;
            textBox2.Text = c.Age.ToString();
            textBox3.Text = c.Cellphone;
            textBox4.Text = c.Telephone;
            textBox7.Text = c.Email;
            textBox6.Text = c.Adress;
            comboBox2.SelectedValue = c.City;
            textBox11.Text = c.Fee.ToString();
            checkBox1.Checked = c.Paid;
        }

        private void frmAddUpdateSurfers_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.SurfersId = textBox9.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox9, ex.Message);
                ok = false;
            }
            try
            {
                c.SurfersName = textBox5.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox5, ex.Message);
                ok = false;
            }
            try
            {
                c.Gender = (string)comboBox3.SelectedItem;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox3, ex.Message);
                ok = false;
            }
            try
            {
                c.Age = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {errorProvider1.SetError(textBox2, ex.Message);
                ok = false;
            }
            try
            {
                c.Cellphone = textBox3.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                ok = false;
            }
            try
            {
                c.Telephone = textBox4.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox4, ex.Message);
                ok = false;
            }
            try
            {
                c.Email = textBox7.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox7, ex.Message);
                ok = false;
            }
            try
            {
                c.Adress = textBox6.Text.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox6, ex.Message);
                ok = false;
            }
            try
            {

                c.City = (string)comboBox2.SelectedValue;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox2, ex.Message);
                ok = false;
            }
            try
            {
                c.Fee = Convert.ToInt32(textBox11.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox11, ex.Message);
                ok = false;
            }
            try
            {
                c.Paid = checkBox1.Checked;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(checkBox1, ex.Message);
                ok = false;
            }
            if (ok)
            {
                if (state == "add")
                {
                    try
                    {
                        var g = c;
                        c.Add();
                        MessageBox.Show("נקלט בהצלחה");
                        if (taalich == "רישום")
                        {
                            frmShibutzBekvutza fsb = new frmShibutzBekvutza("רישום",c);
                            this.Hide();
                            fsb.ShowDialog();
                            this.Show();
                        }
                    }
                    catch (Exception ex)
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("בעיה בעדכון");
                    }
                }
            }
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

