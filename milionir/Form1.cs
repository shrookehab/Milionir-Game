using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milionir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flatMini1_Click(object sender, EventArgs e)
        {

        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
