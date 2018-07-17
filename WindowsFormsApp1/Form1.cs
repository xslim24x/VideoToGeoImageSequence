using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lat_Click(object sender, EventArgs e)
        {

        }

        private void long_Click(object sender, EventArgs e)
        {

        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("success");
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string var = lat.Text;
            string var1 = logn.Text;
            MessageBox.Show(var + " " + var1);
        }

        private void lat_TextChanged(object sender, EventArgs e)
        {

        }

        private void logn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
