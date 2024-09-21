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
using yes.BLL.BFEEFORSURFER;
using yes.BLL.BSURFERS;

namespace yes.GUI.FEEFORSURFER
{
    public partial class frmAddUpdateFeeForSurfer : Form
    {
        FeeForSurfer c = new FeeForSurfer();
        string state = "true";

        public frmAddUpdateFeeForSurfer()
        {
            InitializeComponent();
            this.state = "add";
            support.FillComboBox(cmbsurfersCode, new surfersTable().GetDataTable(), "surfersId", "surfersName");
            txtNew.Text = new FeeForSurferTable().GetNewKey().ToString();
        }
        public frmAddUpdateFeeForSurfer(FeeForSurfer c)
        {
            InitializeComponent();
            this.state = "update";
            support.FillComboBox(cmbsurfersCode, new surfersTable().GetDataTable(), "surfersId", "surfersName");
            this.c = c;
            txtNew.Text = c.FeeCode.ToString();
            cmbsurfersCode.SelectedValue = c.SurfersCode;
            textBox2.Text = c.Feesum.ToString();
        }

        private void frmAddUpdateFeeForSurfer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.FeeCode = Convert.ToInt32(txtNew.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNew, ex.Message);
                ok = false;
            }
            try
            {
                var y = cmbsurfersCode.SelectedItem;
                var i = cmbsurfersCode.SelectedValue;
                var u = cmbsurfersCode.SelectedText;
                c.SurfersCode = cmbsurfersCode.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbsurfersCode, ex.Message);
                ok = false;
            }
             try
            {
                c.Feesum = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                ok = false;
            }
             try
            {
                c.FeeDate = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dateTimePicker1, ex.Message);
                ok = false;
            }
                         try
            {
                c.ModeOfPayment = (string)comboBox1.SelectedValue;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox1, ex.Message);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cmbsurfersCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        }
    }

