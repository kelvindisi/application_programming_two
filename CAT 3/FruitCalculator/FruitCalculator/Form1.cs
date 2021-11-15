using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int fruits = Convert.ToInt32(txtFruits.Text);
            int dozens = fruits / 12;
            int remainder = fruits % 12;

            txtDozens.Text = dozens.ToString();
            txtLeftOver.Text = remainder.ToString();
        }
    }
}
