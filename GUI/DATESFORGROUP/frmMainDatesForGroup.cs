using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BDATESFORGROUP;

namespace yes.GUI.DATESFORGROUP
{
    public partial class frmMainDatesForGroup : Form
    {
        DatesForGroupTable DatesForGroup;
        DatesForGroup date;
        DataView dv;
        public frmMainDatesForGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateDatesForGroup h = new frmAddUpdateDatesForGroup();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DatesForGroup da = new DatesForGroup(Convert.ToInt32(dgvDates.SelectedRows[0].Cells[0].Value), Convert.ToDateTime(dgvDates.SelectedRows[0].Cells[1].Value));
            frmAddUpdateDatesForGroup h = new frmAddUpdateDatesForGroup(da);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDates.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                DatesForGroup dateToFind = new DatesForGroup(Convert.ToInt32(dgvDates.SelectedRows[0].Cells[0].Value), Convert.ToDateTime(dgvDates.SelectedRows[0].Cells[1].Value));
                DialogResult ans = MessageBox.Show("האם את/ה בטוח/ה שברצונך למחוק רשומה זו? ", "הודעת מחיקה", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (ans == DialogResult.OK)
                {
                    try
                    {
                        dateToFind.Delete();
                        MessageBox.Show("הרשומה נמחקה בהצלחה");
                        RefreshDisplay();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Problem in deleting the date");
                    }
                }
            }
        }

        private void frmMainDatesForGroup_Load(object sender, EventArgs e)
        {
            DatesForGroup=new DatesForGroupTable();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(DatesForGroup.GetDataTable());
            dgvDates.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "groupDate like '" + textBox1.Text + "%'";
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "groupCode=" + textBox1.Text;
        }

      
       
        }
        }

     


       