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
    public partial class Login : Form
    {
        Administradorfrm admin;
        Ventas_El_Cafecito ventasfrm;

        private SQLiteConn conn;

        public Login()
        {
            InitializeComponent();

            conn = new SQLiteConn("Terminal de venta.db", true);

            cmbUsers.DisplayMember = "username";
            cmbUsers.ValueMember = "userid";
            cmbUsers.DataSource = conn.GetUsername();

            btnLogin.Enabled = false;
            

        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            int pass = Convert.ToInt32(txtPassword.Text);

            if (pass == conn.GetPassword((int)cmbUsers.SelectedValue))
            {
                conn.GetRole(pass);
            }

            

            int roles = conn.GetRole(pass);

            if (roles == 3)
            {
                MessageBox.Show("Lo siento contraseña incorrecta");
                txtPassword.Clear();
            }
            else if (roles == 0)
            {
                admin = new Administradorfrm(cmbUsers.Text);
                admin.Show();
                this.Hide();

                txtPassword.Clear();
            }
            else if (roles == 1)
            {
                ventasfrm = new Ventas_El_Cafecito(cmbUsers.Text);
                ventasfrm.Show();
                this.Hide();
                txtPassword.Clear();
            }


        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             conn.GetPassword((int)cmbUsers.SelectedValue);
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPassword.Text == "")
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }
    }
    }

