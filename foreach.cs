using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // List oluşturma ve tamsayı ekleme
        ArrayList sayilar = new ArrayList { 10, 20, 30, 40, 50 };

        int toplam = 0;

        // foreach döngüsü ile sayıları yazdırma ve toplamı hesaplama
        foreach (int sayi in sayilar)
        {
            Console.WriteLine("Sayı: " + sayi);
            toplam += sayi;
        }

        // Toplamı ekrana yazdırma
        Console.WriteLine("Sayıların Toplamı: " + toplam);
    }
}

