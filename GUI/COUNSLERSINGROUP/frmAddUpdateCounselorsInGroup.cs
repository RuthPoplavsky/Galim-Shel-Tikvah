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
using yes.BLL.BCOUNSELORS;
using yes.BLL.BCOUNSLERSINGROUP;
using yes.BLL.BGROUPS;
using yes.BLL.BSURFERS;
using yes.BLL.BSURFERSINGROUP;

namespace yes.GUI.COUNSLERSINGROUP
{
    public partial class frmAddUpdateCounselorsInGroup : Form
    {
    
        CounslersInGroup c = new CounslersInGroup();
        string state = "true";

        public frmAddUpdateCounselorsInGroup()
        {
            InitializeComponent();
            this.state = "add";
            support.FillComboBox(cmbGropKode, new groupsTabel().GetDataTable(), "codeGroup", "codeGroup");
            support.FillComboBox(cmbCounselorsCode, new counselorsTable().GetDataTable(), "codeCoach", "nameCoach");
        }
        public frmAddUpdateCounselorsInGroup(CounslersInGroup c)
        {
            InitializeComponent();
            this.state = "update";
            support.FillComboBox(cmbGropKode, new groupsTabel().GetDataTable(), "codeGroup", "codeGroup");
            support.FillComboBox(cmbCounselorsCode, new counselorsTable().GetDataTable(), "codeCoach", "nameCoach");
            this.c = c;
           
        }
      
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.CodeGroup = (int)cmbGropKode.SelectedValue;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbGropKode, ex.Message);
                ok = false;
            }
            try
            {
                var j = cmbCounselorsCode.SelectedValue;
                c.CodeCoach =Convert.ToInt32( cmbCounselorsCode.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbCounselorsCode, ex.Message);
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
