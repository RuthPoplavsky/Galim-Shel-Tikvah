using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BCOUNSELORS;

namespace yes.GUI.COUNSELORS
{
    public partial class frmMainCounselors : Form
    {
        counselorsTable counselors ;
        Counselors counselor ;
         DataView dv;
        public frmMainCounselors()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateCounselors h = new frmAddUpdateCounselors();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Counselors co = new Counselors(Convert.ToInt32(dgvCounselors.SelectedRows[0].Cells[0].Value));
            frmAddUpdateCounselors h = new frmAddUpdateCounselors(co);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCounselors.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                Counselors counselorToFind = new Counselors(Convert.ToInt32(dgvCounselors.SelectedRows[0].Cells["codeCoach"].Value));
                DialogResult ans = MessageBox.Show("האם את/ה בטוח/ה שברצונך למחוק רשומה זו? ", " הודעת מחיקה", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (ans == DialogResult.OK)
                {
                    try
                    {
                        counselorToFind.Delete();
                        MessageBox.Show("הרשומה נמחקה בהצלחה");
                        RefreshDisplay();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "נוצרה בעיה בעת מחיקת הרשומה");
                    }
                }
            }
        }
        

        private void frmMainCounselors_Load(object sender, EventArgs e)
        {
            counselors=new counselorsTable();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(counselors.GetDataTable());
            dgvCounselors.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "nameCoach like '" + textBox1.Text + "%'";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        
      

        }
        }

   
