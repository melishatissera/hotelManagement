using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace login
{
    public partial class frmscn : Form
    {
        public frmscn()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image img = Clipboard.GetImage();
            this.Show();
            PictureBox1.Image = img;
            SaveFileDialog1.Title = "Save File";
            SaveFileDialog1.FileName = "Screenshot";
            SaveFileDialog1.Filter = "png |*.png";
            if ((SaveFileDialog1.ShowDialog() == DialogResult.OK))
            {
                img.Save("D:\\ Screenshot.png");
            }

            if (File.Exists(SaveFileDialog1.FileName))
            {
                DialogResult ask;
                ask = MessageBox.Show("File already exists, Would you like to replace it?", "File Exists", MessageBoxButtons.YesNo);
                if ((ask == DialogResult.No))
                {
                    SaveFileDialog1.ShowDialog();
                }
                else if ((ask == DialogResult.Yes))
                {
                    img.Save("D:\\ Screenshot1.png");
                }
            }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Frm = new FrmStaff();
            Frm.Show();
        }
    }
}
