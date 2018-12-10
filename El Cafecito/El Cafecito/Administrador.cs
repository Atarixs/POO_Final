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
    public partial class Administradorfrm : Form
    {
        private SQLiteConn conn;

        int Total = 0;

        List<Products> SaleList = new List<Products>();
        List<Products> Search = new List<Products>();

        public Administradorfrm(string username)
        {
            
            InitializeComponent();
            cmbuser.Text = username;
            conn = new SQLiteConn("Terminal de venta.db", true);
            int trans = 0;
            trans = conn.GetSalesByRecord() + 1;
            label_NumeroDeVenta.Text = Convert.ToString(trans);

            txtPaid.Text = "0.00";
            lblTotal.Text = "0.00";
            lblChange.Text = "0.00";

            ResetProducts();
            ShoppingList();
            date.Value = DateTime.Today;

            cbPayment.DisplayMember = "transactionType";
            cbPayment.ValueMember = "transactionID";
            cbPayment.DataSource = conn.GetPaymentType();
        }

        private void Administradorfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ventaPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas_por_Producto vpp = new Ventas_por_Producto();
            vpp.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
           p.ShowDialog();
        }

        private void ventasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas_por_fecha vpf = new Ventas_por_fecha();
            vpf.ShowDialog();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search.Clear();

            if (Int32.TryParse(txtsearch.Text, out int id))
            {
                foreach (Products product in conn.GetProducts())
                {
                    if (product.ProductID == id)
                    {
                        Search.Add(product);
                    }
                }
            }

            else if (txtsearch.Text is string)
            {
                foreach (Products product in conn.GetProducts())
                {
                    if (product.Descripcion.Contains(txtsearch.Text))
                    {
                        Search.Add(product);
                    }
                }

            }

            lstProducts.DataSource = null;
            lstProducts.DisplayMember = "descripcion";
            lstProducts.ValueMember = "ProductID";
            lstProducts.DataSource = Search;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {

                SaleList.Add(conn.GetProductsByName(lstProducts.Text));
                i++;
                Total += conn.GetProductsByName(lstProducts.Text).Price;

            }
            while (nudqty.Value != i);

            ShoppingList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Total -= SaleList[lstSales.SelectedIndex].Price;
            SaleList.RemoveAt(lstSales.SelectedIndex);
            ShoppingList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la venta?", "Procesar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ClearPOS();
            }
        }

        public void ResetProducts()
        {
            lstProducts.DisplayMember = "descripcion";
            lstProducts.ValueMember = "productID";
            lstProducts.DataSource = conn.GetProducts();
        }

        public void ShoppingList()
        {
            lstSales.DataSource = null;
            lstSales.DisplayMember = "descripcion";
            lstSales.ValueMember = "productID";
            lstSales.DataSource = SaleList;

            lblChange.Text = String.Format("{0:0.00}", Total);
            lblTotal.Text = String.Format("{0:0.00}", Total);

            double Cambio = Total - Convert.ToDouble(txtPaid.Text);

            if (Cambio < 0)
            {
                lblDet.Text = "Cambio:";
                lblChange.Text = String.Format("{0:0.00}", -Cambio);
            }

            else
            {
                lblDet.Text = "Restante: ";
                lblChange.Text = String.Format("{0:0.00}", Cambio);
            }

        }

        public void ClearPOS()
        {
            SaleList.Clear();
            Total = 0;
            txtPaid.Text = "0.00";
            ResetProducts();
            ShoppingList();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtPaid.Text)))
            {
                txtPaid.Text = String.Format("{0:0.00}", 0);
            }

            else if (Int32.TryParse(txtPaid.Text, out int Val))
            {
                txtPaid.Text = String.Format("{0:0.00}", Convert.ToUInt32(txtPaid.Text));
            }

            ShoppingList();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea comfirmar la venta?", "Procesar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.AddSale(new Sales(conn.GetSalesByRecord() + 1, date.Value.ToShortDateString(), Convert.ToInt32(cmbuser.Text), Convert.ToInt32(cbPayment.Text)));

                foreach (Products product in conn.GetProducts())
                {
                    int counter = 0;

                    foreach (Products productSold in SaleList)
                    {
                        if (product.ProductID == productSold.ProductID)
                        {
                            counter++;
                        }
                    }

                    if (counter > 0)
                    {
                        conn.AddSaleByP(new SalesByProduct(conn.GetSalesByRecord(), product.Descripcion, counter, conn.GetPrice()));
                    }

                }

                int trans = 0;
                trans = conn.GetSalesByRecord() + 1;
                label_NumeroDeVenta.Text = Convert.ToString(trans);
                ClearPOS();
            }
        }
    }

}
