using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BFEEFORSURFER;

namespace yes.GUI.FEEFORSURFER
{
    public partial class frmFeeForSurfer : Form
    {
        FeeForSurferTable FeeForSurfer ;
        FeeForSurfer fee ;
        DataView dv;
        public frmFeeForSurfer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateFeeForSurfer h = new frmAddUpdateFeeForSurfer();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            FeeForSurfer g = new FeeForSurfer(dgvFeeForSurfer.SelectedRows[0].Cells[0].Value.ToString());
            frmAddUpdateFeeForSurfer h = new frmAddUpdateFeeForSurfer(g);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var t = dgvFeeForSurfer.SelectedRows[0].Cells["feeCode"].Value.ToString();
              if (dgvFeeForSurfer.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                FeeForSurfer dateToFind = new FeeForSurfer(dgvFeeForSurfer.SelectedRows[0].Cells["feeCode"].Value.ToString());
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
                        MessageBox.Show(ex.Message + "נוצרה בעיה בעת מחיקת הרשומה");
                    }
                }
            }
        }

        private void frmFeeForSurfer_Load(object sender, EventArgs e)
        {
            FeeForSurfer =new FeeForSurferTable();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(FeeForSurfer.GetDataTable());
            dgvFeeForSurfer.DataSource = dv;
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

       
       
    
