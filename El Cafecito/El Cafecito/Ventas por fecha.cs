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
    public partial class Ventas_por_fecha : Form

    {
        private SQLiteConn conn;

        List<Sales> SByDate = new List<Sales>();
        int SelectedTotal = 0;

        public Ventas_por_fecha()
        {
            InitializeComponent();

            conn = new SQLiteConn("Terminal de venta.db", true);

            cmbFilter.Items.Add("Sin Filtro");
            cmbFilter.Items.Add("Dia");
            cmbFilter.Items.Add("Mes");
            cmbFilter.Items.Add("Año");
        }

        public void ReloadSales()
        {
            listVentas.DataSource = null;
            listVentas.DisplayMember = "recordID";
            listVentas.ValueMember = "recordID";
            listVentas.DataSource = SByDate;

            SelectedTotal = conn.GetSalesTotal(Convert.ToInt32(listVentas.Text));
        }

        public void ReloadDates()
        {
            listVentas.DataSource = null;
            listVentas.DisplayMember = "date_sale";
            listVentas.ValueMember = "record_id";
            listVentas.DataSource = SByDate;
        }

        public void SortByDate()
        {
            SByDate.Clear();

            if (cmbFilter.SelectedIndex == 1)
            {
                foreach (Sales sale in conn.GetSales())
                {
                    String[] filter = dtPick.Text.Split('/');
                    String[] args = sale.Date.Split('/');

                    if (filter[0] == args[0] && Convert.ToInt32(filter[1]) <= Convert.ToInt32(filter[1])
                        && Convert.ToInt32(filter[2]) <= Convert.ToInt32((args[2])))
                    {
                        SByDate.Add(sale);
                    }
                }
            }

            else if (cmbFilter.SelectedIndex == 2)
            {
                foreach (Sales sale in conn.GetSales())
                {
                    String[] filter = dtPick.Text.Split('/');
                    String[] args = sale.Date.Split('/');

                    if (filter[1] == args[1] && Convert.ToInt32(filter[2]) <= Convert.ToInt32((args[2])))
                    {
                        SByDate.Add(sale);
                    }
                }
            }

            else if (cmbFilter.SelectedIndex == 3)
            {
                foreach (Sales sale in conn.GetSales())
                {
                    String[] filter = dtPick.Text.Split('/');
                    String[] args = sale.Date.Split('/');

                    if (filter[2] == args[2])
                    {
                        SByDate.Add(sale);
                    }
                }
            }

            ReloadSales();
            ReloadDates();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortByDate();
        }

        private void dtPick_ValueChanged(object sender, EventArgs e)
        {
            ReloadDates();
        }
    }
}
