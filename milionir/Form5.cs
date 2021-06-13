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
    public partial class Form5 : Form
    {
        public Form5(string text)
        {
            InitializeComponent();
            label4.BackColor = Color.White;
            label4.Text = text;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
