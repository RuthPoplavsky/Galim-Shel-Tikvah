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
using yes.BLL.BGROUPS;
using yes.BLL.BSURFERS;
using yes.BLL.BSURFERSINGROUP;

namespace yes.GUI.SURFERSINGROUP
{
    public partial class frmAddUpdateSurfersInGroup : Form
    {
        SurfersInGroup c = new SurfersInGroup();
        string state = "true";

        public frmAddUpdateSurfersInGroup()
        {
            InitializeComponent();
            this.state = "add";
            support.FillComboBox(cmbGropKode, new groupsTabel().GetDataTable(), "codeGroup", "codeGroup");
            support.FillComboBox(cmbSurfersCode, new surfersTable().GetDataTable(), "surfersId", "surfersName");
        }
        public frmAddUpdateSurfersInGroup(SurfersInGroup c)
        {
            InitializeComponent();
            this.state = "update";
            support.FillComboBox(cmbGropKode, new groupsTabel().GetDataTable(), "codeGroup", "codeGroup");
            support.FillComboBox(cmbSurfersCode, new surfersTable().GetDataTable(), "surfersId", "surfersName");
            this.c = c;
            cmbGropKode.SelectedValue = c.GroupCode;
            cmbSurfersCode.SelectedValue = c.SurfersCode;
        }
      

        private void btnOK_Click(object sender, EventArgs e)
        {
             bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.GroupCode =(int)cmbGropKode.SelectedValue;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbGropKode, ex.Message);
                ok = false;
            }
             try
            {
                var j = cmbSurfersCode.SelectedValue;
                c.SurfersCode = cmbSurfersCode.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbSurfersCode, ex.Message);
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

