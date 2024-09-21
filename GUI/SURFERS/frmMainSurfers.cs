using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BSURFERS;
using yes.GUI.FEEFORSURFER;
using yes.GUI.GROUPS;

namespace yes.GUI.SURFERS
{
    public partial class frmMainSurfers : Form
    {
        surfersTable surfer;
        Surfers Surfers;
        DataView dv;
        
        string state;
        public frmMainSurfers()
        {
            InitializeComponent();
            btnChoose.Visible = false;
        }
        public frmMainSurfers(string state)
        {
            InitializeComponent();
            this.state = state;
            
           
            if((this.state=="תשלום")||(this.state=="רישום"))
            {
                btnChoose.Visible = true;
                btnAdd.Visible = false;
              
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateSurfers h = new frmAddUpdateSurfers();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Surfers g = new Surfers(dgvSurfers.SelectedRows[0].Cells[0].Value.ToString());
            frmAddUpdateSurfers h = new frmAddUpdateSurfers(g);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSurfers.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                Surfers cityToFind = new Surfers(dgvSurfers.SelectedRows[0].Cells["surfersId"].Value.ToString());
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

        private void frmMainSurfers_Load(object sender, EventArgs e)
        {
            surfer=new surfersTable();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(surfer.GetDataTable());
            dgvSurfers.DataSource = dv;
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dv.RowFilter = "surfersName like '" + textBox1.Text + "%'";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Surfers s = new Surfers(dgvSurfers.SelectedRows[0].Cells["surfersId"].Value.ToString().ToString());
            if (state=="תשלום")
            {
            frmPaymantForSurfer h = new frmPaymantForSurfer(s,"תשלום");
            this.Hide();
            h.ShowDialog();
            this.Show();
        }
            else
                if (state == "רישום")
                {
                    frmShibutzBekvutza fsb = new frmShibutzBekvutza("רישום",s);
                    this.Hide();
                    fsb.ShowDialog();
                    this.Show();
                }
        }

      
     

        
        }
    }
