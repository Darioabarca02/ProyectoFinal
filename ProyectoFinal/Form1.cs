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
    public partial class Form1 : Form
    {
        Pedidos pedidos = new Pedidos();
        double precio = 0;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cmbProductos.Text;
            if (producto.Equals("Coleccion Escolar")) precio = 250;
            if (producto.Equals("Coleccion PreUniversitaria")) precio = 150;
            if (producto.Equals("Coleccion Profesional")) precio = 350;
            lblPrecio.Text = precio.ToString("C");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)

        {
            Pedido pedido = new Pedido();
            pedido.Cantidad = Convert.ToInt32(txtCantidad.Text);
            pedido.Producto = cmbProductos.SelectedItem.ToString();
            pedido.TipoPago = cmbTipo.SelectedIndex.ToString();
            pedidos.AddPed(pedido);
            

            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe selecionar un producto.....");
            }
            else
                if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe selecionar una cantidad.....");
            }
            else
                if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe selecionar un tipo.....");
            }
            else
            {
                string producto = cmbProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cmbTipo.Text;
                double subtotal = cantidad * precio;
                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado") || tipo.Equals("Transferencia"))
                {
                    descuento = 0.05 * subtotal;
                }
                else
                {
                    recargo = 0.1 * subtotal;
                }
                double precioFinal = subtotal - descuento + recargo;
                cmbProductos.Text = " ";
                cmbTipo.Text = " ";
                txtCantidad.Text = " ";
                pedido.Precio = precio;
                pedido.Recargo = recargo;
                pedido.PrecioFinal = precioFinal;


            }
            MessageBox.Show("Datos almacenados correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbProductos.Text = " ";
            cmbTipo.Text = " ";
            txtCantidad.Text = " ";
            lblPrecio.Text = (0).ToString("C");

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
