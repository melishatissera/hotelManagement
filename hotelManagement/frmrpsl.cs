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
    public partial class frmrpsl : Form
    {
        public frmrpsl()
        {
            InitializeComponent();
        }

        private void frmrpsl_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Paymenttbl' table. You can move, or remove it, as needed.
            //this.PaymenttblTableAdapter.Fill(this.DataSet1.Paymenttbl);
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Color clr;
            ColorDialog1.ShowDialog();
            clr = ColorDialog1.Color;
            BackColor = clr;
        }

        private void Chart1_Click(object sender, System.EventArgs e)
        {
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
           // DateTime dtp = dtp1.Text;
            cnnt cn = new cnnt();
           // cn.insqry = ("select Amount from Paymenttbl where Date_P = \'" + (dtp + "\' "));
            cn.rdrpl();
           // this.Chart1.Series("sales").Points.AddXY(dtp, cn.dt);
            for (int i = 1; (i <= 6); i++)
            {
              //  cn.insqry = ("select Amount from Paymenttbl where Date_P=\'" + (dtp.AddDays((i * -1)) + "\'"));
                cn.rdrpl();
               // this.Chart1.Series("sales").Points.AddXY(dtp.AddDays((i * -1)), cn.dt);
            }

        }

        private void btnclr_Click(object sender, System.EventArgs e)
        {
            Color clr;
            ColorDialog1.ShowDialog();
            clr = ColorDialog1.Color;
            try
            {
                foreach (Control btn in this.Controls)
                {
                    //if ((btn.GetType() == Button))
                    {
                        ((Button)(btn)).BackColor = clr;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again");
            }

        }

        private void btnfc_Click(object sender, System.EventArgs e)
        {
            Color clr;
            ColorDialog1.ShowDialog();
            clr = ColorDialog1.Color;
            try
            {
                foreach (Control btn in this.Controls)
                {
                   // if ((btn.GetType() == Button))
                    {
                        ((Button)(btn)).ForeColor = clr;
                    }
                   // else
                    {

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again");
            }

        }

        private void lblrs_Click(object sender, System.EventArgs e)
        {
            try
            {
                foreach (Control btn in this.Controls)
                {
                   // if ((btn.GetType() == Button))
                    {
                        ((Button)(btn)).ForeColor = Color.Black;
                        ((Button)(btn)).BackColor = Color.Silver;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again");
            }

            BackColor = Color.LightGray;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Frm = new FrmStaff();
            Frm.Show();
        }
    }
}

