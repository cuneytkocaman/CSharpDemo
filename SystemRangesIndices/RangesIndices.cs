namespace SystemRangesIndices
{
    public class RangesIndices
    {
        static void Main(string[] args)
        {

            string[] isimler = { "Ali", "Veli", "Ömer", "Ayşe", "Gül" };
            int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };

            #region System.Index (^)
            // Dizi ve koleksiyon yapılarındaki index kavramının tip olarak belirlenmiş halidir.
            // Temelde index değerini bir tür ile tutmakla beraber ^ operatörüyle birlikte daha fazla anlam ifade etmekte ve
            // dizinin index değerlerini tersine ifade edecek şekilde bir sorumluluk yüklemektedir.

            Index ind = ^3; // Index ile çalışımalıdır çünkü ^ operatörü index dödürür.

            Console.WriteLine(" ^ (Index) Operatörü ile tersinden  yazdırma: " + isimler[ind]); // Normalde diziler 0'dan başlar. Tersinde yazdırmada ise 1'den başlar.
                                                                                                // Yani burada Ayşe değil Ömer yazar.

            #endregion

            #region System.Range (..)
            // Veri kümelerinde hangi değerler ile çalışacağımızı belirleyebilmek için index üzerinden aralık vermemizi ve
            // bunu .. operatörü ile gerçekleştirmemizi sağlayan yapılanmadır.
            // Range r = .. ; Bu kod tüm diziyi alır.

            Range ran = 5..10; // Operatörün solundaki değer index, sağındaki değer sıra numarasıdır.
            var s = sayilar[ran];

            Range ran2 = 4..^3; // 1 ile başlar, tersten gelerek 3 değeri atar ve 5643 dahil olarak alır. 1,2,31,321,534,5643
            var s2 = sayilar[ran2];

            Range ran3 = ^7..^2; // Index olan 7 tersten gelerek bittiği sayıyı alır (31). Sıra numarası olan 2 ise tersten gelerek bir sonrakini alır (457).
            var s3 = sayilar[ran3];
            #endregion

        }
    }
}
