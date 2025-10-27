using ClinicaMedicare.formADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedicare
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNLOGINADMIN_Click(object sender, EventArgs e)
        {
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
            this.Hide();
        }

    }
}
