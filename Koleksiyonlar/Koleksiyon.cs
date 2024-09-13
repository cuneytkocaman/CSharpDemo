using System.Collections;

namespace Koleksiyonlar
{
    class Koleksiyon
    {
        static void Main(string[] args)
        {
            #region ArrayList

            #region ArrayList Tanımlama

            int[] yaslar = new int[17];
            ArrayList _yaslar = new ArrayList();

            #endregion

            #region Değer Atama

            for(int i = 0; i < 17; i++)
            {
                yaslar[i] = i * 10;

                _yaslar.Add(i + 10);
            }

            #endregion

            #region Değer Okuma

            Console.WriteLine(yaslar[5]);
            Console.WriteLine(_yaslar[7]);

            #endregion

            #region Boxing - Unboxing Durumları
            // ArrayList yapısında da sınırlılıklar vardır.
            // ArrayList verilen datayı boxing işlemine tabi tutar.
            // ArrayList içerisindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir. Dolayısıyla kendi türnde işlem yapabilmek için unboxing yapmak gerekir.

            // Örnek: Yaşlar arraylist'indeki değerlerin ortalamasını bulma.
            int toplam = 0;
            for (int i = 0; i < _yaslar.Count; i++) // ArrayList'te lenght yerine count kullanılır.
            {
                toplam += (int)_yaslar[i]; // Cast operatörü ile INBOXING yapıldı.
            }

            #endregion

            #region Collection Initializers (Koleksiyon İlklendirici) ile Değer Ekleme
            // ArrayList object olarak değer tuttuğu için değişik türler tanımlanabilir.
            ArrayList arrayList = new ArrayList()
            {
                "Cuneyt",
                139,
                'a',
                true
            };

            #endregion
            
            #endregion
        }
    }
}
