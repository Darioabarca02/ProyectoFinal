using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MostrarDatos : Form
    {

        public Pedidos pedidos = new Pedidos();
        public Pedido pedido = new Pedido();
        public MostrarDatos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvDatosAlmacenados.DataSource = pedidos.Imprimir();
        }
    }
}
