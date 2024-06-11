﻿using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeEntrega
{
    public class ConfirmarOrdenDeEntregaModelo
    {
        public List<OrdenDeEntregaEntidad> ObtenerOrdenesDeEntregaEnTransito()
        {
            return OrdenesDeEntregaAlmacen.ObtenerOrdenesEnEstadoEnTransito();
        }

        public void FinalizarOrdenDeEntrega(int idOrden)
        {
            OrdenesDeEntregaAlmacen.FinalizarOrdenPorIdOrden(idOrden);
        }

        public void FinalizarOrdenDePreparacion(int idOrdenDeEntrega)
        {
            OrdenDeEntregaEntidad ordenDeEntrega = OrdenesDeEntregaAlmacen.ObtenerOrdenPorId(idOrdenDeEntrega);

            foreach (var orden in ordenDeEntrega.OrdenesDePreparacion)
            {
                ActualizarOrdenDePreparaciónHaciaDespachado(orden);
            }
        }

        private void ActualizarOrdenDePreparaciónHaciaDespachado(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.Despachada);
        }
    }
}
