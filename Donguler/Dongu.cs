namespace Donguler
{
    public class Dongu
    {
        static void Main(string[] args)
        {
            #region For ile sonsuz döngü
            for (; ; ) //Sonsuz döngü
            {
                Console.Write("Sayi gir: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < 10)
                {
                    Console.WriteLine(sayi + 10);

                }
            }
            #endregion

            #region While ile sonsuz döngü
            bool durum = false;

            while (!durum)
            {

                Console.Write("Sayi gir: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < 10)
                {
                    Console.WriteLine(sayi + 10);
                    durum = !durum; // false olan durum değişkeni true yapıldı ve sonsuz döngüden çıkıldı.
                }
            }
            #endregion

            // İçi boş sonsuz döngülere ihtiyaç olabilir. Bu durumlarda aşağıdaki gibi yazılabilir.
            // for (;;); Sonsuz döngüdür. 
            // while (true); Sonsuz döngüdür.
        }
    }
}