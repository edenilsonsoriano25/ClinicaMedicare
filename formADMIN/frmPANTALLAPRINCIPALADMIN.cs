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
    public partial class frm_PANTALLA_PRINCIPAL_ADMIN : Form
    {
        public frm_PANTALLA_PRINCIPAL_ADMIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            FormMedicos formMedicos = new FormMedicos();
            formMedicos.Show();
            this.Hide();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            formPacientes.Show();
            this.Hide();
        }

        private void btnCerrarseccion_Click(object sender, EventArgs e)
        {
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportePacientes formReportePacientes = new FormReportePacientes();
            formReportePacientes.Show();
            this.Hide();
        }
    }
}
