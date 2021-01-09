// Züleyha Abazi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyukKucukOrtalama_09._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 6, 30, -14, 5, 58, 49 };
            int enBuyukSayi = sayilar[0];
            int enKucukSayi = sayilar[0];
            double toplam = 0;
            double ortalama = 0;
            

            /* a) dizideki en büyük sayıyı bulma
             * bunun için ilk önce elimde olan sayıları tek tek okumaya başlarım, 
             * her okuduğum sayıyı bir sonrakiyle karşılaştırırım eğer ki ilk okuduğumdan büyükse onu başa alırım eğer değilse yerini değiştirmem.
             * b) dizideki en küçük sayıyı bulma
             * en büyük sayıyı bumak için yaptığımız işlemin tersini yaparak en küçük sayıyı bulurum
             * c) dizinin ortamasını bulmak
             * bunun için ilk önce dizideki bütün değerleri toplarım, toplamı dizideki eleman sayısına bölersem ortalama değeri bulurum
             */
           
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enBuyukSayi)
                {
                    enBuyukSayi = sayilar[i];
                }
                
                if (sayilar[i] < enKucukSayi)
                {
                    enKucukSayi = sayilar[i];
                }
                toplam += sayilar[i];
            }
            ortalama = toplam / sayilar.Length;
            ortalama = Math.Round(ortalama, 2);

            Console.WriteLine("En büyük sayı: " + enBuyukSayi);
            Console.WriteLine("En küçük sayı: " + enKucukSayi);
            Console.WriteLine("Ortalama değer:" + ortalama);

      
            Console.ReadLine();
        }
    }
}
