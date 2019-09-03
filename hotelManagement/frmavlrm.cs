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
    public partial class frmavlrm : Form
    {
        public frmavlrm()
        {
            InitializeComponent();
        }

        private Button btn;
        MySqlConnection connection = new MySqlConnection("server=localhost;database=hotel;uid=root;pwd=;");
        MySqlCommand cmd;
        DataTable table = new DataTable();

        private void frmavlrm_Load(object sender, System.EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("SELECT * from 'ct_room", connection);
                cnnt sc = new cnnt();
                sc.insqry = "SELECT * from 'ct_room";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader[1].ToString() == "rmlux"))
                    {
                        var form = new frmavlrm();
                        // Button btn = (Button)e.Row.FindControl("btnSalvage");
                        form.Controls[Convert.ToInt32(reader[0])].BackColor = Color.Blue;
                        MessageBox.Show("" + reader);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
        }

        private void Button111_Click(object sender, System.EventArgs e)
        {
            try
            {
                foreach (Control c in Controls)
                {
                    ((Button)(btn)).Enabled = true;
                    c.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please close the current window and open it again");
            }

            cnnt sc = new cnnt();
            try
            {

                int nmd = Convert.ToInt32(txtndys.Text);

                string insqry;
                string connt;

                DateTime strdate = dtp1.Value.Date;
                strdate = strdate.AddDays(-11);

                cmd = new MySqlCommand("select * from ct_room ");

                MySqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    if (lblty.Text == Convert.ToString(reader1[3]))
                    {

                    }
                    else
                    {
                        var form = new frmavlrm();
                        form.Controls[Convert.ToInt32(reader1[0])].BackColor = Color.Maroon;
                        form.Controls[Convert.ToInt32(reader1[0])].Enabled = false;
                        foreach (var item in form.Controls)
                        {
                            if (item is Button)
                            {
                                ((Button)item).BackColor = Color.Maroon;
                            }
                        }
                    }

                }

                reader1.Close();

                // insqry = "select * from avltbl where SDate >'" & strdate.Date & "'   "
                cmd = new MySqlCommand("SELECT * FROM `avltbl`");

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime stdate = DateTime.Parse(dtp1.Text);
                    DateTime nextDate = DateTime.Parse(dtp1.Text);
                    for (int i = 1; (i <= nmd); i++)
                    {
                        if ((nextDate == DateTime.Parse(reader[1].ToString())))
                        {
                            var form = new frmavlrm();
                            form.Controls[Convert.ToInt32(reader1[0])].BackColor = Color.Red;
                            form.Controls[Convert.ToInt32(reader1[0])].Enabled = false;
                        }

                        nextDate = nextDate.AddDays(1);
                    }

                    nextDate = DateTime.Parse(dtp1.Text);
                    for (int i = 1; (i <= 10); i++)
                    {
                        if ((nextDate == DateTime.Parse(reader[1].ToString())))
                        {
                            if ((Convert.ToInt32(reader[2]) > (i - 1)))
                            {
                                var form = new frmavlrm();
                                form.Controls[Convert.ToInt32(reader1[0])].BackColor = Color.Red;
                                form.Controls[Convert.ToInt32(reader1[0])].Enabled = false;
                            }

                        }

                        nextDate = nextDate.AddDays(-1);
                    }

                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }

        }

        private void rm001_Click(object sender, System.EventArgs e)
        {
            // FrmStaff.rmd = sender.name;
            this.Close();
        }

        private void txtrid_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void rm023_Click(object sender, System.EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmStaff();
            Frm.Show();
        }
    }
}