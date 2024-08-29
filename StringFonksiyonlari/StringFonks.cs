namespace StringFonksiyonlari
{
    class StringFonks
    {
        static void Main(string[] args)
        {
            string metin = "Nesne yönelimli programlama dillerinde interface, değişik sınıflardan nesnelerin kategorize edilmesini sağlayan bir soyut tür çeşitidir...";
            Console.WriteLine(metin);

            Console.WriteLine(metin);

            #region Contains 
            // İlgili metin içerisinde aranan karakterin veya değerin geçip geçmediğini bool olarak döndürür.
            bool sonuc = metin.Contains("yön");
            Console.WriteLine($"Contains: {sonuc}");
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region StartsWith & EndsWith
            // StartsWith: İlgili metinin verilen değerle başlayıp başlamadığını kontrol eder.
            // EndsWith: İlgili metinin verilen değerle bitip bitmediğini kontrol eder.

            Console.WriteLine($"StartsWith: {metin.StartsWith("NEsne")} ");
            Console.WriteLine($"EndsWith: {metin.EndsWith("r...")}  ");
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Equals
            // Eşitlik durumunu denetler.
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Compare & CompareTo
            // Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak int değer elde etmemizi sağlar.
            // 0: Her iki değer birbirine eşit
            // 1: Soldaki sağdakinden alfanumerik olarak büyük
            // -1: Soldaki sağdakinden alfanumerik olarak küçük

            Console.WriteLine("Compare");
            Console.WriteLine(string.Compare(metin, metin) );
            Console.WriteLine(string.Compare(metin, 15, metin, 9, 5)); // 15 ve 9 başlangıç karakterleri. 5 başlangıçtan sonra alınacak karakter sayısı.
            Console.WriteLine("CompareTo");
            Console.WriteLine(metin.CompareTo("C"));

            #endregion 

            Console.WriteLine("-------------------------------------------------------------");

            #region IndexOf
            // String içinde verilen değeri arayan fonksiyondur. Geriye int olarak indexno döndürür.
            
            Console.WriteLine("IndexOf ile arama:");
            Console.WriteLine(metin.IndexOf("ne")); // İlk eşleşen değerin index'ini döndürür.
            Console.WriteLine(metin.IndexOf("fa"));
            Console.WriteLine(metin.IndexOf("ir."));
            Console.WriteLine(metin.IndexOf("cü")); // Yok ise -1 döndürür.

            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Insert
            // Metinsel ifdadeye bir değer eklemeyi sağlar.

            Console.WriteLine("Insert ile ifede ekleme: ");
            string eklenmisMetin = metin.Insert(18, " MERHABA ");
            Console.WriteLine(eklenmisMetin);
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Remove
            // İndexel olarak verilen aralığı silen fonksiyondur.
            // Orijinal veriye dokunmaz.
            Console.WriteLine("Remove ile silme: ");
            Console.WriteLine(metin.Remove(9)); // 5. indexten sonraki bütün değerleri siler.
            Console.WriteLine(metin.Remove(19, 37));

            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Replace
            // Belirtilen değerleri ve ya karakterleri, belirtilen diğer değerler ya da kadarterler ile değiştiren fonksiyondur.
            Console.WriteLine(metin.Replace('n', 'X'));
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Split
            // Parçalama sağlayan fonksiyondur.
            string[] dizi = metin.Split(' ');
            Console.WriteLine();
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region SubString
            // Metinsel ifadenin belirli bir alanının elde edilmesini sağlar.
            Console.WriteLine("SubString ile parçalama: ");
            Console.WriteLine(metin.Substring(35));
            Console.WriteLine(metin.Substring(11,20));

            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region ToLower & ToUpper
            // ToLower: İstenen değeri küçültür.
            // ToUpper: İstenen değeri küçültür.
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region Trim
            // Boşlukları silen fonksiyondur.
            Console.WriteLine("Trim ile boşluk silme: ");
            Console.WriteLine("  ebrar sibel     ".Trim());
            #endregion

            Console.WriteLine("-------------------------------------------------------------");

            #region TrimEnd & TrimStart
            // TrimEnd: İfadenin sonundaki boşlukları siler.
            // TrimStart: İfadenin başındaki boşlukları siler.
            #endregion
        }
    }
}