using System;
using System.Drawing;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // While
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            int i = 1;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // form üzerinde yer alan butonların rengini değiştiriniz.

            //for (int i = 0; i < Controls.Count; i++)
            //{
            //    Control control = Controls[i];

            //    if (control is Button)
            //    {
            //        control.BackColor = Color.Tomato;
            //    }
            //}


            int i = 0;
            while (i < Controls.Count)
            {
                Control control = Controls[i];
                if (control is Button)
                {
                    control.BackColor = Color.Tomato;
                }
                i++;
            }
        }


    }
}
