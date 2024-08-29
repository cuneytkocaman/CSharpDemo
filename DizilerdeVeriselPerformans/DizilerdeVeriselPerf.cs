namespace DizilerdeVeriselPerformans
{
    class DizilerdeVeriselPerf
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] sayilar2 = sayilar[2..5];

            #region ArraySegment nedir?
            // Bir dizinin bütününden ziyade belirli bir kısmına yahut parçasına ihtiyaç dahilinde ilgili diziyi kopyalama yerine
            // (ki görece oldukça maliyetli bir operasyondur) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan yapıdır.

            ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); // sayilar dizisi sagment1 ile referans edildi. ArraySegment, sayilar dizisini türetmez.
                                                                         // sayilar dizisinde oluşan değişiklikler ArraySegment'te de gözükür.

            ArraySegment<int> segment2 = new ArraySegment<int>(sayilar, 2, 5); // Burada yeni alan tahsisinde bulunmadan dizi içindeki istenen elemanlar ile işlem yapıldı.

            Console.WriteLine(segment2[1]);
            #endregion

            #region ArraySegment Slicing(Dilimleme)
            // Bir dizi üzerinde birden fazla parçada çalışılacaksa eğer herbir parça ayrı bir ArraySegment olarak tanımlanabilir.
            // Bu tanımlamaların dışında diziyi tek bir ArraySegment ile referans edip ilgili parçalar o segment üzerinden talep edilebilir.
            // Yani ilgili dizi tek bir segment üzerinden daha rahat bir şekilde parçalanabilir.
            // Bu durum yazılımsal açıdan efektiflik kazandırılmış olur.

            ArraySegment<int> segment3 = new ArraySegment<int>(sayilar);
            ArraySegment<int> segSlice = segment3.Slice(0, 3);
            ArraySegment<int> segSlice2 = segment3.Slice(6, 9);
            #endregion
        }
    }
}