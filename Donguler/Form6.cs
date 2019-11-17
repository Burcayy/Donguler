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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                if (i == 5)
                {
                    listBox1.Items.Add("5. elemana ulaştık");
                    break;
                }
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add("İşlem Sonu");
        }
        Random rnd = new Random();
        private void btnContinue_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] sayilar = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int sayi = rnd.Next(1, 50);
                if (sayilar.Contains(sayi))
                {
                    i--;
                    continue;
                } 
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string username = "admin1";
            if(username != "admin") { return; }
             
            MessageBox.Show("Login işlemleri yapılacak");
        }
    }
}
