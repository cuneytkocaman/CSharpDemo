using System.Runtime.InteropServices.Marshalling;

namespace Demo
{
    class Program
    {
        static int classSayi; // Class içindeki değişkenlere default değerleri otomatik atanır, ama Main scope'u veya fonksiyon içindeki değişkenlere manuel değer atanmalıdır.
                              // Ayrıca bu değişken global değişkendir.
                              
        static void Main(string[] args)
        {
            Console.WriteLine("Class içindeki bulunan ve değeri atanmamış integer tür: " + classSayi.ToString());

            #region Programatik keyword (@)
            int @void = 10; // Değişken isimlerinde programatik keyword kullanmak için başına @ işareti koyulur.
            Console.WriteLine("Programatik keyword @: " + @void.ToString());
            #endregion

            #region Tuple değişken. Bir değişkene birden çok değer türü atama işlemi
            (int a, string b) c = (9, "ebrar"); // Tuple değişken. Bir değişkene birden çok özellik atama işlemidir.
            Console.WriteLine("Tuple Değişken: " + " int: " + c.a.ToString() + " , string: " + c.b);
            #endregion

            #region Default Keyword
            bool d = default; // default keyword'ü ile değişken türlerinin varsayılan değerleri geri dödürülür.
            int e = default; // default(int) olarak da tanımlanır.
            string f = default;
            Console.WriteLine("default değer: " + " bool: " +d.ToString() + " , int: " + e.ToString() + " , string: " + f);
            #endregion

            #region Değeri değiştirilemeyen tür (const)
            const double pi = 3.14d; // const: Değeri değiştirilemeyen, readonly değerlerdir.
            #endregion

            #region Object Tür, Boxing, cast () ile Unboxing
            object adi = "Cuneyt"; // Object tüm türleri (primitive, referans) karşılar. Gönderilen değere, burada string, BOXING denir.
            object objSayi = 19; // Object'in tuttuğu değer int olmasına rağmen matematiksel işlemler yapılamaz. İşlem yapmak için inboxing yapılmalıdır.
            int castSayi = (int)objSayi; // Cast operatörü () ile INBOXING yapıldı. Cast operatörü parantez işaretidir.
            Console.WriteLine("Inboxing işlemi ile işlem yaptırılan object tür: " + 5* castSayi);
            #endregion

            #region dynamic
            // dynamic RunTime'da çalışır. Türünü RunTime'da belirler. Uzaktan gelen türü bilinmeyen veriyi elde etmek için kullanılır.
            // var ise compaile anında çalışır, farkı budur.
            
            dynamic g = "Sibel";
            Console.WriteLine(g.GetType());
            g = 7;
            Console.WriteLine(g.GetType()); // dynamic karasızdır. RunTime'da çalıştığı için farkı türlere dönüştürülebilir.
            #endregion

            #region Tür dönüşümleri. Parse / Convert

            string dondur1 = "123";
            short don1 = short.Parse(dondur1);
            int don11 = Convert.ToInt32(dondur1);

            string dondur2 = "c";
            char don2 = char.Parse(dondur2);

            string calisiyormu = "true";
            bool calis = bool.Parse(calisiyormu);

            int dondur3 = 987;
            string don3 = Convert.ToString(dondur3);
            #endregion

            #region Sayısal Tür Dönüşümü. (Bilinçli ve Bilinçsiz)

            short h = 1987;
            byte i = (byte)h; // Daha düşük kapasiteli türe dönüştürmek bilinçli dönüşümdür.
            Console.WriteLine("Bilinçli Tür Dönüşümü: " + i.ToString());

            int j = h; // Daha üst kapasiteli türe dönüştürmek bilinçsiz dönüşümdür.

            //checked // Bilinçli tür dönüşümünde veri kaybı kontrolu checked bloğu ile yapılır. RunTime'da uyarır.
            //{
            //    int k = 257910;
            //    short l = (short)k; // int türünden short türüne dönüştürülürken, int'deki veri short'u aşacağı için veri kabı oluşur.
            //    Console.WriteLine("Check Kontrolü: " + l.ToString());
            //}
            #endregion

            #region Aritmetik Operatörlerle İşlemler
            int m = 10;
            double o = 5.5;
            double sonuc = m + o; // İki farklı türün işleminde küçük türe ait değişken compailer tarafından büyük türe ait değişkene dönüştürülür. Sonuc double döner.
            Console.WriteLine(sonuc.ToString());

            byte p = 3, r = 87;
            int s = r - p; // İki byte arasındaki işlem her zaman int olarak döner. (İstisna)
            #endregion

            #region Arttırma(++) Azaltma(--) Operatörleri
            
            int t = 5;
            Console.WriteLine("t++: " + t++); // Önce t değerini döndürür, sonra 1 arttırır. Çıktı 5, bellekte 6
            Console.WriteLine("t++'nın bellekteki durumu, arttırılmış hali: " + t);
            Console.WriteLine("++t: " + ++t); // t değerini 1 arttırır, yeni değeri döndürür. Çıktı 7, bellekte 7

            int t1 = 100;
            int t2 = ++t1;
            int t3 = t1;
            ++t2;
            Console.WriteLine(t1 + " " + t2 + " " + t3);
            #endregion

            #region Ternanry Operatörü
            bool medeniHal = true;
            string mesaj = medeniHal == true ? "Evlilere kampanya" : "Bekarlara kampanya";
            Console.WriteLine(mesaj);

            //Yaşı 25'ten büyük olanlara A, 25 olanlara B, 25'ten büyük olanlara C değeri döndüren Ternary Operatörü
            int yas = 29;
            string sonuc1 = yas < 25 ? "A"  : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc1);

            #endregion

            #region sizeof Operatörü
            // Türün bellekteki kapladığı alanı byte olarak geriye dödürür.
            Console.WriteLine("int sizeof: " + sizeof(int));
            Console.WriteLine("demical sizeof: " + sizeof(decimal));
            #endregion

            #region typeof Operatörü
            // Türün/değerin type'ını/türünü verir.
            Type ty = typeof(int);
            Console.WriteLine("type: " + ty.Name);
            Console.WriteLine("Primitive'mi: " + ty.IsPrimitive);
            Console.WriteLine("Class'mı': " + ty.IsClass);
            Console.WriteLine("Value Type'mı: " + ty.IsValueType);
            #endregion

            #region is Operatörü
            // Boxing'e tabi tutulmuş bir değerin öz türünü öğrenebilmek için kullanılır. True veya false olarak geri değer döndürür.
            // if yapılandırmasında kullanılır.
            object u = true;
            Console.WriteLine("is operatörü: " + u is bool); // Değişken boolean'mı diye kontrol edildi.
            #endregion

            #region is null & is not null Operatörü

            string v = null;
            Console.WriteLine("is null & is not null: " + v is null); // Değişken null mu değilmi kontrol edildi.

            //is null & is not null sadece null olabilen türlerde kullanılır. Yani Referans Türlü Değişkenlerde kullanılır. Değer Türlü Değişkenlerde(value type) kullanılmaz.
            #endregion

            #region as Operatörü
            // Inboxing işlemi yapar. as operatörü tür uygun olmadığı taktride geriye null döndüreceği için null karşılayabilen türle çalışır.Value Type değişkenler ile kullanılmaz.

            object y = "Ahmet";
            Program sy = y as Program; // Program bir referans türüdür.
            Console.WriteLine("as Operatörü: " + sy); // null döner
            #endregion

            #region nullable Operatörü (?)
            // Value Type değişkenlerin null değer alabilmesi için nullable ? operatörünü kullanmalıdır.

            int? z = null;
            bool? x = null;  // Değişkenler nullable yapıldığı için as, is null ,is not null operatörleri kullanılabilir.
            Console.WriteLine("nullable: " + x is null);

            #endregion

            #region Null-Coalescing ?? & Null-Coalescing Assignment Operatörü
            // Değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlar. Her iki taraftaki değişken aynı türde olmalıdır.

            string q1 = "Selam";
            string q2 = "";
            string q3 = null;

            Console.WriteLine("Null olamayan g1 değişkeni: " + q1 ?? "Merhaba");
            Console.WriteLine("Null olan q2 değişkeni: " + q2 ?? "Hoş geldin");
            Console.WriteLine("q3 değişkeninin assigment'ten sonraki hali: " + (q3 ??= "Nasılsın")); // q3 değeri null ise Nasılsın yazdır ve değeri q3 değişkenine ata.

            int? q4 = null; // nullable ile value type değişken null olarak tanımlandı.
            Console.WriteLine(q4 ??= 9); // assignment ile değer atandı.
            #endregion

            #region Akış Kontrol Mekanizmaları
            #region Switch-Case (when şartı & goto Keyword'ü)
            // Bir değişkenin değerini sadece eşitlik durumları kontrol ederken kullanılır. Şart sağlanırsa diğer şartlara bakılmaz. Scope'tan çıkılır.

            string isim = "Osman";

            switch(isim){
                case "Mehmet":
                    Console.WriteLine("Adı Mehmet");
                    break;

                case "Ayşe":
                    Console.WriteLine("Adı Ayşe");
                    break;

                default:
                    Console.WriteLine("Hiçbiri değil");
                    break;

            }

            // when başka şartları da kontrol etmeye yarar. VE gibi düşünülebilir.
            int tutar = 1000;

            switch (tutar){
                case 1000 when (3 == 5): 
                    break;

                case 1000 when (3 == 3):
                    break;
            }

            // goto

            int no = 10;

            switch (no)
            {
                case 5 :
                    Console.WriteLine(no * 10);
                    break;

                case 6:
                    Console.WriteLine(no + 15);
                    break;

                case 7:
                    goto case 5; // case 5 ile tekrar eden kod olduğundan goto komutu kullanılır. break komutu çalıştırılmaz.

                case 10:
                    goto case 5;

                case 12:
                case 13:
                    goto case 5; // Birden fazla goto kullanılacaksa birleştirilerek yazılabilir.
            }
            #endregion
            #endregion
        }
    }
}