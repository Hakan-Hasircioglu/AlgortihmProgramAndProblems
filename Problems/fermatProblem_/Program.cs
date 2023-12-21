using System;

namespace fermatProblem_
{
    internal class Program
    {

        static void Main(string[] args)
        {        
            // doksandokuza kadar olan sayilari topluyoruz
            int toplam = 0;
            for (int i = 1; i < 100; i++)
            {
                toplam += i;
            }
            // uc haneden baslamak icin fermat oncesi olarak toplam kullaniyoruz
            int fermatOncesi = 0, fermatOncesiToplam = toplam;
            int ekle = 1;
            int fermatSonrasi = 0;
            // sonuc 3 haneli oldugu icin sinirimiz 100-999
            for (int fermat = 100; fermat <= 999; fermat++)
            {
                //Oncesi
                //yuzden sonra da her sayimiz ilerlediginde oncesini hesapliyoruz
                fermatOncesiToplam += fermat;
                fermatOncesi = fermatOncesiToplam - fermat;
                //Sonrasi
                //fermatSonrasi icin 0 atiyoruz cunku her dongu dondugunde onceki dongudeki hesabi sifirlamaliyiz
                fermatSonrasi = 0;
                /*
                 *  fermat sonrasi fermat oncesinden kucuk veya esit oldugu surece sonrasini hesapliyoruz eger sonrasi,
                 * fermat oncesini gecerse sayimiz tutmadigi icin o sayiyi geciyoruz
                 */
                for (; fermatSonrasi <= fermatOncesi; fermatSonrasi += fermat + ekle)
                {
                    /*  dongu icerisinde fermat sayisindan sonraki sayilari eklemek icin 'ekle' isminde degisken atiyoruz
                     * bu degiskeni her 1 arttirip fermatla beraber topladigimizda fermatSonrasina erisiyoruz ve sonraki
                     * fermatSonrasini oncekilerle kumulatif sekilde atiyoruz */
                    // fermatOncesi ve fermatSonrasi birbirine esit ise kapi numarasini ve esit geldigi degerleri yazdiriyoruz
                    if (fermatSonrasi == fermatOncesi)
                    {
                        Console.WriteLine("********* " + "Fermat Kapi No: " + fermat + "    *********"); //  963
                        Console.WriteLine("********* " + "Fermat Oncesi: " + fermatOncesi + "  *********"); // 463203
                        Console.WriteLine("********* " + "Fermat Sonrasi: " + fermatSonrasi + " *********"); // 463203
                    }
                    ekle++;
                }
            }
        }
    }
}
