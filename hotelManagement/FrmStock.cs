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
    public partial class FrmStock : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password='';database=hotel");
        DataTable dt = new DataTable();
        DataRow dr;

        public FrmStock()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                dr = dt.NewRow();
                int totalValue;
                totalValue = int.Parse(quantity.Text) * int.Parse(unitPrice.Text);
                totaltxt.Text = totalValue.ToString();
                dr["Product ID"] = productID.Text;
                dr["Quantity"] = quantity.Text;
                dr["Unit Price"] = unitPrice.Text;
                dr["Total"] = totaltxt.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void clear()
        {
            productID.Text = "";
            quantity.Text = "";
            unitPrice.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    {
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `insert`(`productID`, `quantity`, `UnitPrice`, `Total`) VALUES(@productID, @quantity, @unitPrice,@Total)", connection))
                        {
                            cmd.Parameters.AddWithValue("@productID", row.Cells["Product ID"].Value);
                            cmd.Parameters.AddWithValue("@quantity", row.Cells["Quantity"].Value);
                            cmd.Parameters.AddWithValue("@UnitPrice", row.Cells["Unit Price"].Value);
                            cmd.Parameters.AddWithValue("@Total", row.Cells["Total"].Value);
                            connection.Open();

                            try
                            {
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Data Inserted");
                                }
                                else
                                {
                                    MessageBox.Show("Data Not Inserted");
                                }
                            }
                            catch (Exception ex)
                            {
                                
                            }

                            connection.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void FrmStock_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Product ID");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Total");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = ("UPDATE `insert` SET " + (quantity.Text + ("= \'" + (unitPrice.Text + ("\' WHERE `productID`= \'" + (productID.Text + "\'"))))));
            sc.cnntotbl();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    cnnt sc = new cnnt();
                    sc.insqry = ("select * from insert where productID='" + (productID.Text + "' "));
                    sc.schfn();
                    dataGridView1.DataSource = sc.stv;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

