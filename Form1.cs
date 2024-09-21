using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.GUI;
using yes.GUI.COUNSELORS;
using yes.GUI.COUNSLERSINGROUP;
using yes.GUI.DATESFORGROUP;
using yes.GUI.GROUPS;
using yes.GUI.SURFERS;

namespace yes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainTipulBenetunim m = new frmMainTipulBenetunim();
            this.Hide();
            m.ShowDialog();
            this.Show();

        }

       

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmMainSurfers h = new frmMainSurfers("תשלום");
            this.Hide();
            h.ShowDialog();
            this.Show();
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("האם הגולש כבר קיים?", "בדיקת גולש", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3, MessageBoxOptions.RtlReading);
            if (ans == DialogResult.Yes)
            {
                frmMainSurfers mr = new frmMainSurfers("רישום");
                this.Hide();
                mr.ShowDialog();
                this.Show();


            }
            else
                if (ans == DialogResult.No)
                {
                    frmAddUpdateSurfers AC = new frmAddUpdateSurfers("רישום");
                    this.Hide();
                    AC.ShowDialog();
                    this.Show();
                }
            
        }

        private void btnAddCounselor_Click(object sender, EventArgs e)
        {
            frmAddUpdateCounselors auc = new frmAddUpdateCounselors();
            this.Hide();
            auc.ShowDialog();
            this.Show();
        }

        private void btnOpenGroup_Click(object sender, EventArgs e)
        {
            frmAddUpdateGroups r = new frmAddUpdateGroups();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void btnWasLesson_Click(object sender, EventArgs e)
        {
            frmMainDatesForGroup r = new frmMainDatesForGroup();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void btnAddCounselorToGroup_Click(object sender, EventArgs e)
        {
            frmAddUpdateCounselorsInGroup r = new frmAddUpdateCounselorsInGroup();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

     

        

      

        
    }
}
