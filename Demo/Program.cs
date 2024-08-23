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

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Tuple değişken. Bir değişkene birden çok değer türü atama işlemi
            (int a1, string a2) a3 = (9, "ebrar"); // Tuple değişken. Bir değişkene birden çok özellik atama işlemidir.
            Console.WriteLine("Tuple Değişken: " + " int: " + a3.a1.ToString() + " , string: " + a3.a2); // a1 ve a2 değişkenleri atandığı a3 değişkeni üzerinden  çağrıldı.
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Default Keyword
            bool b1 = default; // default keyword'ü ile değişken türlerinin varsayılan değerleri geri dödürülür.
            int b2 = default; // default(int) olarak da tanımlanır.
            string b3 = default;
            Console.WriteLine("default değer: " + " bool: " + b1.ToString() + " , int: " + b2.ToString() + " , string: " + b3);
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Değeri değiştirilemeyen tür (const)
            const double pi = 3.14d; // const: Değeri değiştirilemeyen, readonly değerlerdir.
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Object Tür, Boxing, cast () ile Unboxing
            object adi = "Cuneyt"; // Object tüm türleri (primitive, referans) karşılar. Gönderilen değere, burada string, BOXING denir.
            object objSayi = 19; // Object'in tuttuğu değer int olmasına rağmen matematiksel işlemler yapılamaz. İşlem yapmak için inboxing yapılmalıdır.
            int castSayi = (int)objSayi; // Cast operatörü () ile INBOXING yapıldı. Cast operatörü parantez işaretidir.
            Console.WriteLine("Inboxing işlemi ile işlem yaptırılan object tür: " + 5 * castSayi);
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region dynamic
            // dynamic RunTime'da çalışır. Türünü RunTime'da belirler. Uzaktan gelen türü bilinmeyen veriyi elde etmek için kullanılır.
            // var ise compaile anında çalışır, farkı budur.

            dynamic c1 = "Sibel";
            Console.WriteLine(c1.GetType());
            c1 = 7;
            Console.WriteLine(c1.GetType()); // dynamic karasızdır. RunTime'da çalıştığı için farkı türlere dönüştürülebilir.
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

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

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Sayısal Tür Dönüşümü. (Bilinçli ve Bilinçsiz)

            short d1 = 1987;
            byte d2 = (byte)d1; // Daha düşük kapasiteli türe dönüştürmek bilinçli dönüşümdür.
            Console.WriteLine("Bilinçli Tür Dönüşümü: " + d2.ToString());

            int d3 = d1; // Daha üst kapasiteli türe dönüştürmek bilinçsiz dönüşümdür.

            //checked // Bilinçli tür dönüşümünde veri kaybı kontrolu checked bloğu ile yapılır. RunTime'da uyarır.
            //{
            //    int k = 257910;
            //    short l = (short)k; // int türünden short türüne dönüştürülürken, int'deki veri short'u aşacağı için veri kabı oluşur.
            //    Console.WriteLine("Check Kontrolü: " + l.ToString());
            //}
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Aritmetik Operatörlerle İşlemler
            int e1 = 10;
            double e2 = 5.5;
            double sonuc = e1 + e2; // İki farklı türün işleminde küçük türe ait değişken compailer tarafından büyük türe ait değişkene dönüştürülür. Sonuc double döner.
            Console.WriteLine(sonuc.ToString());

            byte e3 = 3, e4 = 87;
            int e5 = e4 - e3; // İki byte arasındaki işlem her zaman int olarak döner. (İstisna)
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Arttırma(++) Azaltma(--) Operatörleri

            int f1 = 5;
            Console.WriteLine("t++: " + f1++); // Önce t değerini döndürür, sonra 1 arttırır. Çıktı 5, bellekte 6
            Console.WriteLine("t++'nın bellekteki durumu, arttırılmış hali: " + f1);
            Console.WriteLine("++t: " + ++f1); // t değerini 1 arttırır, yeni değeri döndürür. Çıktı 7, bellekte 7

            int f2 = 100;
            int f3 = ++f2;
            int f4 = f2;
            ++f3;
            Console.WriteLine(f2 + " " + f3 + " " + f4);
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Ternanry Operatörü Tek Satırlık İf Else
            bool medeniHal = true;
            string mesaj = medeniHal == true ? "Evlilere kampanya" : "Bekarlara kampanya";
            Console.WriteLine(mesaj);

            //Yaşı 25'ten büyük olanlara A, 25 olanlara B, 25'ten büyük olanlara C değeri döndüren Ternary Operatörü
            int yas = 29;
            string sonuc1 = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc1);

            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region sizeof Operatörü
            // Türün bellekteki kapladığı alanı byte olarak geriye dödürür.
            Console.WriteLine("int sizeof: " + sizeof(int));
            Console.WriteLine("demical sizeof: " + sizeof(decimal));
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region typeof Operatörü
            // Türün/değerin type'ını/türünü verir.
            Type g1 = typeof(int);
            Console.WriteLine("type: " + g1.Name);
            Console.WriteLine("Primitive'mi: " + g1.IsPrimitive);
            Console.WriteLine("Class'mı': " + g1.IsClass);
            Console.WriteLine("Value Type'mı: " + g1.IsValueType);
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region is Operatörü
            // Boxing'e tabi tutulmuş bir değerin öz türünü öğrenebilmek için kullanılır. True veya false olarak geri değer döndürür.
            // if yapılandırmasında kullanılır.
            object h1 = true;
            Console.WriteLine("is operatörü: object h1: " + h1 is bool); // Değişken boolean'mı diye kontrol edildi.
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region is null & is not null Operatörü

            string i1 = null;
            Console.WriteLine("is null & is not null: " + i1 is null); // Değişken null mu değilmi kontrol edildi.

            //is null & is not null sadece null olabilen türlerde kullanılır. Yani Referans Türlü Değişkenlerde kullanılır. Değer Türlü Değişkenlerde(value type) kullanılmaz.
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region as Operatörü
            // Inboxing işlemi yapar. as operatörü tür uygun olmadığı taktride geriye null döndüreceği için null karşılayabilen türle çalışır.
            // Value Type değişkenler ile kullanılmaz.

            object k1 = "Ahmet";
            Program k2 = k1 as Program; // Program bir referans türüdür.
            Console.WriteLine("as Operatörü: " + k2); // null döner
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region nullable Operatörü (?)
            // Value Type değişkenlerin null değer alabilmesi için nullable ? operatörünü kullanmalıdır.

            int? l1 = null;
            bool? l2 = null;  // Değişkenler nullable yapıldığı için as, is null ,is not null operatörleri kullanılabilir.
            Console.WriteLine("nullable: " + l2 is null);

            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region Null-Coalescing ?? & Null-Coalescing Assignment Operatörü
            // Değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlar. Her iki taraftaki değişken aynı türde olmalıdır.

            string m1 = "Selam";
            string m2 = "";
            string m3 = null;

            Console.WriteLine("Null olamayan g1 değişkeni: " + m1 ?? "Merhaba");
            Console.WriteLine("Null olan q2 değişkeni: " + m2 ?? "Hoş geldin");
            Console.WriteLine("q3 değişkeninin assigment'ten sonraki hali: " + (m3 ??= "Nasılsın")); // m3 değeri null ise Nasılsın yazdır ve değeri m3 değişkenine ata.

            int? m4 = null; // nullable(?) ile value type değişken null olarak tanımlandı.
            Console.WriteLine(m4 ??= 9); // assignment ile değer atandı.
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");

            #region AKIŞ KONTROL MEKANİZMALARI

            #region Switch-Case (when şartı & goto Keyword'ü)
            // Bir değişkenin değerini sadece eşitlik durumları kontrol ederken kullanılır. Şart sağlanırsa diğer şartlara bakılmaz. Scope'tan çıkılır.

            string isim = "Osman";

            switch (isim)
            {
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

            switch (tutar)
            {
                case 1000 when (3 == 5):
                    break;

                case 1000 when (3 == 3):
                    break;
            }

            // goto

            int no = 10;

            switch (no)
            {
                case 5:
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

            #region Switch Expressions

            int n1 = 5;
            string isim1 = n1 switch // Tek satırlık switch
            {
                3 => "Hilmi", // => ise demek
                5 => "Veli",
                7 => "Yasin" // when ile fazladan şart işlemi
            };

            //Tupple Patterns
            int n3 = 10, n4 = 20;

            string msg = (n3, n4) switch
            {
                (5, 10) => "5 ile 10 değerleri.", // Şart 5 ve 10 ise bu sonucu döndür. Buradaki (5,10) klasik case değerleri
                (10, 20) => "10 ile 20 değerleri."
            };

            Console.WriteLine("Tupple Patterns switch: " + msg);
            #endregion

            #region Peş peşe If
            int o1 = 275; 

            if (o1 > 100 && o1 <= 200)
            {
                Console.WriteLine("100 ile 200 arasında");
            }
            if (o1 > 200 && o1 <= 300) // Peş peşe if ile yazılırsa iki şartı da sağlamış olur.
            {
                Console.WriteLine("200 ile 300 arasında");
            }
            if (o1 > 200 && o1 <= 400) // Peş peşe if ile yazılırsa iki şartı da sağlamış olur.
            {
                Console.WriteLine("200 ile 400 arasında");
            }
            #endregion

            #region Pattern Matching
            object p1 = "abcde";

            // Type Pattern: Object içindeki bir tipin berlirlenmesinde kullanılan is operatörünün desenleştirilmiş halidir.
            bool result1 = p1 is string p2;
            // Console.WriteLine(p2); // Bu yazdırma işlemi hata verir. Sebebi null gelme ihtimali ve string'in bunu karşılayamammasıdır.

            // Constant Pattern: Elimizdeki veriyi sabit bir değer ile karşılaştırabilmemizi sağlar. Eşittire denk gelebilir. is operatörü değer (int, string, long vs) kontrol ediyorsa Constant'tır.

            // Var Pattern: Eldeki veriyi 'var' değişkeni ile elde etmeyi sağlar. var normalde compaile sürecinde çalışır, buradaki var keyword'ü ise runtime sürecinde çalışır.

            bool result2 = p1 is var p3; // Pattern'ın illa if else içinde kullanılması gerekmez. Burada p1 değeri bool'mu diye soruldu ve sonuca göre değeri p3'ye atandı.
            Console.WriteLine(p1); // p3 değeri 'var' yerine başka bir value type olarak tanıtılsaydı null olma durumundan ötürü hata verecekti.
                                   // Burada p1'in türü ne olursa olsun 'var' değişkeni karşılayabileceği için ve 'var' null'u da karşıladığı için hata vermeyecektir.

            // Recursive Pattern: Switch-case üzerinde birçok yenilik getirmektedir. Switch bloğunda referans türlü değişkenler de kontrol edilebilmektedir.

            // Relational Pattern: Desenlerde <,>,<=,>= operatörleri kullanabilmekte ve belirli karşılaştırmalar hızlıca yapılabilmektedir.
            // Switch özü itibari ile sadece eşitlik durumlarını kontrol eder. Relational pattern ile karşılaştırmalar yapılabilir.

            int p4 = 123;

            string result3 = p4 switch
            {
                < 50 => "50'den küçük",
                > 50 => "50'den büyük",
                50 => "50'ye eşit"
            };

            Console.WriteLine("Relational Pattern: " + result3);

            // Logical Pattern

            #endregion

            #endregion

        }
    }
}