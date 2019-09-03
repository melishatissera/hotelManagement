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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }
        private void btnHall_MouseLeave(object sender, System.EventArgs e)
        {
            btnHall.FlatStyle = FlatStyle.Standard;
        }

        private void btnHall_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnHall.FlatStyle = FlatStyle.Popup;
        }
        private void btnRoom_MouseLeave(object sender, System.EventArgs e)
        {
            btnRoom.FlatStyle = FlatStyle.Standard;
        }

        private void btnRoom_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnRoom.FlatStyle = FlatStyle.Popup;
        }

        private void btnFood_MouseLeave(object sender, System.EventArgs e)
        {
            btnFood.FlatStyle = FlatStyle.Standard;
        }

        private void btnFood_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnFood.FlatStyle = FlatStyle.Popup;
        }
        private void btnDrinks_MouseLeave(object sender, System.EventArgs e)
        {
            btnDrinks.FlatStyle = FlatStyle.Standard;
        }

        private void btnDrinks_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnDrinks.FlatStyle = FlatStyle.Popup;
        }
        private void btnGym_MouseLeave(object sender, System.EventArgs e)
        {
            btnGym.FlatStyle = FlatStyle.Standard;
        }

        private void btnGym_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnGym.FlatStyle = FlatStyle.Popup;
        }
        private void btnPool_MouseLeave(object sender, System.EventArgs e)
        {
            btnPool.FlatStyle = FlatStyle.Standard;
        }

        private void btnPool_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnPool.FlatStyle = FlatStyle.Popup;
        }

        private void btnTennis_MouseLeave(object sender, System.EventArgs e)
        {
            //btnTennis.FlatStyle = FlatStyle.Standard;
        }

        private void btnTennis_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //btnTennis.FlatStyle = FlatStyle.Popup;
        }
        private void btnBadmtn_MouseLeave(object sender, System.EventArgs e)
        {
            //btnBadmtn.FlatStyle = FlatStyle.Standard;
        }

        private void btnBadmtn_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //btnBadmtn.FlatStyle = FlatStyle.Popup;
        }
        private void btnclub_MouseLeave(object sender, System.EventArgs e)
        {
            btnclub.FlatStyle = FlatStyle.Standard;
        }

        private void btnclub_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnclub.FlatStyle = FlatStyle.Popup;
        }

        private void btnpub_MouseLeave(object sender, System.EventArgs e)
        {
            btnpub.FlatStyle = FlatStyle.Standard;
        }

        private void btnpub_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnpub.FlatStyle = FlatStyle.Popup;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {

        }
    }
}
