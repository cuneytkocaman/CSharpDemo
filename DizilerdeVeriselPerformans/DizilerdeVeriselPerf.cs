using Microsoft.Extensions.Primitives;
using System.Text;

namespace DizilerdeVeriselPerformans
{
    class DizilerdeVeriselPerf
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] sayilar2 = sayilar[2..5];

            string text = @"ArraySegment ve StringSegment elimizdeki array değerlerin bir bölümünü temsil etmek ve 
                            böylece bellekte yersiz bir tahsis işlemine gerek kalmaksızın işlem gerçekleştirebilmek 
                            için geliştirilmiş struct’tırlar.";

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
            #endregion

            #region StringSegment
            // ArraySegment'in string değerler nezdinde muadilidir.
            // Metinsel değerlerdeki bir çok analitik operasyonlardan bizleri kurtarmakta ve Substring gibi fonksiyonlar yerine string değerde hedef kesit üzerinde
            // işlem yapmamızı sağlayan bir türdür.
            // StringSegment’i kullanabilmek için Microsoft.Extensions.Primitives namespace’inin using edilmesi gerekmektedir.

            
            StringSegment stringSegment = new StringSegment(text);
            StringSegment stringSegment1 = new StringSegment(text, 11, 29); // Burada substring işlemindeki gibi yeni bir değer üretilmedi. İlgili alan temsil edildi.
                                                                          // Performans artışı sağlandı
            Console.WriteLine("StringSegment: " + stringSegment1);
            #endregion

            #region StringBuilder Sınıfı: String birleştirme sınıfı
            // String verilerin + operatörüyle birleşme işleminin aynısını yapmaktadır. 
            // Ancak + operatörüyle stringler birleştirilirken bellekte bir sürü geçiçi string ifadeler oluşturulur.
            // Bu işlem StringBuilder sınıfını kullanarak yapılırsa büyük oranda performans kaybı önlenmiş olur.

            string isim = "Ebrar", soyisim = "Kocaman";

            StringBuilder builder = new StringBuilder();
            builder.Append(isim);
            builder.Append(" ");
            builder.Append(soyisim);

            Console.WriteLine($"StringBuilder: {builder.ToString()}");
            #endregion

            #region Span: Bellekteki belli bir alanı temsil eder.
            // ArraySegment ve StringSegment sadece string ve diziler üzerinde çalışır. Span istenen herhangi bir alanı referans eder.
            // 

            Span<int> span = new Span<int>(sayilar); // Diziyi komple temsil eder.
            Span<int> span2 = sayilar;  // Diziyi komple temsil eder.
            Span<int> span3 = new Span<int>(sayilar, 3, 5); // 3. indexli elemandan (40) başlar. Geri kalandan 5 eleman alır. (40,50,60,70,80)

            Span<int> span4 = sayilar.AsSpan(); // Diziyi komple temsil eder.
            Span<int> span5 = sayilar.AsSpan(3, 5);

            #endregion

        }
    }
}