using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {

            //int index = 100;
            //while (index < 100)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}
            //Console.WriteLine("İşlem Sonu");

            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index < 100);

            do
            {
                Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz : ");
                string username = Console.ReadLine();

                Console.WriteLine("Lütfen Kullanıcı Şifrenizi Giriniz : ");
                string password = Console.ReadLine();

                if (username == "admin" && password == "123")
                {
                    Console.WriteLine("Hoşgeldiniz");
                    break; // döngü içerisinde break anahtar kelimesi var ise, koişul sağlandığında döngü sonlandırılacaktır anlamına gelir.
                }
                else
                {
                    Console.WriteLine("Kullanıcı bilgileriniz yanlış, lütfen takrar deneyiniz.");
                }

            } while (true);

            Console.Read();
        }
    }
}
