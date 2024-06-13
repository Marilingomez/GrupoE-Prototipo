﻿using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.ConsultaDisponibilidad;
using GrupoE_Protitipos.ConsultarOrdenes;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDePreparacion
{
    internal class OrdenDePreparacionModelo

    {
        public string ValidarDatosOrden (int cantidadDeItems, string deposito, string cuitCliente)
        {
            // string errores = Validadores.EsNumero(cantidad, "Cantidad") + Environment.NewLine;
            string errores = Validadores.ValidarListaConDatos(cantidadDeItems, "Detalle de productos") + Environment.NewLine;
            errores += Validadores.EstaVacio(deposito, "Deposito") + Environment.NewLine;
            errores += Validadores.EstaVacio(cuitCliente, "Cuit del Cliente") + Environment.NewLine;

            return errores;

        }

        public int ObtenerNuevoId()
        {
            return OrdenDePreparacionAlmacen.ObtenerIdParaNuevaOrden();
        }

        public void CrearNuevaOrdenDePreparacion(
            string idOrden,
            string cuitCliente,
            string fecha,
            string deposito,
            ListView.ListViewItemCollection detalleDeProductos
            )
        {
            ClienteEntidad cliente = ClienteAlmacen.ObtenerClientePorCuit(cuitCliente);
            List<DetalleOrdenDePreparacion> detalleOrden = ObtenerDetalleDeOrden(detalleDeProductos);
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(deposito);

            OrdenDePreparacionEntidad nuevaOrden = new OrdenDePreparacionEntidad(
                int.Parse(idOrden),
                cuitCliente,
                DateTime.Now,
                cliente.Prioridad,
                idDeposito,
                OrdenDePreparacionEstado.Pendiente,
                detalleOrden
                );

            AgregarOrden(nuevaOrden);
        }

        public void AgregarOrden(OrdenDePreparacionEntidad nuevaOrden)
        {
            OrdenDePreparacionAlmacen.AgregarOrden(nuevaOrden);
        }

        public string ValidarDatosProducto(string cantidad, string producto)
        {
            string errores = "";

            errores += Validadores.EsNumero(cantidad, "Cantidad") + Environment.NewLine;
            errores += Validadores.EstaVacio(producto, "Producto");

            return errores;
        }

        private List<DetalleOrdenDePreparacion> ObtenerDetalleDeOrden(ListView.ListViewItemCollection items)
        {
            List<DetalleOrdenDePreparacion> detalleOrdenes = new();

            foreach (ListViewItem item in items)
            {
                int cantidad = int.Parse(item.SubItems[2].Text);

                var detalle = new DetalleOrdenDePreparacion
                {
                    IdProducto = int.Parse(item.SubItems[0].Text),
                    Cantidad = cantidad
                };

                detalleOrdenes.Add(detalle);
            }

            return detalleOrdenes;
        }

        public List<string> ObtenerListaDeDepositos()
        {
            List<DepositoEntidad> depositos = DepositoAlmacen.ObtenerDepositos();
            List<string> listaDepositos = new();

            foreach (var deposito in depositos)
            {
                listaDepositos.Add(deposito.Provincia);
            }

            return listaDepositos;
        }

        public List<string> ObtenerListaDeCliente()
        {
            List<ClienteEntidad> clientes = ClienteAlmacen.ObtenerClientes();
            List<string> listaClientes = new();

            foreach (var cliente in clientes)
            {
                listaClientes.Add(cliente.CuitCliente);
            }

            return listaClientes;
        }

        public List<string> ObtenerListaDeProductos()
        {
            List<ProductoEntidad> productos = ProductoAlmacen.ObtenerProductos();
            List<string> listaProductos = new();

            foreach (var producto in productos)
            {
                listaProductos.Add(producto.Descripcion);
            }

            return listaProductos;
        }

        public int ObtenerIdDelProductoPorNombre(string descripcion)
        {
            return ProductoAlmacen.ObtenerIdPorDescripcion(descripcion);
        }

        public string ValidarExistenciaDeProducto(string cuitCliente, string nombreProducto, int cantidadProducto, string nombreDeposito)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(nombreDeposito);
            int idProducto = ProductoAlmacen.ObtenerIdPorDescripcion(nombreProducto);

            int cantidadEnAlmacen = 
                InventarioAlmacen.ObtenerCantidadDeProductoPorClienteYDeposito(cuitCliente, idProducto, idDeposito);

            if(cantidadEnAlmacen < cantidadProducto)
            {
                return "- Cantidad solicitada: " + cantidadProducto + "." + Environment.NewLine +
                    "- Cantidad en almacen disponible: " + cantidadEnAlmacen + ".";
            }
            return "";
        }
   
        public string ValidarCampos(string cuitCliente, string deposito)
        {
            string errores = "";
            errores += Validadores.EstaVacio(cuitCliente, "Cuit Cliente") + Environment.NewLine;
            errores += Validadores.EstaVacio(deposito, "Deposito");

            return errores;
        }

        public void PrereservaDeProducto(string cuitCliente, string nombreDeposito, int cantidad, string nombreProducto)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(nombreDeposito);
            int idProducto = ProductoAlmacen.ObtenerIdPorDescripcion(nombreProducto);

            InventarioAlmacen.GenerarPrereservaDeProducto(cuitCliente, idProducto, idDeposito, cantidad);
        }

        public void CancelarPrereservaDeProducto(string cuitCliente, string nombreDeposito, int cantidad, int idProducto)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(nombreDeposito);

            InventarioAlmacen.CancelarPrereservaDeProducto(cuitCliente, idProducto, idDeposito, cantidad);
        }
    }
}