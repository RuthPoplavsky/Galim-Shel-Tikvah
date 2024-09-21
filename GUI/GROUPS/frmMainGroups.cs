using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BGROUPS;

namespace yes.GUI.GROUPS
{
    public partial class frmMainGroups : Form
    {
        bool myNew=false;
        groupsTabel groups;
        Groups group;
        DataView dv;
        public frmMainGroups(bool myNew)
        {
            this.myNew = myNew;
            MessageBox.Show("?ברצונך לשבץ מדריך");

        InitializeComponent();
        }
        public frmMainGroups()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateGroups h = new frmAddUpdateGroups();
            this.Hide();
            h.ShowDialog();
            this.Show();
            RefreshDisplay();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Groups g = new Groups(Convert.ToInt32(dgvGroups.SelectedRows[0].Cells[0].Value));
            frmAddUpdateGroups h = new frmAddUpdateGroups(g);
            this.Hide();
            h.ShowDialog();

            this.Show(); 
            RefreshDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (dgvGroups.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                var u = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["codeGroup"].Value);
                Groups cityToFind = new Groups(Convert.ToInt32(dgvGroups.SelectedRows[0].Cells["codeGroup"].Value));
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

        private void frmMainGroups_Load(object sender, EventArgs e)
        {
            groups=new groupsTabel();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(groups.GetAllGroup());
            dgvGroups.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "codeGroup=" + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }

        }

        }
    

