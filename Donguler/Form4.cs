using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                lblYaziAlani.Text += "X ";
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                lblYaziAlani.Text += "X\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblYaziAlani.Text = "";

            for (int y = 0; y < int.Parse(textBox1.Text); y++)
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    lblYaziAlani.Text += "X ";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < int.Parse(textBox1.Text); x++)
            {
                for (int y = 0; y < x; y++)
                {
                    lblYaziAlani.Text += "X ";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // 1 X 1 = 1
            // ----------------------

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    listBox1.Items.Add($"{x} X {y} = {x * y}");
                }
                listBox1.Items.Add("------------------------------------");
            }
        }
    }
}
