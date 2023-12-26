using System;

namespace fermatProblem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = yuzeKadar();
            // uc haneden baslamak icin fermat oncesi olarak toplam kullaniyoruz
            int fermatOncesi = 0, fermatOncesiToplam = toplam;
            int ekle = 0;
            int fermatSonrasi;
            // sonuc 3 haneli oldugu icin sinirimiz 100-999
            for (int fermat = 100; fermat <= 99999; fermat++)
            {
                ekle = fermat + 1;
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
                while (fermatSonrasi <= fermatOncesi)
                {
                    fermatSonrasi += ekle;
                    /*  dongu icerisinde fermat sayisindan sonraki sayilari eklemek icin 'ekle' isminde degisken atiyoruz
                     * bu degiskeni her 1 arttirip fermatla beraber topladigimizda fermatSonrasina erisiyoruz ve sonraki
                     * fermatSonrasini oncekilerle kumulatif sekilde atiyoruz */
                    // fermatOncesi ve fermatSonrasi birbirine esit ise kapi numarasini ve esit geldigi degerleri yazdiriyoruz
                    if (fermatOncesi == fermatSonrasi)
                    {
                        Console.WriteLine("fermat kapi no: {2} fermat oncesi: {1}, fermat sonrasi: {0}", fermatSonrasi, fermatOncesi, fermat);
                        break;
                    }
                    ekle++;
                }
                fermatSonrasi = 0;
            }
        }
        private static int yuzeKadar()
        {
            // doksandokuza kadar olan sayilari topluyoruz
            int toplam = 0;
            for (int i = 1; i < 100; i++)
            {
                toplam += i;
            }

            return toplam;
        }
    }
}
