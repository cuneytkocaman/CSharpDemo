namespace Diziler
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            // Referans türlüdür. Nesnel yapılardır. Özlerinde class'tırlar.
            // Diziler aynı türle değer tutar. RAM'da birden fazla değeri, tek bir değişken altında, bir veri kümesi halinde tutarlar. HEAP' te tutulurlar.
            // İçine her türlü değer koyulabilir.(referans tür veya değer türlü)
            // []: Indexer ismi verilir.
            // Diziler sınırlıdır. Eleman sayısını baştan belirtmek gerekir ve o elaman sayısı aşılamaz. Daha az girilebilir fakat bu sefer de hafızada gereksiz yer kaplar.
            var dizi1 = new[] { 12, 3, 4, 9, }; // Farklı bir değer atama varyasyonudur. Dizinin türü süslü parantez içinde belirlenir.

            #region ARRAY SINIFI
            // Dizi olarak tanımlanan değişkenler Array sınıfından türetilmektedir. Dizilerde array sınıfından gelen metotlar ve özellikler mevcuttur.

            Array dizi2 = new int[3]; // Dizi eğer Array türünde referans ediliyorsa indexer kullanılamaz.
                                      // Dizi işlemleri fonksiyonel olarak yapılır.

            int[] dizi3 = new int[5]; // Dizi eğer kendi türünde referans ediliyorsa indexer kullanılır.
                                      // Dizi işlemleri indexer ile yapılır.

            #region Değer atama ve değer okuma
            // Aşağıda yazılan değer atama yönteminden başka, dizilere uygulanan değer atama yöntemleri de kullanılır.
            Array dizi4 = new int[3];
            dizi1.SetValue(7, 0);
            dizi2.SetValue(8, 0);
            dizi2.SetValue(9, 0);
            // Değer okuma.
            dizi2.GetValue(2); // GetValue, array içinde hangi tür olduğu ile ilgilenmez ve değeri object'e boxing eder.
                               // Değeri kullanabilmek için istenen türe unboxing etmek gerekir.
            #endregion

            Array isimler = new[] { "Hilmi", "Hüseyin", "Osman", "Ali", "Veli" };

            Console.WriteLine("Orijinal dizi: ");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }

            #region Clear fonksiyonu: Dizi içindeki tüm elemanlara türüne uygun default değer atar.

            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(i));

            //Array.Clear(isimler, 1, 2); // 1. indexten başla, 2 değer kadar git ve default değer ata
            //Console.WriteLine("----------------------------------");

            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(1));

            #endregion

            Console.WriteLine("--------------------------------------");

            #region Copy fonksiyonu: Klonlama yapar.
            // Dizinin verileri başka diziye kopyalar.

            string[] isimler2 = new string[isimler.Length];
            Array.Copy(isimler, 2, isimler2, 1, 2); // isimler: kaynak, 2: başlanacak index, isimler2: hedef, 1: hedefteki başlangıç index, 2: kaç tane bilgi kopyalacak

            Console.WriteLine("Kopyalama sonrası yeni dizi: ");

            for (int i = 0; i < isimler2.Length; i++)
                Console.WriteLine(isimler2[i]);

            #endregion

            Console.WriteLine("--------------------------------------");

            #region IndexOf fonksiyonu: Dizi içinde arama.
            // Veri yoksa -1 döndürür.
            int index = Array.IndexOf(isimler, "Veli");
            if (index != -1)
                Console.WriteLine("IndexOf ile aranan veri mevcut.");

            int index2 = Array.IndexOf(isimler, "Hilmi", 3, 2); // 3: başlangıç indexi, 2: başlangıçtan sonra gidilecek index sayısı
            if (index2 == -1)
            {
            }
            Console.WriteLine("Aranan veri yok.");

            #endregion

            Console.WriteLine("--------------------------------------");

            #region Reverse fonksiyonu: Diziyi terse çevirir.

            Console.WriteLine("Reverse ile dizi ters çevrildi: ");

            Array.Reverse(isimler); // Array.Reverse(isimler, 0, 3): Bu şekilde aralık belirterek de kullanılır.
            for (int i = 0; i < isimler.Length; i++)
                Console.WriteLine(isimler.GetValue(i));

            #endregion

            Console.WriteLine("--------------------------------------");

            #region Sort fonksiyonu: Diziyi sıralar

            Console.WriteLine("Sıralama sonrası dizi: ");
            Array.Sort(isimler);
            for(int i = 0; i < isimler.Length; i++)
                Console.WriteLine(isimler.GetValue(i));

            #endregion

            Console.WriteLine("--------------------------------------");

            #region Array Propertys
            // IsReadOnly: Bir dizinin sadece okunabilir olup olmadığını bool türünde denetler.
            Console.WriteLine("IsReadOnly Property: " + isimler.IsReadOnly);

            // IsFixedSize: Dizinin eleman sayısının sabit olup olmama durumunu gösterir. Tüm dizilerde eleman sayısı sabit olacağınadan true döner.

            // Lenght: Dizinin eleman sayısını döndürür.

            // Rank: Dizinin derecesini döndürür.
            Console.WriteLine("Rank ile dizi isimler dizisinin derecesi: " + isimler.Rank);
            #endregion

            Console.WriteLine("--------------------------------------");

            #region CreateInstance Metodu

            int[] no = new int[3];
            // Normalde yukarıdaki gibi oluşturulan dizi tanımlaması esasında arkaplanda Array sınıfının CreateInstance metodunu kullanmaktadır.
            // Bu metodu kullanarak fonksiyonel diziler oluşturulabilir. 
            Array no2 = Array.CreateInstance(typeof(int), 3);

            #endregion

            #endregion
        }
    }
}
