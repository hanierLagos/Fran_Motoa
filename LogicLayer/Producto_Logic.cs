﻿using DataLayer;
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
        ////metodo para actualozar producto desde la ventana de editar
        //public static int CrearProducto_Logic(string codigo, string nombre, Decimal precio, int marcaId, int categoriaId, int cantidad)
        //{
        //    Productos p = new Productos();
        //    p.CODIGO_PRODUCTO = codigo;
        //    p.NOMBRE_PRODUCTO = nombre;
        //    p.PRECIO=precio;
        //    p.ID_MARCA = marcaId;
        //    p.ID_CATEGORIA = categoriaId;
        //    p.CANTIDAD = cantidad;

        //    Producto_Data pd = new Producto_Data();

        //    // Verificar si el producto existe
        //    if (pd.ReadProducto(codigo) == null) // Si no hay filas, significa que no existe
        //    {
        //        return pd.CrearProducto(p);
        //    }
        //    else
        //    {
        //        return pd.ActualizarProducto(p);
        //    }
        //}

        //Metodo para actualizar producto desde la entrada, a diferencia del metodo anterior este actualiza la cantidad del producto entrante sumnando la cantidad qeu se regitra al entrar
        public static int CrearProductoEntrada_Logic(string codigo, string nombre, Decimal precio, int marcaId, int categoriaId, int cantidad)
        {
            Productos p = new Productos();
            p.CODIGO_PRODUCTO = codigo;
            p.NOMBRE_PRODUCTO = nombre;
            p.PRECIO = precio;
            p.ID_MARCA = marcaId;
            p.ID_CATEGORIA = categoriaId;
            p.CANTIDAD = cantidad;

            Producto_Data pd = new Producto_Data();

            if (pd.ReadProducto(codigo) == null) // Si no hay filas, significa que no existe
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


        public static DataTable MostrarProductos()
        { 
            Producto_Data data = new Producto_Data();
            return data.MostrarProductos();
        }

        public static DataTable VerProductos()
        {
            Producto_Data data = new Producto_Data();
            return data.VerProductos();

        }

        //Metodo para verificar la cantidad del producto antes de hacer una venta
        public static bool VerificarDisponibilidadProducto( int cantidadSolicitada, string codigo)
        {
            int cantidadDisponible = Producto_Data.ObtenerCantidadDisponibleProducto(codigo);

            // Verificar si hay suficiente inventario
            if (cantidadDisponible >= cantidadSolicitada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }//Fin de la clase
}
