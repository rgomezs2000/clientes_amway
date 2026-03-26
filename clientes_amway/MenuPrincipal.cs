using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace clientes_amway
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas realmente salir del sistema?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("es-VE");
            lblReloj.Text = "Fecha y Hora: " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss tt", ci);
            tmrReloj.Start();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Nombre: " + TomarUsuario.NombreUsuario + " Login: " + TomarUsuario.LoginUsuario;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

    }
}
