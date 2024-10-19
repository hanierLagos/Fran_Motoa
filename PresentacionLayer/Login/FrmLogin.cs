using LogicLayer;
using PresentacionLayer.Catalogos;
using PresentacionLayer.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentacionLayer.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(cmbArea.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear una instancia de la lógica de usuario
                Usuario_Logic userLogic = new Usuario_Logic();

                // Llamar al método de autenticación
                bool isAuthenticated = userLogic.AuthenticateUser(txtUser.Text, txtPassword.Text, cmbArea.Text);

                if (isAuthenticated)
                {
                    MessageBox.Show("Autenticación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    switch (cmbArea.Text)
                    {
                        case "Administrador":
                            this.Hide();
                            FrmAdministrador frmAdministrador = new FrmAdministrador();
                            frmAdministrador.ShowDialog();
                            this.Close();
                            break;
                        case "Ventas":
                            this.Hide();
                            FrmMenuVentas frmVentas = new FrmMenuVentas();
                            frmVentas.ShowDialog();
                            this.Close();
                            break;
                        case "Inventario":
                            this.Hide();
                            FrmInventario invenatrio = new FrmInventario();
                            invenatrio.ShowDialog();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Área desconocida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                }
                else
                {
                    MessageBox.Show("Nombre de usuario, contraseña o área incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            { 
                //si se produce elevento se manda a llamar el noton de inicio de sesion
                btnIniciarSesion_Click(sender, e);  
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
