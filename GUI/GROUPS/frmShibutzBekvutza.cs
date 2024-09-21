using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BCOUNSLERSINGROUP;
using yes.BLL.BGROUPS;
using yes.BLL.BSURFERS;
using yes.BLL.BSURFERSINGROUP;

namespace yes.GUI.GROUPS
{
    public partial class frmShibutzBekvutza : Form
    {
        Groups g;
        string state;
        Surfers s;
        public frmShibutzBekvutza()
        {
            InitializeComponent();
        }
        public frmShibutzBekvutza(string state,Surfers s)
        {
            InitializeComponent();
            this.s = s;
            this.state = state;
            if (state == "רישום")
            {
               
                lblPirteygolesh.Text = "שם: " + s.SurfersName + "\n" + "ת.ז.: " + s.SurfersId + "  " + s.Gender + "\n" + s.Cellphone + "  " + s.Telephone;
                Refresh();
            }
        }
        public void Refresh()
        {
            dgvKvutzotBaemtza.DataSource = new groupsTabel().GetGroupsInMiddle();
            dgvKvutzotLoHitchilu.DataSource = new groupsTabel().GetGroupsLoHitchilu();
            dgvKvutzotBaemtza.Columns[0].HeaderText = "קוד קבוצה";
            dgvKvutzotBaemtza.Columns[1].HeaderText = "תאריך התחלה";
            dgvKvutzotBaemtza.Columns[2].HeaderText = "תאריך סיום";
            dgvKvutzotLoHitchilu.Columns[0].HeaderText = "קוד קבוצה";
            dgvKvutzotLoHitchilu.Columns[1].HeaderText = "תאריך התחלה";
            dgvKvutzotLoHitchilu.Columns[2].HeaderText = "תאריך סיום";
           
        }
        private void frmShibutzBekvutza_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvKvutzotBaemtza.Rows.Count; i++)
            {
                DataTable dtzmani = new groupsTabel().statusGroup(Convert.ToInt32(dgvKvutzotBaemtza.Rows[i].Cells[0].Value));
                if (dtzmani.Rows.Count > 0)
                    if (dtzmani.Rows[0][0].ToString() == "full")
                        dgvKvutzotBaemtza.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dgvKvutzotLoHitchilu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvKvutzotLoHitchilu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgvKvutzotLoHitchilu.Rows.Count))
            {
                dgvDates.DataSource = new groupsTabel().GetGroupDetails(Convert.ToInt32(dgvKvutzotLoHitchilu.SelectedRows[0].Cells[0].Value));
                g = new Groups(Convert.ToInt32(dgvKvutzotLoHitchilu.SelectedRows[0].Cells[0].Value));
                dgvCounslers.DataSource = new CounslersInGroupTable().GetCounslersPerGroup(g.CodeGroup);
            }
        }

        private void dgvKvutzotBaemtza_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvKvutzotBaemtza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgvKvutzotBaemtza.Rows.Count))
            {
                dgvDates.DataSource = new groupsTabel().GetGroupDetails(Convert.ToInt32(dgvKvutzotBaemtza.SelectedRows[0].Cells[0].Value));
                g = new Groups(Convert.ToInt32(dgvKvutzotBaemtza.SelectedRows[0].Cells[0].Value));
                dgvCounslers.DataSource = new CounslersInGroupTable().GetCounslersPerGroup(g.CodeGroup);
            }
        }

        private void btnShabetz_Click(object sender, EventArgs e)
        {
          
            
            DialogResult ans = MessageBox.Show("האם את/ה בטוח/ה שברצונך לשבץ את הנרשם לקבוצה ? "+g.CodeGroup, "הודעה לפני בצוע שבוץ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (ans == DialogResult.OK)
            {
                try
                {
                    SurfersInGroup sig = new SurfersInGroup();
                    sig.GroupCode = g.CodeGroup;
                    sig.SurfersCode = s.SurfersId;
                    sig.Add();
                    MessageBox.Show("השבוץ נקלט בהצלחה");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "נרשם יקר, בדוק אם הינך משובץ בקבוצה זו ");
                }
            }
        }

        private void btnAddKvutza_Click(object sender, EventArgs e)
        {
            frmAddUpdateGroups aug = new frmAddUpdateGroups();
            this.Hide();
            aug.ShowDialog();
            Refresh();
            this.Show();
        }

        private void dgvKvutzotBaemtza_Click(object sender, EventArgs e)
        {
           
        }
    }
}
