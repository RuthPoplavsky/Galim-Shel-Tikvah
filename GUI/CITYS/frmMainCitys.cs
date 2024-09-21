using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BCITYS;

namespace yes.GUI.CITYS
{
    public partial class frmMainCitys : Form
    {
        citysTable cities;
        City city;
        DataView dv;
        public frmMainCitys()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateCity h = new frmAddUpdateCity();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            City g = new City(dgvcitys.SelectedRows[0].Cells[0].Value.ToString());
            frmAddUpdateCity h = new frmAddUpdateCity(g);
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (dgvcitys.SelectedRows.Count == 0)
            {
                MessageBox.Show("עליך לבחור רשומה למחיקה");
            }
            else
            {
                City cityToFind = new City(dgvcitys.SelectedRows[0].Cells["cityNames"].Value.ToString());
                DialogResult ans = MessageBox.Show("האם את/ה בטוח/ה שברצונך למחוק רשומה זו?", "הודעת מחיקה", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
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

        private void frmMainCitys_Load(object sender, EventArgs e)
        {
            cities=new citysTable();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            dv = new DataView(cities.GetDataTable());
            dgvcitys.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "cityNames like '" + textBox1.Text + "%'";
        }

        

       

      
 }

       
        

      
    }
