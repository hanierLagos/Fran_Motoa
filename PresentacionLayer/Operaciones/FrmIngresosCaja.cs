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

namespace PresentacionLayer.Operaciones
{
    public partial class FrmIngresosCaja : Form
    {
        public FrmIngresosCaja()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // Obtener la fecha seleccionada del DateTimePicker
                DateTime fechaCalculo = txtDate.Value;

                // Llamar al método estático en la capa de negocio para calcular los ingresos en caja
                DataTable resultados = VentaLogic.CalcularIngresosEnCaja(fechaCalculo);

                // Mostrar los resultados en los TextBox correspondientes
                if (resultados.Rows.Count > 0)
                {
                    txtIngresos.Text = resultados.Rows[0]["IngresosPorVentas"].ToString();
                    txtCantProduc.Text = resultados.Rows[0]["ProductosVendidos"].ToString();
                    txtGanancias.Text = resultados.Rows[0]["Ganancias"].ToString();
                }
                else
                {
                    // En caso de que no haya resultados (opcional: mostrar un mensaje o limpiar los TextBox)
                    MessageBox.Show("No se encontraron resultados para la fecha especificada.");
                    txtIngresos.Text = "0.0";
                    txtCantProduc.Text = "0.0";
                    txtGanancias.Text = "0.0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular ingresos en caja: {ex.Message}");
            }
        }
    }
}
