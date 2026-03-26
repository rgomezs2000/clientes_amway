using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clientes_amway
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string clave = pswClave.Text;

            if (login == "" && clave == "")
            {
                MessageBox.Show("Debes colocar tu nombre de usuario y/o contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (login == "" || clave == "")
                {
                    MessageBox.Show("Debes colocar tu nombre de usuario y/o contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int usuarioCont;
                    usuarioCont = UsuarioDAO.ContarUsuario(login);
                    if (usuarioCont == 0)
                    {
                        MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Usuario usuario = new Usuario();
                        usuario = UsuarioDAO.ValidarUsuario(login);
                        if (login == usuario.LoginUsuario && clave == usuario.ClaveUsuario)
                        {
                            MenuPrincipal menu = new MenuPrincipal();
                            TomarUsuario.NombreUsuario = usuario.NombreUsuario;
                            TomarUsuario.LoginUsuario = usuario.LoginUsuario;
                            this.Hide();
                            menu.Show();
                            menu.Visible = false;
                            menu.ShowDialog();
                        }
                        else
                        {
                            if (login != usuario.LoginUsuario)
                            {
                                MessageBox.Show("Login incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (clave != usuario.ClaveUsuario)
                                {
                                    MessageBox.Show("Clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
