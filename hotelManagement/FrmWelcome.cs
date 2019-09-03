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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, System.EventArgs e)
        {
            Form Form = new customer();
            Form.Show();
            
        }
        private void Button1_MouseLeave(object sender, System.EventArgs e)
        {
            Button1.BackColor = Color.White;
            Button1.FlatStyle = FlatStyle.Standard;
        }

        private void Button1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Button1.BackColor = Color.LightSteelBlue;
            Button1.FlatStyle = FlatStyle.Popup;
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Form Form = new Login();
            Form.Show();
            
        }

        private void Button2_MouseLeave(object sender, System.EventArgs e)
        {
            Button2.BackColor = Color.White;
            Button2.FlatStyle = FlatStyle.Standard;
        }

        private void Button2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Button2.BackColor = Color.LightSteelBlue;
            Button2.FlatStyle = FlatStyle.Popup;
        }

        private void FrmWellcm_Leave(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form = new FrmAboutUs();
            Form.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Form = new FrmAboutUs();
            Form.Show();
           
        }
    }
}