namespace Calismalar { 
    class Calismalar()
    {
        static void Main(string[] args)
        {
            #region Örnek 1: Metin içindeki istenen karakterleri yazdırma

            string ad = "Ebrar Kocaman";

            // 1. Çözüm
            Console.WriteLine(ad[3]);
            Console.WriteLine(ad[ad.Length - 3]);

            //2. Çözüm
            Console.WriteLine(ad[1..^4]); // index .. sıra numarası , ^: Tersten gel.  (RangeIndices)
            #endregion

            Console.WriteLine("---------------------------------------------------------");

            #region Örnek 2: Girilen metin içerisinde kelime sayısını vardır.

            Console.WriteLine("Bir metin girin:");
            string metin = Console.ReadLine();

            // 1. Çözüm
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine(kelimeler.Length);

            // 2. Çözüm

            int adet = 1;

            while (true)
            {
                int index = metin.IndexOf(' ');
                if(index == -1)
                    break;
                
                adet++;

                metin = metin.Substring(index + 1);
            }

            Console.WriteLine(adet);
            #endregion
        }
    }
}
    
