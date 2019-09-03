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
    public partial class FrmSUD : Form
    {
        public FrmSUD()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = ("select * from "+ (Cmbtbls.SelectedItem + " "));
            sc.schfn();
            Dgvsrch.DataSource = sc.stv;
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = ("select * from "+ (Cmbtbls.SelectedItem + (" where "+ (cmbfld.Text + (" =\'"+ (Txtsrch.Text + "\' "))))));
            sc.schfn();
            Dgvsrch.DataSource = sc.stv;
        }

        private void FrmSUD_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbDataSet.Ct_Room' table. You can move, or remove it, as needed.
           //this.ct_roomTableAdapter.Fill(this.DbDataSet.ct_room);
            // TODO: This line of code loads data into the 'DbDataSet.customertbl' table. You can move, or remove it, as needed.
           //this.CustomertblTableAdapter.Fill(this.DbDataSet.customertbl);
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = ("select * from "+ (cmbdel.SelectedItem + " "));
            sc.schfn();
            Dgvsrch.DataSource = sc.stv;
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            DialogResult qu = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if ((qu == DialogResult.Yes))
            {
                cnnt sc = new cnnt();
                sc.insqry = ("delete  from "+ (cmbdel.Text + (" where Room_Id=\'"+ (Txtdel.Text + ("\' and Bill_Id=\'"+ (txtdel2.Text + "\' "))))));
                MessageBox.Show("Record deleted succusfully!");
                sc.cnntotbl();
            }
            else
            {
                MessageBox.Show("Cancel");
            }

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
