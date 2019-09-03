using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;database=hotel;uid=root;pwd=;");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT `Id`, `Paswrd` FROM `logtbl` WHERE `Id` = '" + username.Text + "' AND `Paswrd` = '" + password.Text + "'", connection);
            adapter.Fill(table);
            
            if (table.Rows.Count <= 0)
            {
                label1.Text = "Username Or Password Are Invalid";
            }
            else
            {
                Form Frm = new FrmStaff();
                Frm.Show();
                this.Visible = false;
            }
            table.Clear();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}