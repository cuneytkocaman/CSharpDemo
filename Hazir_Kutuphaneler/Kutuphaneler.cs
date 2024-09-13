namespace Hazir_Kutuphaneler
{
    class Kutuphaneler
    {
        static void Main(string[] args)
        {
            #region Math Sınıfı

            #region Abs: Mutlak değer işlemi yapar.
            int mth = Math.Abs(-5);
            #endregion

            #region Ceiling, Floor, Round (Yuvarlama İşlemleri)
            //Ceiling: Yukarıya yuvarlama yapar.
            //Floor: Aşağıya yuvarlama yapar. 
            //Round: En yakına yuvarlama yapar.

            Console.WriteLine(Math.Ceiling(3.14));
            Console.WriteLine(Math.Floor(3.14));

            Console.WriteLine(Math.Round(9.5));
            Console.WriteLine(Math.Round(2.12));
            Console.WriteLine(Math.Round(6.89));
            #endregion

            #region Pow
            Console.WriteLine(Math.Pow(7, 9)); // 7 üssü 9
            #endregion

            #region Sqrt: Karekök

            #endregion

            #region Truncate: Eldeki değeri tam sayı kısmını verir
            Console.WriteLine(Math.Truncate(3.14));
            #endregion

            #region TimeSpan Struct: İki tarih arasındaki farkı verir
            DateTime t1 = DateTime.Now;
            DateTime t2 = new DateTime(2000, 1, 1);

            Console.WriteLine();
            Console.WriteLine("TimeSpan ile iki tarih arasındaki fark");
            TimeSpan span = t1 - t2;
            Console.WriteLine($"Gün: {span.Days}");
            #endregion

            Random random = new Random();

            #region Next Fonksiyonu
            // NextDouble: Sıfır ile bir arasında bir sayı üretir.

            int i = 0;
            while (i <= 25) 
            {
                Console.WriteLine(random.NextDouble());

                i++;
            }

            #endregion

            #endregion
        }
    }
}
