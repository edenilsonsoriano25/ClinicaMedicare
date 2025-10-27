using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedicare.formADMIN
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frm_PANTALLA_PRINCIPAL_ADMIN pantallaAdmin = new frm_PANTALLA_PRINCIPAL_ADMIN();
            pantallaAdmin.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InicioForm inicioForm = new InicioForm();
            inicioForm.Show();
            this.Hide();
        }
    }
}
