using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Pedido
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { set; get; }
        public string TipoPago { get; set; }

        public double Recargo { set; get; }
        public double Descuento { set; get; }
        public double PrecioFinal { set; get; }

        public Pedido() { }

        public Pedido(string producto, string tipopago, int cantidad, double precio, double recargo, double descuento, double preciofinal)
        {
            Producto = producto;
            TipoPago = tipopago;
            Cantidad = cantidad;
            Precio = precio;
            Recargo = recargo;
            Descuento = descuento;
            PrecioFinal = preciofinal;

        }

    }
}