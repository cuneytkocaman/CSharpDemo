﻿namespace String_Turu
{
    class StringTur
    {
        static void Main(string[] args)
        {
            // String referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.

            #region Null
            // Bir değişken/nullable/referans null değer alıyorsa herhangi ibr alan tahsis etmemiştir.
            // Sadece referans türlü değişkenler null olur, değer türlüler olmaz.
            // Null olan bir değer üzerinde işlem yapmaya çalışıldığında runtime hatası alınır.

            int? i = null; // Değer türlüler sadece nullable(?) operatör ile null olabilir.

            #endregion

            #region Empty
            // Bir değişken/nullable/referans empty ise alan tahsisi yapılmış ama değeri yoktur.
            // Tüm değerler empty alabilir.
            // Default değerlerin olduğu durumlar empty olarak geçer.

            int a = 0; // integer'in default değeri 0'dır.
            bool b = false;
            string c = ""; // Bellekte bir alanı vardır. string.Empty olarak da yazılabilir.
            string _c = null; // Bellekte yer kaplamaz

            #endregion

            #region IsNullOrEmpty
            // String ifadelerin işleme tabi tutulamadan önce kontrol edilmeleri gerekmektedir.

            string s = "";

            if (!string.IsNullOrEmpty(s)) // Eğer değer null veya empty ise false değer döner.
            {
                // Kodlar
            }

            #endregion

            #region IsNullOrWithSpace
            // Elimizdeki string ifadenin null, empty veya boşluk karakterlerinden ibaret olma durumunu geriye döndürür.

            string s1 = "     ";

            if (!string.IsNullOrWhiteSpace(s1))
            {
                //Kodlar
            }

            #endregion

            #region String - Char dizisi
            // String ifadeler esasında char dizisidir. Yazılım açısında string ifade yoktur. Karakterlerin bir araya gelmiş halidir.
            // String ifadeler özünde bir char dizisi, yani dizi, olduğundan referans türlü değişkenlerdir. Çünkü diziler referans türlüdür.
            // Yani nesnedirler, heap'te tutulurlar.

            string metin = "Naber nasılsın ne yaptın neredesin";
            Console.WriteLine(metin[11]); // Char dizisi olduklarından dolayı her bir karakter baştan sona otomatik indexlenir. Indexer operatörü kullanılabilir.

            int k = 0;
            Console.WriteLine("e harfinin olduğu dizi indexleri: " + k);
            while (k < metin.Length)
            {
                if (metin[k] == 'e')
                    Console.Write(k + " ");
                k++;
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region String Formatlandırma
            string isim = "Cüneyt", soyisim = "Kocaman", tcNo = "12345678901";
            int yas = 37;
            bool medeniHal = true;

            #region + Operatörü
            // + operatörü hem kod hem de performans açısından oldukça maliyetlidir.

            Console.WriteLine("+ Operatörü String Formatlandırma");
            Console.WriteLine("TC No:" + tcNo + " olan " + isim + " " + soyisim + " " + "şahsın bilgileri " + " | " + "Yaş:" + yas + " | " + "Medeni Hal: " + (medeniHal ? "Evli" : "Bekar"));

            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region string.Format

            Console.WriteLine("string.Format ile Formatlandırma");
            //string.Format("TC No: {0} olan {1} {2} şahsın bilgileri | Yaş: {3} | Medeni Hal: {4}", tcNo, isim, soyisim, "abc");

            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region $(String.Interpolation)
            Console.WriteLine("$ String.Interpolation ile Formatlandırma");
            Console.WriteLine($"TC No: {tcNo} olan {isim} {soyisim} şahsın bilgileri | Yaş: {yas} | Medeni Hal: {(medeniHal ? "Evli" : "Bekar" )}");
            #endregion

            #endregion
        }
    }
}
