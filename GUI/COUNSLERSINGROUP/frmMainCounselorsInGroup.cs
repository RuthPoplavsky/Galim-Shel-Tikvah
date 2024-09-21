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

namespace yes.GUI.COUNSLERSINGROUP
{
    public partial class frmMainCounselorsInGroup : Form
    {
        CounslersInGroupTable counselorIng = new CounslersInGroupTable();
        CounslersInGroup counseorIn = new CounslersInGroup();
        DataView dv;
        public frmMainCounselorsInGroup()
        {
            InitializeComponent();

        }
       
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (dgvCounselorsInGroup.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                CounslersInGroup cityToFind = new CounslersInGroup(dgvCounselorsInGroup.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult ans = MessageBox.Show("האם את/ה בטוח/ה שברצונך למחוק רשומה זו? ", "הודעת מחיקה", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (ans == DialogResult.OK)
                {
                    try
                    {
                        cityToFind.Delete();
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
    
        private void RefreshDisplay()
        {
            dv = new DataView(counselorIng.GetDataTable());
            dgvCounselorsInGroup.DataSource = dv;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "surfersCode=" + textBox1.Text;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddUpdateCounselorsInGroup h = new frmAddUpdateCounselorsInGroup();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            CounslersInGroup g = new CounslersInGroup(dgvCounselorsInGroup.SelectedRows[0].Cells[0].Value.ToString());
            frmAddUpdateCounselorsInGroup h = new frmAddUpdateCounselorsInGroup(g);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMainCounselorsInGroup_Load(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

       
        }
        }
    

