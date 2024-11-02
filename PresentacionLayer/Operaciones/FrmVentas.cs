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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iTextSharp.tool.xml;
using PresentacionLayer.Menus;
using PresentacionLayer.Catalogos;


namespace PresentacionLayer.Operaciones
{
    public partial class FrmVentas : Form
    {
        private List<int> idC = new List<int>();
        private List<int> idTipoManoObra = new List<int>();

        public FrmVentas()
        {
            InitializeComponent();cmbMetoodPago.SelectedIndex = 0; 
            CargarClienteComboBox();
            CargarTipoManoObraComboBox();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            rBtnVentaProducto.Checked=true;

            WindowState = FormWindowState.Maximized;

            //Cargar el proximi umoer de entrada
            CargarNumeroVentaa();

            //carga los productos disponible en la tabla 
            CargarProductos();
        }

        ///// <summary>
        ///// METODO PARA CARGAR LOS CLIENTES AL DAR ENTER
        ///// </summary>
        ///// <param name="clientId"></param>
        //private void LoadClientData(string clientId)
        //{
        //    try
        //    {
        //        // Mandar la solicitud por el controlador
        //        DataTable clientData = Cliente_Logic.GetClientLogic(clientId);

        //        if (clientData == null || clientData.Rows.Count == 0)
        //        {
        //            MessageBox.Show("No se encuentra el registro del cliente especificado: " + clientId, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //        else
        //        {
        //            DataRow row = clientData.Rows[0];
        //            txtNombreCliente.Text = row["NOMBRES"].ToString();
        //            txtxApellidosCliente.Text = row["APELLIDOS"].ToString();
        //            txtTelefonoCliente.Text = row["TELEFONO"].ToString();
        //            txtxDireccionCliente.Text = row["DIRECCION"].ToString();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
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
                        row["CANTIDAD"].ToString(),
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
        /// METODO PARA OBTENER ID DEL CLIENTE, ADEMAS CARGA EL CLIENTE EN UN COMBOBOX
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private void CargarClienteComboBox()
        {
            //Cargar el listado de las marcas       
            foreach (DataRow r in Cliente_Logic.CargarClientesVenta().Rows)
            {
                //Cargar los nombres de los clientes
                cmbClientes.Items.Add(r["CLIENTE"].ToString());
                idC.Add(int.Parse(r["ID_CLIENTE"].ToString()));
            }//Fin de la instrucción foreach
        }

        /// <summary>
        /// METODO PARA CARGAR LOS TIPO DE MANO DE OBRA A UN COMBOBOX
        /// </summary>
        private void CargarTipoManoObraComboBox()
        {
            //Cargar el listado de los tipo de mano de obra       
            foreach (DataRow r in ManoObra_Logic.CargarTipoManoObra().Rows)
            {
                //Cargar los tipos de mano de obra
                cmbTipoObra.Items.Add(r["NOMBRE_TIPO"].ToString());
                idTipoManoObra.Add(int.Parse(r["ID_TIPO_MANO_OBRA"].ToString()));
            }//Fin de la instrucción foreach
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
            if (e.ColumnIndex == 4) // Asegúrate de que la columna 4 es la que quieres
            {
                // Obtener la fila actual del DataGridView
                DataGridViewRow row = DG_ProductosDisponibles.Rows[e.RowIndex];

                // Asignar los valores a los TextBox correspondientes
                txtCodigoProducto.Text = row.Cells[0].Value.ToString(); // Código del producto
                txtDecripcion.Text = row.Cells[1].Value.ToString(); // Descripción del producto
                txtPrecio.Text = row.Cells[2].Value.ToString(); // Precio del producto
                txtCantidad.Focus();
                
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
            if (string.IsNullOrWhiteSpace(cmbClientes.Text))
            {
                MessageBox.Show("Por favor, selecciones el cliente correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Finalizar la Venta
            if (DG_DetallesdeVenta.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de finalizar la Venta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No continuar si no hay productos
            }

            int idcliente = idC[this.cmbClientes.SelectedIndex];// Obtiene el ID del cliente


            int val = VentaLogic.CrearVenta_Logic(idcliente, int.Parse(txtNumeroVenta.Text), txtFechaVenta.Value, Decimal.Parse(txtMontoTotal.Text), cmbMetoodPago.Text);
            if (val > 0)
            {

                try
                {
                    // Generar la factura de venta en un archivo .pdf
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        FileName = "FACTURA_" + txtNumeroVenta.Text + ".pdf"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        string paginahtml_text = Properties.Resources.PlantillaFactura.ToString();

                        // Reemplazar placeholders en el HTML
                        paginahtml_text = paginahtml_text.Replace("@CLIENTE", cmbClientes.Text);
                        paginahtml_text = paginahtml_text.Replace("@FECHA", txtFechaVenta.Text);
                        paginahtml_text = paginahtml_text.Replace("@NUMERO", txtNumeroVenta.Text);

                        string filas = string.Empty;
                        decimal total = 0;

                        // Recorrer las filas del DataGridView y generar filas HTML
                        foreach (DataGridViewRow row in DG_DetallesdeVenta.Rows)
                        {
                            if (row.Cells["SUBTOTAL"].Value != null) // Verificar que la celda no esté vacía
                            {
                                filas += "<tr>";
                                filas += "<td>" + row.Cells["description"].Value.ToString() + "</td>";
                                filas += "<td>" + row.Cells["pUnitario"].Value.ToString() + "</td>";
                                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                                filas += "<td>" + row.Cells["SUBTOTAL"].Value.ToString() + "</td>";
                                filas += "</tr>";

                                total += decimal.Parse(row.Cells["SUBTOTAL"].Value.ToString());
                            }
                        }

                        // Reemplazar las filas generadas en el HTML y el total
                        paginahtml_text = paginahtml_text.Replace("@FILAS", filas);
                        paginahtml_text = paginahtml_text.Replace("@TOTAL", total.ToString("0.00")); // Formatear el total a dos decimales

                        using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            Document pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);
                            pdfdoc.Open();


                            using (StringReader sr = new StringReader(paginahtml_text))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfdoc, sr);
                            }

                            //Pintar la imagen del logo del taller en el pdf
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_tallerfranc, System.Drawing.Imaging.ImageFormat.Jpeg);
                            img.ScaleToFit(80, 80);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfdoc.LeftMargin, pdfdoc.Top - 60);
                            pdfdoc.Add(img);

                            //Cerrar la creacion del pdf
                            pdfdoc.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Venta agregada correctamente. Venta Finalizada.",
                   "Finalizar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarNumeroVentaa();
                total = 0;
                txtMontoTotal.Text = total.ToString("0.00");

                // Limpiar los campos
                txtMontoTotal.Clear();

                // Limpiar la tabla 
                DG_DetallesdeVenta.Rows.Clear();

                cmbClientes.SelectedIndex = -1;

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
            

            int clientid = idC[this.cmbClientes.SelectedIndex];


            // Obtener el id del producto vendido
            int idP = ObtenerIdProducto(txtCodigoProducto.Text);

            // Verificar disponibilidad del producto en el inventario
            bool haySuficienteInventario = Producto_Logic.VerificarDisponibilidadProducto(cantidad,txtCodigoProducto.Text);

            if (!haySuficienteInventario)
            {
                MessageBox.Show("No hay suficiente inventario disponible para este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

                // Agregar el detalle de la venta
                int detail = Detalle_VentaLogic.AgregarDetalleVenta(idVenta, idP, cantidad, precio, subtotal, txtDecripcion.Text);

                if (detail > 0)
                {
                    // Si se crea el detalle de venta correctamente, agrega una nueva fila al DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DG_DetallesdeVenta);

                    // Asigna los valores a cada celda de la fila
                    row.Cells[0].Value = txtCodigoProducto.Text+"--"+txtDecripcion.Text;     // Descripción del producto
                    row.Cells[1].Value = precio;                 // Precio
                    row.Cells[2].Value = cantidad;               // Cantidad
                    row.Cells[3].Value = subtotal;               // Subtotal

                    // Agrega la fila al DataGridView
                    DG_DetallesdeVenta.Rows.Add(row);

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
                        DG_DetallesdeVenta.Rows.Clear();

                        cmbClientes.SelectedIndex = -1;
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

        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnVentaManoObra.Checked)
            {
                //desabiliar los detaes de los productos
                txtCodigoProducto.ReadOnly = true;
                txtPrecio.ReadOnly = true;
                txtCantidad.ReadOnly = true;    
                txtDecripcion.ReadOnly = true;

                //habilitar detalle de mano de obra
                txtPrecioObra.ReadOnly = false;
                txtDescipcionObra.ReadOnly = false;

                //Inabilitar el bton de agregar detalles de los productos
                BtnAddPrduct.Enabled = false;

                //Habilitar el btn de agregar detalles de mano de obra
                BtnAddObra.Enabled = true; 
            }
        }

        private void rBtnClienteRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnVentaProducto.Checked)
            {
                //desabilitar los textbox de  los datos de la mano de obra 
                txtPrecioObra.ReadOnly= true;
                txtDescipcionObra.ReadOnly= true;

                //habilitar detalle de los productos
                txtCodigoProducto.ReadOnly = false;
                txtPrecio.ReadOnly = false;
                txtCantidad.ReadOnly = false;
                txtDecripcion.ReadOnly = false;

                //Inabilitar en boton de agregar detalles de mano de obra
                BtnAddObra.Enabled = false;

                //Habilitar el btn de agregar detalles de productos
                BtnAddPrduct.Enabled = true;
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuVentas frm = new FrmMenuVentas();
            frm.ShowDialog();   
            this.Close();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DG_DetallesdeVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

            


            // Verifica que la descripción no esté vacía
            if (string.IsNullOrWhiteSpace(txtDescipcionObra.Text))
            {
                MessageBox.Show("Descripción no válida. Por favor, ingrese una descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int clientid = idC[this.cmbClientes.SelectedIndex];


            // Si todos los campos son válidos, proceder con la lógica de creación de venta
            int venta = VentaLogic.CrearVenta_Logic(clientid, numeroVenta, txtFechaVenta.Value, montoTotal, cmbMetoodPago.Text);

            if (venta > 0)
            {
              
                // Suma el subtotal al total acumulado
                total += Decimal.Parse(txtPrecioObra.Text);

                // Obtener el id de la venta
                int idVenta = ObtenerIdVenta(numeroVenta);

                int idTipo =idTipoManoObra [this.cmbTipoObra.SelectedIndex];
                // Agregar el detalle de la Mano de obra
                int detail = ManoObra_Logic.AgregarDetalleObra(idVenta, idTipo, txtDescipcionObra.Text, Decimal.Parse(txtPrecioObra.Text));

                if (detail > 0)
                {
                    // Si se crea el detalle de venta correctamente, agrega una nueva fila al DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DG_DetallesdeVenta);

                    // Asigna los valores a cada celda de la fila
                    row.Cells[0].Value = cmbTipoObra.Text+", "+ txtDescipcionObra.Text;     // Descripción del producto
                    row.Cells[1].Value = txtPrecioObra.Text;                 // Precio
                    row.Cells[2].Value = "No Aplica";               // Cantidad
                    row.Cells[3].Value = txtPrecioObra.Text;               // Subtotal

                    // Agrega la fila al DataGridView
                    DG_DetallesdeVenta.Rows.Add(row);

                    // Actualiza el valor del txtMontoTotal con el nuevo total acumulado, formateado
                    txtMontoTotal.Text = total.ToString("0.00"); // Mostrará dos decimales

                    // Mensaje de éxito
                    MessageBox.Show("Detalle agregado exitosamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de agregar el producto
                    cmbTipoObra.SelectedIndex=-1;
                    txtPrecioObra.Clear();
                    txtDescipcionObra.Clear();
                  
                }
            }

        }

        private void rBtnAmbas_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAmbas.Checked)
            {
                //habilitar detalle de mano de obra
                txtPrecioObra.ReadOnly = false;
                txtDescipcionObra.ReadOnly = false;

                //habilitar detalle de los productos
                txtCodigoProducto.ReadOnly = false;
                txtPrecio.ReadOnly = false;
                txtCantidad.ReadOnly = false;
                txtDecripcion.ReadOnly = false;

                //habilitar los botnoes de agregar detalles
                BtnAddPrduct.Enabled = true;
                BtnAddObra.Enabled = true;

            }
        }
    }
    
}
