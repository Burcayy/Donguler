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
    public partial class Form5 : Form
    {
        /* FOREACH
           1) Kesinlikle index mantigi yoktur!
           2) Tip bagimli dongulerdir...
           3) Cogu zaman elimizdeki bir koleksiyonun her bir elemanini tek tek ele almak icin kullanilir...  */
        public Form5()
        {
            InitializeComponent();
        }
        string[] sehirler = { "ankara", "edirne", "istanbul", "bursa", "eskişehir" };
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            //int index = 0;
            //while (index < sehirler.Length)
            //{
            //    listBox1.Items.Add(sehirler[index]);
            //    index++;
            //}


            //int i = 0;
            //do
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //    i++;
            //} while (i < sehirler.Length);


            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    string sehir = sehirler[i];
            //    listBox1.Items.Add(sehir);
            //}
            //İlgili dizi icerisindeki her bir elemana gecici olarak "sehir" takma adi verilir ve dongunun her bir adiminda size dizinin her bir elemani teslim edilir...
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //İkiye bolunenleri listbox1'e bolunemeyenleri listbox2 ye atın... Hem ikiye hem uce bolunenlerin kac tane oldugunu da messagebox'la gosterin...

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            int tamBolunenler = 0;

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    tamBolunenler++;
                }

                if (sayi % 2 == 0) { listBox1.Items.Add(sayi); }
                else { listBox2.Items.Add(sayi); }
            }
            MessageBox.Show($"Bu dizide hem 2'ye hem de 3'e tam bölünen toplamda {tamBolunenler} sayı vardır");
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            // listbox1 içerisinde yer alan seçili elemanları listbox2  ye aktarınız.

            foreach (var item in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(item))
                    listBox2.Items.Add(item);
            }

            foreach (var item in listBox2.Items)
            { 
                listBox1.Items.Remove(item); 
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // Form üzerinde yer alan butonların arkaplan renklerini değiştiriniz!!!

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Tomato;
                }
            }
        }
    }
}

