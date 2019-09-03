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
    public partial class frmunpy : Form
    {
        public frmunpy()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void Label1_Click(object sender, System.EventArgs e)
        {
        }

        private void btnshw_Click(object sender, System.EventArgs e)
        {
            try
            {
                cnnt sc = new cnnt();
                sc.cnntotbl();
                sc.insqry = ("SELECT * FROM `paymenttbl` WHERE `Customer_Id` = \'" + (txtcusid.Text + "\' and `Balance` > \'0\'"));
                sc.schfn();
                Dgb.DataSource = sc.stv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Please check entered values " + ex.Message));

            }
        }

        private void TxtBnum_Leave(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            try
            {
                sc.insqry = ("SELECT `Amount`, `Paid`, `Balance` FROM `paymenttbl` Bill_Id = \'" + (TxtBnum.Text + "\'"));
                sc.rdrfl();
                string bnm = sc.bt;
                TxtTtl.Text = bnm;
                TxtBlnc.Text = sc.name;
                TxtPd.Text = sc.dt;
                Button1.Visible = true;
            }
            catch (Exception ex)
            {
            }

        }

        private void TxtBnum_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void GroupBox2_Enter(object sender, System.EventArgs e)
        {
        }

        private void txtptot_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                double pd = Convert.ToDouble(TxtPd.Text);
                double tt = Convert.ToDouble(txtptot.Text);
                txtttp.Text = (tt + pd).ToString();
                txtpbnc.Text = (Convert.ToDouble(TxtBlnc.Text) - Convert.ToDouble(txtptot.Text)).ToString();
                Button2.Visible = true;
            }
            catch (Exception ex)
            {
            }

        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                cnnt sc = new cnnt();
                sc.insqry = ("UPDATE `paymenttbl` SET `Balance`\'" + (txtpbnc.Text + ("\', `Paid` = \'" + (txtttp.Text + ("\' where `Bill_Id` = \'" + (TxtBnum.Text + "\'"))))));
                sc.cnntotbl();
                sc.insqry = ("SELECT * FROM `paymenttbl` WHERE `Customer_Id` = \'" + (txtcusid.Text + "\' and `Balance` > \'0\'"));
                sc.schfn();
                Dgb.DataSource = sc.stv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Please check entered values " + ex.Message));
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}