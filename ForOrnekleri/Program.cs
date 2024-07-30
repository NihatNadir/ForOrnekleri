using System;
using System.Threading.Channels;

namespace ForOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Soru1->Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");
            for (int i = 0; i < 10; i++) // i değişkenine 0'dan başlayarak 10 kez tekrar edecek şekilde döngü başlatıyoruz.
            {
                Console.WriteLine($"{i+1}- Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            Console.WriteLine();
            Console.WriteLine("Soru2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
            for (int i = 1;i <= 20; i++) // 1'den 20'ye kadar 1'er artarak döngü başlatıyoruz
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Soru3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");            
            for (int i = 1; i <= 20; i++) // for döngüsü ile 1 20 arasındaki sayıları alıp % bölme ile çift olanları ayırırız
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Soru4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
            int sum = 0; // Toplama işlemi için değişken oluşturuyoruz.
            for (int i = 50;  i < 150; i++) // i değişkenine 50'den başlayarak 150 ' ye kadar 1' er artacak şekilde döngü başlatıyoruz
            {
                sum += i;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı = {sum}");
            Console.WriteLine();
            Console.WriteLine("Soru5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");           
            int sumEven = 0; // çift sayıların toplamını alacak değişken
            int sumOdd = 0; // tek sayıların toplamını alacak değişken
            for (int i = 1; i <= 120; i++) // for ile 1 ile 120 arasındaki sayıları alıp % bölme ile çift olanları topla diğerleri tek sayı onlarıda kendi aralarında topla
            {
                if (i % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;    
            }
            Console.WriteLine($"Çift sayilarin toplamı = {sumEven}");
            Console.WriteLine($"Tek sayilarin toplamı = {sumOdd}");
        }
    }
}