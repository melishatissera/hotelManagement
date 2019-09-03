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
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        private void BtnBkng_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmTrn();
            Frm.Show();
            Frm.GroupBox2.Visible = false;
        }

        private void BtnSrch_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Button1.Visible = false;
        }

        private void BtnRpt_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            
        }

        private void BtnUninv_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Pnlup.Visible = false;
            cnnt sc = new cnnt();
            sc.insqry = "SELECT * FROM `paymenttbl` WHERE Balance >\'0\' ";
            sc.schfn();
            Frm.Dgvsrch.DataSource = sc.stv;
        }

        private void BtnSal_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Pnlup.Visible = false;
            cnnt sc = new cnnt();
            sc.insqry = "SELECT * FROM `payment_tbl`";
            sc.schfn();
            Frm.Dgvsrch.DataSource = sc.stv;
        }

        private void BtnPrice_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Pnlup.Visible = false;
            cnnt sc = new cnnt();
            sc.insqry = "SELECT * FROM `pricetbl`";
            sc.schfn();
            Frm.Dgvsrch.DataSource = sc.stv;
        }

        private void BtnCnrsv_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Pdel.Enabled = true;
            Frm.Pnlup.Enabled = false;
        }

        private void FrmStaff_Leave(object sender, System.EventArgs e)
        {
            var Frm = new FrmWelcome();
            Frm.Show();
        }

        private void FrmStaff_Load(object sender, System.EventArgs e)
        {
        }

        private void BtnChkrm_Click(object sender, System.EventArgs e)
        {
            var Frm = new FrmUpdate();
            Frm.Show();
        }

        private void BtnInv_MouseEnter(object sender, System.EventArgs e)
        {
            BtnInv.FlatStyle = FlatStyle.Popup;
            BtnInv.BackColor = Color.LightSteelBlue;
        }

        private void BtnInv_MouseLeave(object sender, System.EventArgs e)
        {
            BtnInv.FlatStyle = FlatStyle.Standard;
            BtnInv.BackColor = Color.LightSeaGreen;
        }

        private void BtnRpt_MouseEnter(object sender, System.EventArgs e)
        {
            BtnRpt.FlatStyle = FlatStyle.Popup;
            BtnRpt.BackColor = Color.LightSteelBlue;
        }

        private void BtnRpt_MouseLeave(object sender, System.EventArgs e)
        {
            BtnRpt.FlatStyle = FlatStyle.Standard;
            BtnRpt.BackColor = Color.LightSeaGreen;
        }

        private void BtnUninv_MouseEnter(object sender, System.EventArgs e)
        {
            BtnUninv.FlatStyle = FlatStyle.Popup;
            BtnUninv.BackColor = Color.LightSteelBlue;
        }

        private void BtnUninv_MouseLeave(object sender, System.EventArgs e)
        {
            BtnUninv.FlatStyle = FlatStyle.Standard;
            BtnUninv.BackColor = Color.LightSeaGreen;
        }

        private void BtnBkng_MouseEnter(object sender, System.EventArgs e)
        {
            BtnBkng.FlatStyle = FlatStyle.Popup;
            BtnBkng.BackColor = Color.LightSteelBlue;
        }

        private void BtnBkng_MouseLeave(object sender, System.EventArgs e)
        {
            BtnBkng.FlatStyle = FlatStyle.Standard;
            BtnBkng.BackColor = Color.LightSeaGreen;
        }

        private void BtnChkrm_MouseEnter(object sender, System.EventArgs e)
        {
            BtnChkrm.FlatStyle = FlatStyle.Popup;
            BtnChkrm.BackColor = Color.LightSteelBlue;
        }

        private void BtnChkrm_MouseLeave(object sender, System.EventArgs e)
        {
            BtnChkrm.FlatStyle = FlatStyle.Standard;
            BtnChkrm.BackColor = Color.LightSeaGreen;
        }

        private void BtnSal_MouseEnter(object sender, System.EventArgs e)
        {
            BtnSal.FlatStyle = FlatStyle.Popup;
            BtnSal.BackColor = Color.LightSteelBlue;
        }

        private void BtnSal_MouseLeave(object sender, System.EventArgs e)
        {
            BtnSal.FlatStyle = FlatStyle.Standard;
            BtnSal.BackColor = Color.LightSeaGreen;
        }

        private void BtnCnrsv_MouseEnter(object sender, System.EventArgs e)
        {
            BtnCnrsv.FlatStyle = FlatStyle.Popup;
            BtnCnrsv.BackColor = Color.LightSteelBlue;
        }

        private void BtnCnrsv_MouseLeave(object sender, System.EventArgs e)
        {
            BtnCnrsv.FlatStyle = FlatStyle.Standard;
            BtnCnrsv.BackColor = Color.LightSeaGreen;
        }

        private void BtnPrice_MouseEnter(object sender, System.EventArgs e)
        {
            BtnPrice.FlatStyle = FlatStyle.Popup;
            BtnPrice.BackColor = Color.LightSteelBlue;
        }

        private void BtnPrice_MouseLeave(object sender, System.EventArgs e)
        {
            BtnPrice.FlatStyle = FlatStyle.Standard;
            BtnPrice.BackColor = Color.LightSeaGreen;
        }

        private void BtnSrch_MouseEnter(object sender, System.EventArgs e)
        {
            BtnSrch.FlatStyle = FlatStyle.Popup;
            BtnSrch.BackColor = Color.LightSteelBlue;
        }

        private void BtnSrch_MouseLeave(object sender, System.EventArgs e)
        {
            BtnSrch.FlatStyle = FlatStyle.Standard;
            BtnSrch.BackColor = Color.LightSeaGreen;
        }

        private void BtnInv_Click(object sender, EventArgs e)
        {
            var Frm = new frmunpy();
            Frm.Show();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            var Frm = new frmunpy();
            Frm.Show();
            
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            var Frm = new Frmdlyr();
            Frm.Show();

        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            var Frm = new Frmcrtus();
            Frm.Show();

        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            var Frm = new frmrpsl();
            Frm.Show();

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var Frm = new FrmStock();
            Frm.Show();
           
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if ((result == DialogResult.No))
            {

            }
            else if ((result == DialogResult.Yes))
            {
                var Frm = new Login();
                Frm.Show();
                this.Visible=false;
            }

        }

        private void ScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new frmscn();
            Frm.Show();
            
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            var Frm = new Frmcrtus();
            Frm.Show();

        }
        private void NewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new frmunpy();
            Frm.Show();
        }

        private void CancelRecervationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Pdel.Enabled = true;
            Frm.Pnlup.Enabled = false;
        }

        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new FrmSUD();
            Frm.Show();
            Frm.Pnlup.Visible = false;
            cnnt sc = new cnnt();
            sc.insqry = "SELECT * FROM `paymenttbl`";
            sc.schfn();
            Frm.Dgvsrch.DataSource = sc.stv;
        }

        private void ScreenshotToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var Frm = new frmscn();
            Frm.Show();
        }
    }
    }