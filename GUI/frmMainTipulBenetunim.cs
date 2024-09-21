using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.GUI.CITYS;
using yes.GUI.COUNSELORS;
using yes.GUI.COUNSLERSINGROUP;
using yes.GUI.DATESFORGROUP;
using yes.GUI.FEEFORSURFER;
using yes.GUI.GROUPS;
using yes.GUI.SURFERS;
using yes.GUI.SURFERSINGROUP;


namespace yes.GUI
{
    public partial class frmMainTipulBenetunim : Form
    {
        public frmMainTipulBenetunim()
        {
            InitializeComponent();
        }

        private void btncitys_Click(object sender, EventArgs e)
        {
            frmMainCitys h = new frmMainCitys();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btncounselors_Click(object sender, EventArgs e)
        {
            frmMainCounselors h = new frmMainCounselors();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnDatesForGroup_Click(object sender, EventArgs e)
        {
            frmMainDatesForGroup h = new frmMainDatesForGroup();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnFeeForSurfer_Click(object sender, EventArgs e)
        {
            frmFeeForSurfer h = new frmFeeForSurfer();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }



        private void btngroups_Click(object sender, EventArgs e)
        {
            frmMainGroups h = new frmMainGroups();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnsurfers_Click(object sender, EventArgs e)
        {
            frmMainSurfers h = new frmMainSurfers();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnSurfersInGroup_Click(object sender, EventArgs e)
        {
            frmMainSurfersInGroup h = new frmMainSurfersInGroup();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

       

        private void btnCounselorsInGroup_Click(object sender, EventArgs e)
        {
            frmMainCounselorsInGroup h = new frmMainCounselorsInGroup();
            this.Hide();
            h.ShowDialog();
            this.Show();

        }
    }
}