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
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }

        private void Form7_Load(object sender, System.EventArgs e)
        {
        }

        private void ToolStripButton1_Click(object sender, System.EventArgs e)
        {
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = ("select * from "+ (Cmbup.SelectedItem + (" where "+ (txtupid.Text + (" = \'"+ (txtui.Text + "\' "))))));
            sc.schfn();
            dgvu.DataSource = sc.stv;
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = ("UPDATE `customertbl` SET " + (txtupid.Text + ("= \'"+ (txtd.Text + ("\' WHERE `Customer_Id`= \'" + (txtui.Text + "\'"))))));
            sc.cnntotbl();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {

            cnnt sc = new cnnt();
            sc.insqry = ("UPDATE `pricetbl` SET `Price_Of_One`= \'" + (txtupd.Text + ("\' WHERE `Item_Id`= \'" + (txtitm.Text + "\'"))));
            sc.cnntotbl();
        }

        private void txtitm_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtitm.Clear();
        }

        private void txtitm_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void txtupd_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtupd.Clear();
        }

        private void txtupd_TextChanged(object sender, System.EventArgs e)
        {
        }
        
        private void btnshw_Click(object sender, EventArgs e)
        {

            cnnt sc = new cnnt();
            sc.insqry = ("select * from " + (Cmbup.SelectedItem + " "));
            sc.schfn();
            dgvu.DataSource = sc.stv;
        }
    }
}
