namespace BubbleSortAlg
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int[] dizi = { 17, 12, 30, 45, 9, 5, 33, 25, 25, 96, 1 };
            int referans;

            int dongu = 0, sayac = 0;

            while (dongu <= dizi.Length)
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    for (int j = i + 1; j <= i + 1; j++)
                    {
                        if (j == dizi.Length)
                            break;

                        if (dizi[j] < dizi[i])
                        {
                            referans = dizi[i];
                            dizi[i] = dizi[j];
                            dizi[j] = referans;

                            sayac++;
                        }
                    }
                    Console.Write($"{dizi[i]} ");
                }

                Console.WriteLine();
                dongu++;
            }

            Console.WriteLine($"\nAdım sayısı: {sayac}");
        }
    }
}