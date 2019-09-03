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
    public partial class FrmTrn : Form
    {
        public FrmTrn()
        {
            InitializeComponent();
        }
        public void inscupy()
        {
            cnnt sc = new cnnt();
            try
            {
                sc.cnntotbl();
                sc.insqry = ("insert into `customertbl`(`Customer_Id`, `Customer_Fname`, `Customer_Lname`, `Birth_Day`, `Gender`, `Id_Type`, `tpnum`, `Email`) values (\'"
                            + (TxtInum.Text + ("\',\'"
                            + (TxtFname.Text + ("\',\'"
                            + (TxtLname.Text + ("\',\'"
                            + (DtpBday.Text + ("\',\'"
                            + (CmbGender.SelectedItem + ("\',\'"
                            + (CmbItp.SelectedItem + ("\',\'"
                            + (TxtTpn.Text + ("\',\'"
                            + (TxtEml.Text + "\')"))))))))))))))));

                sc.cnntotbl();
                sc.insqry = ("insert into `paymenttbl`(`Bill_Id`, `Amount`, `Paid`, `Balance`, `Emp_Id`, `Time`, `Date_P`, `Customer_Id`) values (\'"
                            + (TxtBnum.Text + ("\',\'"
                            + (TxtTtl.Text + ("\',\'"
                            + (TxtPd.Text + ("\',\'"
                            + (TxtBlnc.Text + ("\',\'"
                            + (Txt_stfId.Text + ("\',\'"
                            + (DtpTime.Text + ("\',\'"
                            + (DtpDate.Text + ("\',\'"
                            + (TxtInum.Text + "\')"))))))))))))))));

                sc.cnntotbl();
                sc.insqry = ("insert into `payment_tbl`(`Bill_Id`, `Customer_Id`, `Item_Id`, `Date_B`) values (\'"
                            + (TxtBnum.Text + ("\',\'"
                            + (TxtInum.Text + ("\',\'"
                            + (TxtIeamId.Text + ("\',\'"
                            + (DtpDate.Text + "\')"))))))));
              

            }
            catch(Exception e)
            {
                MessageBox.Show(""+e);
            }
        }

        private void TxtFname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int a;
            if (((int.TryParse(TxtFname.Text, out a))
                        || (TxtFname.Text == "")))
            {
                ErFn.SetError(TxtFname, "Please enter a proper name");
            }
            else
            {
                EpLn.SetError(TxtFname, "done");
            }

        }

        private void TxtBlnc_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void TxtPd_TextChanged(object sender, System.EventArgs e)
        {
            //TxtBlnc.Text = (TxtTtl.Text - TxtPd.Text);
        }

        private void CmbRcat_Click(object sender, System.EventArgs e)
        {
            cnnt sc = new cnnt();
            sc.insqry = "SELECT `Category` FROM `ct_room` ";
            sc.rdr();
            CmbRcat.Items.Add(sc.dt);
            //SELECT DISTINCT CustomerID FROM Orders;
            try
            {
               
            }
            catch (Exception ex)
            {
            }

        }

        private void CmbRcat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void TxtBnum_Click(object sender, System.EventArgs e)
        {
           
        }

        private void TxtBnum_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void CmbRmtyp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void TxtRmid_TextChanged(object sender, System.EventArgs e)
        {
            TxtIeamId.Text = TxtRmid.Text;
        }

        private void CmbHlno_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TxtIeamId.Text = CmbHlno.Text;
        }

        private void CmbResItm_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TxtIeamId.Text = CmbResItm.Text;
        }

        private void Cmbsprt_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TxtIeamId.Text = Cmbsprt.Text;
        }

        private void CmbItm_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TxtIeamId.Text = CmbItm.Text;
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Form Form = new FrmStaff();
            Form.Show();
            this.Hide();
        }

        private void TxtLname_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void TxtLname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int a;
            if (((int.TryParse(TxtInum.Text, out a)))|| (TxtFname.Text == ""))
            {
                ErFn.SetError(TxtLname, "Please enter a proper name");
            }
            else
            {
                EpLn.SetError(TxtLname, "Done!");
            }

        }

        private void TxtInum_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void TxtInum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int a;
            if (((int.TryParse(TxtInum.Text, out a)))|| (TxtFname.Text == ""))
            {
                ErFn.SetError(TxtInum, "Please enter a proper name");
            }
            else
            {
                EpLn.SetError(TxtInum, "Done!");
            }

        }

        private void TxtTpn_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void TxtTpn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int a;
            if (((int.TryParse(TxtInum.Text, out a)))
                        || (TxtFname.Text == ""))
            {
                ErFn.SetError(TxtTpn, "Please enter a proper name");
            }
            else
            {
                EpLn.SetError(TxtTpn, "Done!");
            }

        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            cnnt sc = new cnnt();
            inscupy();
            sc.insqry = ("INSERT INTO `roomtbl`(`Room_Id`, `Room_Type`, `Room_category`, `Number_Of_Rooms`, `Adult`, `Child`, `Check_In`, `Check_Out`, `Availability`, `Bill_Id`) VALUES  (\'"
                        + (TxtRmid.Text + ("\',\'"
                        + (CmbRmtyp.Text + ("\',\'"
                        + (CmbRcat.Text + ("\',\'"
                        + (TxtNrm.Text + ("\',\'"
                        + (TxtAdult.Value + ("\',\'"
                        + (TxtChild.Value + ("\',\'"
                        + (DtpIn.Text + ("\',\'"
                        + (DtpOut.Text + ("\',\'0\',\'"
                        + (TxtBnum.Text + "\' )"))))))))))))))))));
            sc.cnntotbl();
            sc.insqry = ("INSERT INTO `avltbl`(`RoomId`, `SDate`, `numofdays`) VALUES (\'"
            + (TxtRmid.Text + ("\',\'"
            + (DtpIn.Text + ("\',\'"
            + (txtdys.Text + "\' )"))))));
            sc.cnntotbl();
            MessageBox.Show("Done! one record added succesfully!");
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DtpIn.Value = dtp1.Value;
                DtpOut.Value = dtp1.Value.AddDays(Convert.ToDouble(txtdys.Text));
                var Form = new frmavlrm();
                Form.Show();
                Form.txtndys.Text = txtdys.Text;
                Form.dtp1.Value = dtp1.Value;
                Form.lblty.Text = CmbRmtyp.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Please select number of days");
            }

           
        }

        private void BtnHall_Click(object sender, EventArgs e)
        {

        }

        private void Btnres_Click(object sender, EventArgs e)
        {

        }

        private void Btnspt_Click(object sender, EventArgs e)
        {

        }

        private void Btnclub_Click(object sender, EventArgs e)
        {

        }
    }
}