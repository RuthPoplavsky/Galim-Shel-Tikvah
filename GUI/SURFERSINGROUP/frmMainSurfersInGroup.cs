using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BSURFERSINGROUP;

namespace yes.GUI.SURFERSINGROUP
{
    public partial class frmMainSurfersInGroup : Form
    {
        surfersInGroupTable surfersIng=new surfersInGroupTable();
        SurfersInGroup surfersIn=new SurfersInGroup();
        DataView dv;
        public frmMainSurfersInGroup()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SurfersInGroup g = new SurfersInGroup(dgvSurfersInGroup.SelectedRows[0].Cells[0].Value.ToString());
            frmAddUpdateSurfersInGroup h = new frmAddUpdateSurfersInGroup(g);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateSurfersInGroup h = new frmAddUpdateSurfersInGroup();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSurfersInGroup.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                SurfersInGroup cityToFind = new SurfersInGroup(dgvSurfersInGroup.SelectedRows[0].Cells[0].Value.ToString());
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

        private void frmMainSurfersInGroup_Load(object sender, EventArgs e)
        {
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(surfersIng.GetDataTable());
            dgvSurfersInGroup.DataSource = dv;
        }

      

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "surfersCode=" + textBox1.Text;
        }

        }

        }
    

