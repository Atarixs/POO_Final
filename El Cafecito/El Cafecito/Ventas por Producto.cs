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
    public partial class Ventas_por_Producto : Form
    {
        private SQLiteConn conn;

        public Ventas_por_Producto()
        {
            InitializeComponent();

            conn = new SQLiteConn("Terminal de venta.db", true);

        }

        private void rdbVendido_CheckedChanged(object sender, EventArgs e)
        {
            cmbProd.DisplayMember = "producto";
            cmbProd.DataSource = conn.GetProductBest();

            cmbVendidos.DisplayMember = "quantity";
            cmbVendidos.DataSource = conn.GetProductBest();

            cmbIngresogen.DisplayMember = "price";
            cmbIngresogen.DataSource = conn.GetProductBest();
        }

        private void rdbNoVendido_CheckedChanged(object sender, EventArgs e)
        {
            cmbProd.DisplayMember = "producto";
            cmbProd.DataSource = conn.GetProductLow();

            cmbVendidos.DisplayMember = "quantity";
            cmbVendidos.DataSource = conn.GetProductLow();

            cmbIngresogen.DisplayMember = "price";
            cmbIngresogen.DataSource = conn.GetProductLow();
        }

        private void rdbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            cmbProd.DisplayMember = "producto";
            cmbProd.DataSource = conn.GetProductPricetop();

            cmbVendidos.DisplayMember = "quantity";
            cmbVendidos.DataSource = conn.GetProductPricetop();

            cmbIngresogen.DisplayMember = "price";
            cmbIngresogen.DataSource = conn.GetProductPricetop();
        }

        private void rdbNoIngreso_CheckedChanged(object sender, EventArgs e)
        {
            cmbProd.DisplayMember = "producto";
            cmbProd.DataSource = conn.GetProductbadprice();

            cmbVendidos.DisplayMember = "quantity";
            cmbVendidos.DataSource = conn.GetProductbadprice();

            cmbIngresogen.DisplayMember = "price";
            cmbIngresogen.DataSource = conn.GetProductbadprice();
        }
    }
}
