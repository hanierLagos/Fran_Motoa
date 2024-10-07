using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class Producto_Logic
    {
        //metodo para actualozar producto desde la ventana de editar
        public static int CrearProducto_Logic(string codigo, string nombre, Decimal precio, int marcaId, int categoriaId, int cantidad)
        {
            Productos p = new Productos
            {
                CODIGO_PRODUCTO = codigo,
                NOMBRE_PRODUCTO = nombre,
                PRECIO = precio,
                ID_MARCA = marcaId,
                ID_CATEGORIA = categoriaId,
                CANTIDAD = cantidad
            };

            Producto_Data pd = new Producto_Data();

            // Verificar si el producto existe
            DataTable existingProduct = pd.ReadProducto(codigo);
            if (existingProduct==null) // Si no hay filas, significa que no existe
            {
                return pd.CrearProducto(p);
            }
            else
            {
                return pd.ActualizarProducto(p);
            }
        }

        //Metodo para actualizar producto desde la entrada
        public static int CrearProductoEntrada_Logic(string codigo, string nombre, Decimal precio, int marcaId, int categoriaId, int cantidad)
        {
            Productos p = new Productos
            {
                CODIGO_PRODUCTO = codigo,
                NOMBRE_PRODUCTO = nombre,
                PRECIO = precio,
                ID_MARCA = marcaId,
                ID_CATEGORIA = categoriaId,
                CANTIDAD = cantidad
            };

            Producto_Data pd = new Producto_Data();

            // Verificar si el producto existe
            DataTable existingProduct = pd.ReadProducto(codigo);
            if (existingProduct == null) // Si no hay filas, significa que no existe
            {
                return pd.CrearProducto(p);
            }
            else
            {
                return pd.ActualizarProductoEntrada(p);
            }
        }

        // Método para obtener productos aplicando un filtro (por código de producto)
        public static DataTable GetProductoLogic(string filter)
        {
            // Crear una instancia de la capa de datos
            Producto_Data pd = new Producto_Data();

            // Llamar al método de búsqueda de la capa de datos con el filtro proporcionado
            return pd.LeerProducto(filter);
        }

        // Método para obtener los últimos productos añadidos
        public static DataTable ReadTopProductoLogic(int val)
        {
            // Crear una nueva instancia de la capa de datos
            Producto_Data pd = new Producto_Data();

            // Invocar al método para obtener los últimos productos agregados
            return pd.ReadLastProducto(val);
        }

        // Método para buscar productos por nombre
        public static DataTable BuscarProductoPorNombreLogic(string nombre)
        {
            Producto_Data productoData = new Producto_Data();
            return productoData.BuscarProductoPorNombre(nombre);
        }

        // Método para eliminar productos (cambiar su estado a inactivo)
        public static int EliminarProductoLogic(string codigo)
        {
            Producto_Data pd = new Producto_Data();
            return pd.EliminarProducto(codigo);
        }

        //Metodo pra obtener id del producto
        public static DataTable ObtenerIdProducto()
        { 
            Producto_Data pd = new Producto_Data();
            return pd.ObtenerIdProducto();
        
        }

    }
}
