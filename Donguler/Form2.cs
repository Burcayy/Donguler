using System;
using System.Drawing;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };


            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };

            int buyukSayi = 0;

            for (int i = 0; i < sayisal.Length; i++)
            {
                if (buyukSayi < sayisal[i])
                {
                    buyukSayi = sayisal[i];
                }
            }

            MessageBox.Show(buyukSayi.ToString());
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int tek = 0, cift = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                if (sayisal[i] % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
            }

            MessageBox.Show($"Toplamda dizi içerisinde yer alan tek sayıların adedi {tek}\nToplamda dizi içerisinde yer alan çift sayıların adedi {cift}");
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // verilen isim değerini tersten yazdırarak kullanıcıya mb içerisinde gösteriniz :)

            string isim = "bilge adam";
            string yeniIsim = "";
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    yeniIsim += isim[i];
            //}


            for (int i = isim.Length - 1; i >= 0; i--)
            {
                yeniIsim += isim[i];
            }
            MessageBox.Show(yeniIsim);

        }
        Random rnd = new Random();
        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(10000, 100000));
            }
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    this.Controls[i].ForeColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                }
            }
        }


        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control ctrl = Controls[i];

                if (ctrl.TabIndex == index)
                {
                    this.Controls[i].BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                }
                else
                {
                    this.Controls[i].BackColor = default;
                }
            }
            index++;

            if (index == 7)
            {
                index = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...
            string sayi = txtGirisAlani.Text;
            // 1  2  3  => 123
            // 49 50 51 => 150
            int toplam = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                toplam += Convert.ToInt32(sayi[i].ToString());  
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
