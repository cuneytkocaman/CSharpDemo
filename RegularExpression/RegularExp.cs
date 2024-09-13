using System.Text.RegularExpressions;

namespace RegularExpression
{
    class RegularExp
    {
        static void Main(string[] args)
        {
            //
            string text = "97 98111csefgthdtyi651";
            
            #region Operatörler

            #region ^ Operatörü : Satır başının istenen ifade ile başlamasını sağlar.

            Regex regex = new Regex("^97"); // Verilen ifade 97 ile başlamalı.
            Match match = regex.Match(text);
            Console.WriteLine(match.Success); // Sonucu bool olarak döndürür.

            #endregion

            #region \ Operatörü: Belirli karakter gruplarını içermesini istiyorsak kullanılır.
            // \D: Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiğini belirtir.
            // \d: Metinsel değerin ilgili yerinde 0-9 arası tek bir sayı bulunması gerektiğini belirtir.

            // \W: Metinsel değerin ilgili yerinde alfanumerik olmayan karakterin bulunması gerektiğini belirtir. Alfanumerik karakterler: a-z A-Z 0-9
            // \w: Metinsel değerin ilgili yerinde alfanumerik olan karakterin bulunması gerektiğini belirtir.

            // \S: Metinsel değerin ilgili yerinde boşluk karakteri(tab/space) dışında herhangi bir karakterin olmayacağını belirtir. İlgili alanda boşluk olmayacak.
            // \s: Metinsel değerin ilgili yerinde boşluk karakterinin bulunması gerektiğini belirtir.

            // Örnek: 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzemli ifade oluşturun: ^9\d\S

            Regex regex1 = new Regex(@"^9\d\S");
            Match match1 = regex1.Match(text);
            Console.WriteLine($@"^9\d\S : {match1.Success}");

            #endregion

            #region + Operatörü: Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılır.
            // Örnek: 9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturun: ^9\d+\S
           
            string text2 = "91ce9651651s";
            Regex regex2 = new Regex(@"^9\d+\S");
            Match match2 = regex2.Match(text2);
            Console.WriteLine($@"^9\d+\S: {match2.Success}"); // 9'dan sonra en az bir karakter sayı olduğu için True döner.


            #endregion

            #region | (veya) Operatörü
            // Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek için kullanılır.
            //Örnek: Baş harfi a ya da b ya da c olan metinsel ifadeyi oluşturun.

            Regex regex3 = new Regex(@"a|b|c");
            Match match3 = regex3.Match(text);

            Console.WriteLine($"a|b|c {match.Success}");
            #endregion

            #region {n} Operatörü: Sabit sayıda karakter olması isteniyorsa {adet} şeklinde belirtilir.

            string tel = "555-9998877";
            Regex regex4 = new Regex(@"\d{3}-\d{7}"); // Telefon numarasının formatı kontrol edildi.
            Match match4 = regex4.Match(text);

            Console.WriteLine($@"{{}} Operatörü: {match.Success}");

            #endregion

            #region ? Operatörü: Bu karakterin önüne gelen karakter en fazla bir en az sıfır olabilmektedir.
            // Örnek: \d{3}B?A regular expression'a göre 234BA, 549BA, 854A, 123BBA ifadelerinin geri dönüş değerleri nedir.

            string ifade = "123BBA";
            Regex regex5 = new Regex(@"\d{3}B?A");
            Match match5 = regex5.Match(ifade);

            Console.WriteLine($"? Operatörü: {ifade} --> {match5.Success}");
            #endregion

            #region . Operatörü: Kullanıldığı yerde \n Karakteri dışında herhangi bir karakter bulunabilir.

            string ifade2 = "ebrar123?A";
            Regex regex6 = new Regex(@"\d{3}.A"); // Metin sonu A ile bitecek ve önünde herhangi bir 
            Match match6 = regex6.Match(ifade2);

            Console.WriteLine($". Operatörü: {ifade2} --> {match6.Success}");
            #endregion

            #region \b \B Operatörleri
            // \B: Metinsel ifadenin başında ve sonunda olmaması gereken karakterleri ifade eder.
            // \b: Metinsel ifadenin sonunda olması gereken karakterleri ifade eder.

            string ifade3 = "132dır";
            Regex regex7 = new Regex(@"\d{3}dır\B"); // \B ile başında veya sonunda 'dır' olmaması kontrolü yapıldı.
            Match match7 = regex7.Match(ifade3);

            Console.WriteLine($@"\b ve \B Operatörleri: {match7.Success}");
            #endregion

            #region [n] Operatörü: Karakter aralığını belirtir.
            // Ayrıca özel karakterlerin yerinde yazılmasını da ifade eder.

            string ifade4 = "(555) 321 32 21";
            Regex regex8 = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
            Match match8= regex8.Match(ifade4);

            Console.WriteLine($"[] Operatörü: {ifade4} --> {match8.Success}");
            #endregion

            #region Match Sınıfı

            string ifade5 = "123456 abcdef g?-* 0987qwx+.yz";
            Regex regex9 = new Regex(@"yz\b"); 
            Match match9 = regex9.Match(ifade5);

            Console.WriteLine();
            Console.WriteLine("Match Sınıfı");
            Console.WriteLine($"Success : {match9.Success}");
            Console.WriteLine($"Value : {match9.Value} ");
            Console.WriteLine($"Index : {match9.Index} "); // Doğrulanın başladığı index
            Console.WriteLine($"Length : {match9.Length} "); // Kaç karakter doğrulama yapıldı.

            #endregion

            #endregion
        }
    }
}
