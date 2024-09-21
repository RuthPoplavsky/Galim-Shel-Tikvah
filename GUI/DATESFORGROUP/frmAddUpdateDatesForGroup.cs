using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BDATESFORGROUP;

namespace yes.GUI.DATESFORGROUP
{
    public partial class frmAddUpdateDatesForGroup : Form
    {
        DatesForGroup c = new DatesForGroup();
        string state = "true";

        public frmAddUpdateDatesForGroup()
        {
            InitializeComponent();
            this.state = "add";
            txtNew.Text = new DatesForGroupTable().GetNewKey().ToString();
        }
        public frmAddUpdateDatesForGroup(DatesForGroup c)
        {
            InitializeComponent();
            this.state = "update";
            this.c = c;
            txtNew.Text = c.GroupCode.ToString();
            dateTimePicker1.Text = c.GroupDate.ToString();
           dtpEndingTime.Value = c.StartingTime;
           dtpEndingTime.Value = c.EndingTime;
           checkBox1.Checked = c.TookPlace;

        }
        private void frmAddUpdateDatesForGroup_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.GroupCode = Convert.ToInt32(txtNew.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNew, ex.Message);
                ok = false;
            }
            try
            {
                c.GroupDate = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dateTimePicker1, ex.Message);
                ok = false;
            }
            try
            {
                c.StartingTime = dtpStartingTime.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpStartingTime, ex.Message);
                ok = false;
            }
            try
            {
                c.EndingTime = dtpEndingTime.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpEndingTime, ex.Message);
                ok = false;
            }
            try
            {
                c.TookPlace = checkBox1.Checked;
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

       } 
    }

