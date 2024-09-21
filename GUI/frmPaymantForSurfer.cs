using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.GUI.FEEFORSURFER;
using yes.BLL.BSURFERS;
using yes.GUI.SURFERS;

namespace yes.GUI
{
    public partial class frmPaymantForSurfer : Form
    {
        Surfers s=new Surfers();
        string state;
        public frmPaymantForSurfer()
        {
            InitializeComponent();
        }
        public frmPaymantForSurfer(Surfers s, string state)
        {
            InitializeComponent();
            this.state = state;
            this.s = s;
            lblsurfername.Text = s.SurfersName +":       "+ s.Cellphone;
        }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateFeeForSurfer h = new frmAddUpdateFeeForSurfer();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void frmPaymantForSurfer_Load(object sender, EventArgs e)
        {

        }

        
    }
}
