namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] sayilar = new int[2, 2, 4];
            sayilar[0, 0, 0] = 1;
            sayilar[0, 0, 1] = 3;
            sayilar[0, 0, 2] = 5;
            sayilar[0, 0, 3] = 7;
            sayilar[0, 1, 0] = 9;
            sayilar[0, 1, 1] = 11;
            sayilar[0, 1, 2] = 13;
            sayilar[0, 1, 3] = 15;
            sayilar[1, 0, 0] = 17;
            sayilar[1, 0, 1] = 19;
            sayilar[1, 0, 2] = 21;
            sayilar[1, 0, 3] = 23;
            sayilar[1, 1, 0] = 25;
            sayilar[1, 1, 1] = 27;
            sayilar[1, 1, 2] = 29;

            for (int i = 0; i < sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    for (int k = 0; k < sayilar.GetLength(2); k++)
                    {
                        Console.Write(sayilar[i, j, k] + "    ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            Console.WriteLine("[1,1,2]: " + sayilar[1, 1, 2] + ", Dizi boyutu: " + sayilar.Rank); // Rank, dizi boyutunu verir.

            Console.WriteLine("Toplam elaman sayısı: " + sayilar.Length); // lenght, dizi elaman sayısını verir.

            Console.WriteLine("1. boyut eleman sayısı: " + sayilar.GetLength(0)); // Boyutların ayrı ayrı eleman sayısını verir.
            Console.WriteLine("2. boyut eleman sayısı: " + sayilar.GetLength(1));
            Console.WriteLine("3. boyut eleman sayısı: " + sayilar.GetLength(2));

            #region Düzensiz Diziler
            // Her bir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
            // Sütun sayıları değişkendir.
            int[][] sayi = new int[3][];
            sayi[0] = new int[3] {3, 5, 7};
            sayi[1] = new int[5] { 3, 2, 9, 8, 12 };
            sayi[2] = new int[2] { 57, 10 };

            #endregion
        }
    }
}
