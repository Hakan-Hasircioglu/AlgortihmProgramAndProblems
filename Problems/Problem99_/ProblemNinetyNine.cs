using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Problem99_
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Metin dosyasının yolunu belirtin
                string dosyaYolu = "0099_base_exp.txt";

                // Metin dosyasını satır satır okuyarak sayıları alın
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                // Sayıları içerecek bir liste oluşturun
                var sayilar = new List<int>();

                // Her satırdaki sayıları çıkarmak için Regex kullanın
                foreach (var satir in satirlar)
                {
                    var matches = Regex.Matches(satir, @"\d+");

                    foreach (Match match in matches)
                    {
                        if (int.TryParse(match.Value, out int sayi))
                        {
                            sayilar.Add(sayi);
                        }
                        else
                        {
                            Console.WriteLine($"Hata: {match.Value} bir sayı değil.");
                        }
                    }
                }

                // Sayıları ekrana yazdırın (Opsiyonel)
                Console.WriteLine("Metin Dosyasındaki Sayılar:");
                foreach (var sayi in sayilar)
                {
                    Console.WriteLine(sayi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

        }
    }
}