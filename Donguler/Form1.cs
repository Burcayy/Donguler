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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {

            // 1. bölüm, başlangıç index değeri
            // 2. bölüm, koşul
            // 3. bölüm, iterasyon

            for (int i = 1; i <= 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // 1000 ile 1 arasında yer alan sayıları, listbox'a ekleyiniz :)
            for (int i = 1000; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            // 1 ile 1000 arasında yer alan, çift sayıları listbox'a ekleyiniz. 

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            for (int i = 2; i <= 1000; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // A harif ile Z harfi arasında yer alan karakterleri listbox' ekleyiniz
            // Alfabeyi listbox'a ekleyiniz 


            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // 1 ile 100 arasında sayıların toplamını mb içerisinde yazdırınız!

            int toplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                toplam += i;
            }
            MessageBox.Show(toplam.ToString());
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?

            int tekSayilar = 0;
            int ciftSayilar = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    ciftSayilar += i;
                }
                else
                {
                    tekSayilar += i;
                }
            }

            int sonuc = (ciftSayilar - tekSayilar) * (ciftSayilar - tekSayilar);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak 1990 ve 1992 yılları eklenmeyecek...

            for (int i = 1945; i < DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}


