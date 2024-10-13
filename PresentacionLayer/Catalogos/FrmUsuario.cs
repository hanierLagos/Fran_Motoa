using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLayer.Catalogos
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario(string codigo, string nombres, string apellidos, string rol,string usuario, string contrasena)
        {
            InitializeComponent();
            MskCodigo.Text = codigo;
            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            cmbRol.Text= rol;
            txtUsuario.Text = usuario;
            txtContraseña.Text = contrasena;
            MskCodigo.Focus();

        }
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Usuario_Logic.CrearUsuario_Logic(MskCodigo.Text, cmbRol.Text, txtNombres.Text, txtApellidos.Text,
                    txtUsuario.Text, txtContraseña.Text);

                if (val > 0)
                {
                    MessageBox.Show("Registro del Usuario Guardado Exitosamente", "Guardar, Actualizar Usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Registrar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            // Verificar que haya texto en el txtNombres
            if (!string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                // Dividir el texto del txtNombres por los espacios
                string[] palabras = txtNombres.Text.Split('.');

                // Verificar que haya al menos una palabraa
                if (palabras.Length > 0)
                {
                    // Obtener la primera palabra
                    string primeraPalabra = palabras[0];

                    // Concatenar la primera palabra con el texto de mskCodigoCliente
                    txtUsuario.Text = primeraPalabra + MskCodigo.Text;
                }
            }
        }

        private void GenerarContraseña()
        {
            // Obtener los textos de los TextBox
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string codigo = MskCodigo.Text;
            string usuario = txtUsuario.Text;

            // Crear una instancia de Random
            Random random = new Random();

            // Función auxiliar para obtener 1 o 2 caracteres al azar de un texto
            string ObtenerCaracteresAleatorios(string texto)
            {
                if (string.IsNullOrEmpty(texto))
                    return "";

                // Determinar si se obtendrán 1 o 2 caracteres
                int cantidadCaracteres = random.Next(1, 3); // 1 o 2
                cantidadCaracteres = Math.Min(cantidadCaracteres, texto.Length); // No más de lo que contiene el texto

                // Crear un arreglo para almacenar los caracteres seleccionados
                char[] caracteresSeleccionados = new char[cantidadCaracteres];

                // Seleccionar los caracteres al azar
                for (int i = 0; i < cantidadCaracteres; i++)
                {
                    int indiceAleatorio = random.Next(0, texto.Length);
                    caracteresSeleccionados[i] = texto[indiceAleatorio];
                }

                return new string(caracteresSeleccionados);
            }

            // Generar la contraseña usando caracteres aleatorios de cada TextBox
            string contraseñaGenerada = ObtenerCaracteresAleatorios(nombre) +
                                        ObtenerCaracteresAleatorios(apellido) +
                                        ObtenerCaracteresAleatorios(codigo) +
                                        ObtenerCaracteresAleatorios(usuario);

            // Asignar la contraseña generada al txtContraseña
            txtContraseña.Text = contraseñaGenerada;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarContraseña();
        }
    }
}
