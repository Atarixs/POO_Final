using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;


namespace El_Cafecito
{
    public partial class Productos : Form
    {
        bool Cambio = false;
        ListBox lst;
        SQLiteConn conn;
        Products producto;

        public Productos()
        {
            InitializeComponent();
            conn = new SQLiteConn("Terminal de venta.db", true);
            lstProductos.Items.Add(conn.GetProducts());
            producto = lstProductos.SelectedItem as Products;

            lstProductos.DisplayMember = "Descripcion";
            lstProductos.ValueMember = "Id";
            lstProductos.DataSource = conn.GetProducts();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Products po = lstProductos.SelectedItem as Products;
            txtID.Text = Convert.ToString(po.ProductID);
            txtProducto.Text = po.Descripcion;
            txtCategoria.Text = Convert.ToString(po.CategoryID);
            txtPrecio.Text = Convert.ToString(po.Price);
            txtStock.Text = Convert.ToString(po.Stock);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Cambio == true)
            {
                Close();
            }

            else
            {
                if (MessageBox.Show("No se realizo ningun arribo de producto, ¿Desea continuar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void btnArribo_Click(object sender, EventArgs e)
        {
            conn.AñadirProduct(Convert.ToInt32(nunCantidad.Value), lstProductos.SelectedItem as Products, Convert.ToInt32(txtStock.Text));
            this.Close();
        }
    }
}
