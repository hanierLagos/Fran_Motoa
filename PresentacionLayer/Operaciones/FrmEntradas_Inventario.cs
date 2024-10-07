using BussinesLayer;
using LogicLayer;
using PresentacionLayer.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentacionLayer.Operaciones
{
    public partial class FrmEntradas_Inventario : Form
    {
        private List<int> idM = new List<int>();
        private List<int> idC = new List<int>();
        public FrmEntradas_Inventario()
        {
            InitializeComponent();
            CargarMarcaComboBox();
            CargarCategoriaComboBox();
        }

        //Metodo para limpiar los campos de producto
        private void ClearTextBoxes()
        {
            mskCodigo.Clear();
            txtNombre.Clear();
            cmbMarca.SelectedIndex=-1;
            cmbCategoria.SelectedIndex = -1;
            txtCantidad.Clear();
            txtPrecioEntrada.Clear();
            txtPrecioProducto.Clear();
        }

        //Metodo para desactivar la escritura en los campos productos
        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            txtNombre.ReadOnly = isReadOnly;
            cmbMarca.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            mskCodigo.Focus();
        }

        //Metodo para cargar el nuevo numero de entrada
        private void CargarNumeroEntrada()
        {
            try
            {
                // Llama al método de la lógica de negocios obtener el próximo número de etrada
                int nextNumber = Entrada_InventarioLogic.ObtenerNumeroEntrada();

                // Asigna el número obtenido al campo de texto txtN_Buy
                txtNumeroEntrada.Text = nextNumber.ToString();
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción que pueda ocurrir durante la obtención del número de entrada
                MessageBox.Show("Error al obtener el próximo número de Entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Metodo para cargar las marcas existentes en un ComboBox
        private void CargarMarcaComboBox()
        {
            //Cargar el listado de las marcas       
            foreach (DataRow r in Marca_Logic.ObtenerIdMarca().Rows)
            {
                //Cargar los nombres de las marcas
                cmbMarca.Items.Add(r["NOMBRE_MARCA"].ToString());
                idM.Add(int.Parse(r["ID_MARCA"].ToString()));
            }//Fin de la instrucción foreach
        }

        //Metodo para cargar las categorias existentes en un ComboBox
        private void CargarCategoriaComboBox()
        {

            //Cargar el listado de las categorias       
            foreach (DataRow r in Categoria_Logic.ObtenerIdCategoria().Rows)
            {
                //Cargar los nombres de las categorias
                cmbCategoria.Items.Add(r["NOMBRE_CATEGORIA"].ToString());
                idC.Add(int.Parse(r["ID_CATEGORIA"].ToString()));
            }//Fin de la instrucción foreach     
        }
        private void FrmEntradas_Inventario_Load(object sender, EventArgs e)
        {
            //Cargar numero de entrada
            CargarNumeroEntrada();

        }

        private void radioBtnExistente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnExistente.Checked)
            {
                //Lmpiar todos los campos y desactivarlos en cas de que sea un producto existente para haer la busqueda
                ClearTextBoxes();
                SetTextBoxReadOnly(true);
            }
        }

        private void radioBtnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNuevo.Checked)
            {
                mskCodigo.Focus();
                SetTextBoxReadOnly(false);

            }
        }

        private void CargarProductosTextBox(string codigo)
        {
            try
            {
                // Obtener los datos de los productos buscados po codigo
                DataTable productoData = Producto_Logic.GetProductoLogic(codigo);

                if (productoData == null || productoData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registro del producto especificado: " + codigo, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataRow row = productoData.Rows[0];
                    txtNombre.Text = row["NOMBRE_PRODUCT"].ToString(); 
                    cmbMarca.Text = row["NOMBRE_MARCA"].ToString(); 
                    cmbCategoria.Text = row["NOMBRE_CATEGORIA"].ToString();  
                    txtPrecioProducto.Text = row["PRECIO_PRODUCTO"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mskCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si se produce el evento al presionar la tecla Enter, se manda a llamar el método encargado de buscar
            if (e.KeyChar == (char)Keys.Enter)
            {
               CargarProductosTextBox(mskCodigo.Text);
                txtCantidad.Focus();
                e.Handled = true; 
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(mskCodigo.Text))
                {
                    MessageBox.Show("El código del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Decimal.TryParse(txtPrecioProducto.Text, out Decimal precioProducto) || precioProducto <= 0)
                {
                    MessageBox.Show("El precio del producto debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroEntrada.Text) || !int.TryParse(txtNumeroEntrada.Text, out int numeroEntrada))
                {
                    MessageBox.Show("El número de entrada es obligatorio y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtxDescripcion.Text))
                {
                    MessageBox.Show("La descripción de la entrada es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Decimal.TryParse(txtPrecioEntrada.Text, out Decimal precioEntrada) || precioEntrada <= 0)
                {
                    MessageBox.Show("El precio de entrada debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Primero se guarda o actualiza el producto
                int selectedMarca = idM[cmbMarca.SelectedIndex];
                int selectedCategoria = idC[cmbCategoria.SelectedIndex];

                int valpro = Producto_Logic.CrearProductoEntrada_Logic(
                    mskCodigo.Text,
                    txtNombre.Text,
                    precioProducto,
                    selectedMarca,
                    selectedCategoria,
                    cantidad
                );

               

                // Luego se guarda la entrada de inventario
                int val = Entrada_InventarioLogic.CrearEntrada_Logic(numeroEntrada, txtFechaEntrada.Value, txtxDescripcion.Text);
               

                // Luego el detalle de la entrada
                int idProducto = ObtenerIdProducto(mskCodigo.Text);  // Obtiene el ID del producto
                int idEntrada = ObtenerIdEntrada(numeroEntrada);     // Obtiene el ID de la entrada

                if (idProducto <= 0 || idEntrada <= 0)
                {
                    MessageBox.Show("Error al obtener el ID del producto o entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int detalle = Detalle_EntradaLogic.AgregarDetalleEntrada(idEntrada, idProducto, cantidad, precioEntrada, precioProducto);


                // Actualización del DataGridView con los nuevos datos del producto
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DG_ProductosEntrantes);

                // Asigna los valores a cada celda de la fila
                row.Cells[0].Value = mskCodigo.Text;                // Código del producto
                row.Cells[1].Value = txtNombre.Text;                // Nombre del producto
                row.Cells[2].Value = cmbMarca.SelectedItem.ToString(); // Marca del producto (desplegable)
                row.Cells[3].Value = cmbCategoria.SelectedItem.ToString(); // Categoría del producto (desplegable)
                row.Cells[4].Value = cantidad;                      // Cantidad
                row.Cells[5].Value = precioEntrada;                 // Precio de entrada
                row.Cells[6].Value = precioProducto;                // Precio de venta

                // Agrega la fila al DataGridView
                DG_ProductosEntrantes.Rows.Add(row);


                // Mensaje final de éxito
                MessageBox.Show("Producto agregado correctamente al inventario. Inventario actualizado.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
            CargarMarcaComboBox();
        }

        private void BtnNuevaCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.ShowDialog();
            CargarCategoriaComboBox();
        }

        /// <summary>
        /// METODO PARA OBTENER ID DEL PRODUCTO
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

            // Retorna el ID del insumo convertido a entero
            return Convert.ToInt32(rows[0]["ID_PRODUCTO"]);
        }


        /// <summary>
        /// METODO PARA OBTENER ID DE LA ENTRADA
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private int ObtenerIdEntrada(int numero)
        {
            // Obtiene el DataTable con los datos de la entrada usando el código proporcionado
            DataTable entradaDataTable = Entrada_InventarioLogic.ObtenerIdEntrada();

            // Verifica si el DataTable es nulo o está vacío
            if (entradaDataTable == null || entradaDataTable.Rows.Count == 0)
            {
                // Lanza una excepción si no se encuentra la entrada
                throw new Exception("No se encontró la entrada con el numero especificado: " + numero);
            }

            // Busca el índice de la entrada con el numero especificado
            DataRow[] rows = entradaDataTable.Select($"NUMERO_ENTRADA = '{numero}'");
            if (rows.Length == 0)
            {
                throw new Exception("No se encontró la entrada con el numero especificado: " + numero);
            }

            // Retorna el ID del insumo convertido a entero
            return Convert.ToInt32(rows[0]["ID_ENTRADA"]);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFinalizarEntrada_Click(object sender, EventArgs e)
        {
            // Finalizar la entrada
            if (DG_ProductosEntrantes.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de finalizar la entrada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No continuar si no hay productos
            }

            if (string.IsNullOrWhiteSpace(txtxDescripcion.Text))
            {
                MessageBox.Show("Debe agregar una descripción para la entrada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtxDescripcion.Focus(); // Enfocar en la descripción
                return; // No continuar si no hay descripción
            }

            int val = Entrada_InventarioLogic.CrearEntrada_Logic(int.Parse(txtNumeroEntrada.Text), txtFechaEntrada.Value, txtxDescripcion.Text);
            if (!(val > 0))
            {
                MessageBox.Show("Entrada agregada correctamente. Entrada Finalizada.",
                   "Finalizar Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el número de entrada
                CargarNumeroEntrada();

                // Limpiar los campos
                txtxDescripcion.Clear();

                // Limpiar la tabla 
                DG_ProductosEntrantes.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar la entrada. Intente nuevamente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
