using BussinesLayer;
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
using System.Xml.Linq;

namespace PresentacionLayer.Operaciones
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();cmbMetoodPago.SelectedIndex = 0;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            //Cargar el proximi umoer de entrada
            CargarNumeroVentaa();

            CargarProductos();
        }

        /// <summary>
        /// METODO PARA CARGAR LOS CLIENTES AL DAR ENTER
        /// </summary>
        /// <param name="clientId"></param>
        private void LoadClientData(string clientId)
        {
            try
            {
                // Mandar la solicitud por el controlador
                DataTable clientData = Cliente_Logic.GetClientLogic(clientId);

                if (clientData == null || clientData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registro del cliente especificado: " + clientId, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataRow row = clientData.Rows[0];
                    txtNombreCliente.Text = row["NOMBRES"].ToString();
                    txtxApellidosCliente.Text = row["APELLIDOS"].ToString();
                    txtTelefonoCliente.Text = row["TELEFONO"].ToString();
                    txtxDireccionCliente.Text = row["DIRECCION"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// METODO PARA CARGAR LOS PRODUCTOS DISPONIBLES NE LA VENTA
        /// </summary>
        private void CargarProductos()
        {
            try
            {
                DataTable dt = Producto_Logic.VerProductos();

                // Limpiar el DataGridView antes de agregar nuevas filas
                DG_ProductosDisponibles.Rows.Clear();

                // Agregar cada entrada al DataGridView
                foreach (DataRow row in dt.Rows)
                {
                    DG_ProductosDisponibles.Rows.Add(
                        row["CODIGO_PRODUCTO"].ToString(),
                        row["PRODUCTO"].ToString(),
                        row["PRECIO_PRODUCTO"].ToString(),
                        imgCrud.Images[0]

                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las entradas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// METODO PARA OBTENER ID DE la venta
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private int ObtenerIdVenta(int numero)
        {
            // Obtiene el DataTable con los datos de la venta usando el numero de venta
            DataTable venta = VentaLogic.ObtenerIdVenta();

            // Verifica si el DataTable es nulo o está vacío
            if (venta == null || venta.Rows.Count == 0)
            {
                // Lanza una excepción si no se encuentra la venta
                throw new Exception("No se encontró la venta con el número código especificado: " + numero);
            }

            DataRow[] rows = venta.Select($"NUMERO_VENTA = '{numero}'");
            if (rows.Length == 0)
            {
                throw new Exception("No se encontró la venta con el número código especificado: " + numero);
            }

            // Retorna el ID de la venta convertido a entero
            return Convert.ToInt32(rows[0]["ID_VENTA"]);
        }

        /// <summary>
        /// METODO PARA OBTENER ID DEL CLIENET
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private int ObtenerIdCliente(string codigo)
        {
            // Obtiene el DataTable con los datos del producto usando el código proporcionado
            DataTable clienteDtTable = Cliente_Logic.ObtenerIdCliente();

            // Verifica si el DataTable es nulo o está vacío
            if (clienteDtTable == null || clienteDtTable.Rows.Count == 0)
            {
                // Lanza una excepción si no se encuentra el cliente
                throw new Exception("No se encontró el cliente con el código especificado: " + codigo);
            }

            // Busca el índice del cliente con el código especificado
            DataRow[] rows = clienteDtTable.Select($"CODIGO_CLIENTE = '{codigo}'");
            if (rows.Length == 0)
            {
                throw new Exception("No se encontró el cliente con el código especificado: " + codigo);
            }

            // Retorna el ID del cliente convertido a entero
            return Convert.ToInt32(rows[0]["ID_CLIENTE"]);
        }

        /// <summary>
        /// 
        /// METODO PARA OBTENER EL ID DEL PRODUCTO DETALLADO
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private int ObtenerIdProducto(string codigo)
        {
            // Obtiene el DataTable con los datos del producto usando el código proporcionado
            DataTable productoDataTable = Producto_Logic.ObtenerIdProducto();

            // Verifica si el DataTable es nulo o está vacío
            if (productoDataTable == null || productoDataTable.Rows.Count == 0)
            {
                // Lanza una excepción si no se encuentra el producto
                throw new Exception("No se encontró el producto con el código especificado: " + codigo);
            }

            // Busca el índice del producto con el código especificado
            DataRow[] rows = productoDataTable.Select($"CODIGO_PRODUCTO = '{codigo}'");
            if (rows.Length == 0)
            {
                throw new Exception("No se encontró el producto con el código especificado: " + codigo);
            }

            // Retorna el ID del producto convertido a entero
            return Convert.ToInt32(rows[0]["ID_PRODUCTO"]);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DG_ProductosEntrantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic se haya realizado en una celda válida
            if (e.ColumnIndex == 3) // Asegúrate de que la columna 4 es la que quieres
            {
                // Obtener la fila actual del DataGridView
                DataGridViewRow row = DG_ProductosDisponibles.Rows[e.RowIndex];

                // Asignar los valores a los TextBox correspondientes
                txtCodigoProducto.Text = row.Cells[0].Value.ToString(); // Código del producto
                txtDecripcion.Text = row.Cells[1].Value.ToString(); // Descripción del producto
                txtPrecio.Text = row.Cells[2].Value.ToString(); // Precio del producto
                
            }
        }

        /// <summary>
        /// Metodo para cargar el nuevo numero de venta
        /// </summary>
        private void CargarNumeroVentaa()
        {
            try
            {
                // Llama al método de la lógica de negocios obtener el próximo número de venta
                int nextNumber = VentaLogic.ObtenerNumeroVenta();

                // Asigna el número obtenido al campo de texto txtN_Buy
                txtNumeroVenta.Text = nextNumber.ToString();
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción que pueda ocurrir durante la obtención del número de venta
                MessageBox.Show("Error al obtener el próximo número de Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Decimal total = 0;

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            // Validar el código del cliente
            if (string.IsNullOrWhiteSpace(mskCodigoCliente.Text) || string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtxApellidosCliente.Text))
            {
                MessageBox.Show("Por favor, complete los campos correspondientes del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Finalizar la Venta
            if (DG_ProductosAgregados.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de finalizar la Venta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No continuar si no hay productos
            }

            int idcliente = ObtenerIdCliente(mskCodigoCliente.Text);  // Obtiene el ID del cliente

            int val = VentaLogic.CrearVenta_Logic(idcliente, int.Parse(txtNumeroVenta.Text), txtFechaVenta.Value, Decimal.Parse(txtMontoTotal.Text), cmbMetoodPago.Text);
            if (val > 0)
            {
                MessageBox.Show("Venta agregada correctamente. Venta Finalizada.",
                   "Finalizar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarNumeroVentaa();
                total = 0;
                txtMontoTotal.Text = total.ToString("0.00");

                // Limpiar los campos
                txtMontoTotal.Clear();

                // Limpiar la tabla 
                DG_ProductosAgregados.Rows.Clear();

                mskCodigoCliente.Clear();
                txtNombreCliente.Clear();
                txtxApellidosCliente.Clear();
                txtTelefonoCliente.Clear();
               txtxDireccionCliente.Clear();
                mskCodigoCliente.Focus();
            }
            else
            {
                MessageBox.Show("Error al agregar la entrada. Intente nuevamente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            // Validar el número de venta
            if (string.IsNullOrWhiteSpace(txtNumeroVenta.Text) || !int.TryParse(txtNumeroVenta.Text, out int numeroVenta))
            {
                MessageBox.Show("Número de venta no válido. Por favor, ingrese un número de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la fecha de venta
            if (txtFechaVenta.Value == null || txtFechaVenta.Value > DateTime.Now)
            {
                MessageBox.Show("Fecha de venta no válida. Por favor, seleccione una fecha correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el monto total
            if (string.IsNullOrWhiteSpace(txtMontoTotal.Text) || !decimal.TryParse(txtMontoTotal.Text, out decimal montoTotal) || montoTotal < 0)
            {
                MessageBox.Show("Monto total no válido. Por favor, ingrese un monto total correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la cantidad
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad no válida. Por favor, ingrese una cantidad mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el precio
            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio no válido. Por favor, ingrese un precio mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que la descripción no esté vacía
            if (string.IsNullOrWhiteSpace(txtDecripcion.Text))
            {
                MessageBox.Show("Descripción no válida. Por favor, ingrese una descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int clientid = ObtenerIdCliente(mskCodigoCliente.Text);

            // Si todos los campos son válidos, proceder con la lógica de creación de venta
            int venta = VentaLogic.CrearVenta_Logic(clientid, numeroVenta, txtFechaVenta.Value, montoTotal, cmbMetoodPago.Text);

            if (venta > 0)
            {
                // Calcula el subtotal multiplicando la cantidad por el precio
                Decimal subtotal = cantidad * precio;

                // Agregar el subtotal calculado al txtSubtotal
                txtSubtotal.Text = subtotal.ToString("0.00"); // Formatear con dos decimales

                // Suma el subtotal al total acumulado
                total += subtotal;

                // Obtener el id de la venta
                int idVenta = ObtenerIdVenta(numeroVenta);

                // Obtener el id del producto vendido
                int idP = ObtenerIdProducto(txtCodigoProducto.Text);

                // Agregar el detalle de la venta
                int detail = Detalle_VentaLogic.AgregarDetalleVenta(idVenta, idP, cantidad, precio, subtotal, txtDecripcion.Text);

                if (detail > 0)
                {
                    // Si se crea el detalle de venta correctamente, agrega una nueva fila al DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DG_ProductosAgregados);

                    // Asigna los valores a cada celda de la fila
                    row.Cells[0].Value = txtCodigoProducto.Text; // Código del insumo
                    row.Cells[1].Value = txtDecripcion.Text;     // Descripción del producto
                    row.Cells[2].Value = precio;               //precio
                    row.Cells[3].Value = cantidad;                // Cantidad
                    row.Cells[4].Value = subtotal;               // Subtotal

                    // Agrega la fila al DataGridView
                    DG_ProductosAgregados.Rows.Add(row);

                    // Actualiza el valor del txtMontoTotal con el nuevo total acumulado, formateado
                    txtMontoTotal.Text = total.ToString("0.00"); // Mostrará dos decimales

                    // Mensaje de éxito
                    MessageBox.Show("Producto agregado exitosamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de agregar el producto
                    txtCodigoProducto.Clear();
                    txtCantidad.Clear();
                    txtPrecio.Clear();
                    txtDecripcion.Clear();
                    txtSubtotal.Clear();
                }
            }


        }//fin btnAgregar

        private void mskCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprobar si se ha presionado Enter (ASCII 13)
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadClientData(mskCodigoCliente.Text);  

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
             // Validar que el campo txtNumeroVenta no esté vacío
                if (string.IsNullOrWhiteSpace(txtNumeroVenta.Text))
                {
                    MessageBox.Show("Por favor, ingrese el número de venta a anular.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir el texto del txtNumeroVenta a un entero
                int numeroVenta;
                if (!int.TryParse(txtNumeroVenta.Text, out numeroVenta))
                {
                    MessageBox.Show("El número de venta debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Preguntar al usuario si está seguro de anular la venta
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea anular esta venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método para anular la venta
                    int anulado = VentaLogic.AnularVenta(numeroVenta);

                    if (anulado > 0) // Cambia esta verificación según la lógica de tu método AnularVenta
                    {
                        MessageBox.Show("La venta ha sido anulada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarNumeroVentaa();
                        total = 0;
                        txtMontoTotal.Text = total.ToString("0.00");

                        // Limpiar los campos
                        txtMontoTotal.Clear();

                        // Limpiar la tabla 
                        DG_ProductosAgregados.Rows.Clear();

                        mskCodigoCliente.Clear();
                        txtNombreCliente.Clear();
                        txtxApellidosCliente.Clear();
                        txtTelefonoCliente.Clear();
                        txtxDireccionCliente.Clear();
                        mskCodigoCliente.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la venta. Por favor, verifique el número de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        }

        private void txtBuscra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay texto en el TextBox.
                if (string.IsNullOrWhiteSpace(txtBuscra.Text))
                {
                    // Si no hay texto, mostrar todos los datos originales.
                    foreach (DataGridViewRow row in DG_ProductosDisponibles.Rows)
                    {
                        row.Visible = true; // Hacer visible cada fila.
                    }
                    return;
                }

                // Filtrar filas que coincidan con el texto ingresado.
                foreach (DataGridViewRow row in DG_ProductosDisponibles.Rows)
                {
                    // Verificar si la fila contiene el texto en NOMBRES o APELLIDOS.
                    bool isVisible = row.Cells["PRODUCTOS"].Value.ToString().IndexOf(txtBuscra.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    // Establecer la visibilidad de la fila según el resultado de la búsqueda.
                    row.Visible = isVisible;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            txtNombreCliente.ReadOnly = isReadOnly;
            txtxApellidosCliente.ReadOnly = isReadOnly;
            txtTelefonoCliente.ReadOnly = isReadOnly;
            txtxDireccionCliente.ReadOnly = isReadOnly;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                SetTextBoxReadOnly(false);

                mskCodigoCliente.Clear();
                txtNombreCliente.Clear();
                txtxApellidosCliente.Clear();
                txtTelefonoCliente.Clear();
                txtxDireccionCliente.Clear();
                mskCodigoCliente.Focus();
            }
        }

        private void rBtnClienteRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnClienteRegistrado.Checked)
            {
                // Habilitar el campo de ID y limpiar los campos
                mskCodigoCliente.Enabled = true;
                SetTextBoxReadOnly(true);

                mskCodigoCliente.Clear();
                txtNombreCliente.Clear();
                txtxApellidosCliente.Clear();
                txtTelefonoCliente.Clear();
                txtxDireccionCliente.Clear();
                mskCodigoCliente.Focus();
            }
        }
    }
    
}
