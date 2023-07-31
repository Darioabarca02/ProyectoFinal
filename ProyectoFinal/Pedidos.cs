using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Pedidos
    {
        public List<Pedido> Listpedidos { get; set; }

        public Pedidos()
        {
            Listpedidos = new List<Pedido>();
        }

        public void AddPed(Pedido pedido)
        {
            Listpedidos.Add(pedido);
        }

    }
}
