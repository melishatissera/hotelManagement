using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Frmcrtus : Form
    {
        string path;
        public Frmcrtus()
        {
            InitializeComponent();
        }
       
        private void Button5_Click(object sender, System.EventArgs e)
        {
            try
            {
                string ty;
                if (rb0.Checked)
                {
                    ty = "1";
                }

                if (rbadmin.Checked)
                {
                    ty = "0";
                }

                cnnt sc = new cnnt();
                sc.insqry = ("INSERT INTO `logtbl`(`Id`, `Paswrd`, `type`) VALUES (\'" + (txtitm.Text + ("\',\'"+ (txtupd.Text + "\',\'1\')"))));
                sc.cnntotbl();
                MessageBox.Show("New user created successfully");
                try
                {
                    System.IO.FileStream file;
                    System.IO.File.Copy(path, (txtitm.Text + ".jpg"));
                    //file.Close();
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(("ErrorToString creating user " + ex.Message));
            }

            }

        void Button4_Click(object sender, System.EventArgs e)
        {
            try
            {
                cnnt sc = new cnnt();
                sc.insqry = ("update logtbl set Paswrd= \'" + (txtupd.Text + ("\' where Id= \'" + (txtitm.Text + "\'"))));
                sc.cnntotbl();
                MessageBox.Show("Password changed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error updating password" + ex.Message);
            }

        }

        private void txtitm_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((txtitm.Text == "Enter Username"))
            {
                txtitm.Clear();
            }

        }

        private void txtitm_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void txtupd_Leave(object sender, System.EventArgs e)
        {
            if ((txtupd.Text == TextBox1.Text))
            {
                ErrorProvider1.Clear();
                ErrorProvider2.SetError(txtupd, "Done! ");
            }
            else
            {
                ErrorProvider2.Clear();
                ErrorProvider1.SetError(txtupd, "passwords should be same ");
            }

            if ((txtupd.Text == TextBox1.Text))
            {
                Button5.Enabled = true;
                Button4.Enabled = true;
            }

        }

        private void txtupd_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((txtupd.Text == "ReEnter password"))
            {
                txtupd.Clear();
            }

        }

        private void txtupd_TabStopChanged(object sender, System.EventArgs e)
        {
        }

        private void txtupd_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void GroupBox1_Enter(object sender, System.EventArgs e)
        {
        }

        private void TextBox1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((TextBox1.Text == "password"))
            {
                TextBox1.Clear();
            }

        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void txtupd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if ((txtitm.Text == "Enter Username"))
            {
                MessageBox.Show("Enter user name");
            }
            else
            {
                try
                {
                    Stream myStream = null;
                    OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        path = open.FileName;
                    }

                    string image = path;
                    Bitmap bmp = new Bitmap(image);
                    PictureBox1.Image = bmp;
                    FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                    byte[] bimage = new byte[fs.Length];
                    fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                    fs.Close();

                    byte[] Photo = bimage;
                }
                catch (Exception Ex)
                {
                }

            }

        }
    }
}