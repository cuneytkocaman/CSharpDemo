
using System.Reflection.Metadata;

namespace Demo2
{
    class Program2
    {
        static void Main(string[] args)
        {
            #region Tek satırlık Switch çalışması

            //Console.WriteLine("Ay için bir sayı gir: ");
            //int ay = Int32.Parse(Console.ReadLine());


            //string secilenAy = ay switch
            //{
            //    1 => secilenAy = "Ocak",
            //    2 => secilenAy = "Şubat",
            //    3 => secilenAy = "Mart",
            //    4 => secilenAy = "Nisan",
            //    5 => secilenAy = "Mayıs",
            //    6 => secilenAy = "Haziran",
            //    7 => secilenAy = "Temmuz",
            //    8 => secilenAy = "Ağustos",
            //    9 => secilenAy = "Eylül",
            //    10 => secilenAy = "Ekim",
            //    11 => secilenAy = "Kasım",
            //    12 => secilenAy = "Aralık",
            //    _ => secilenAy = "Yanlış değer"
            //};

            //Console.WriteLine(secilenAy);

            #endregion

            #region Tupple Patterns Switch

            Console.WriteLine("Kullanıcı Adı: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Parola: ");
            string p = Console.ReadLine();

            string giris = (ad, p) switch
            {
                ("user", "123") => "Giriş Yapıldı",
                (_, _) => "Bilgiler hatalı"

            };
            Console.WriteLine(giris);

            #endregion

            #region Toplama, çıkarma, çarpma, bölme

            Console.WriteLine("Sayi 1: ");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayi 2: ");
            int say2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplama için +, Çıkarma için -, Çarpma için *, Bölme için /");
            char islem = char.Parse(Console.ReadLine());

            int sonuc = islem switch
            {
                '+' => say1 + say2,
                '-' => say1 - say2,
                '*' => say1 * say2,
                '/' => say1 / say2,
                _ => 0
            };

            Console.WriteLine(sonuc.ToString());

            Console.WriteLine(islem == '+' ? say1+say2 : (islem == '-' ? say1-say2 : (islem == '*' ? say1*say2 : say1/say2))); // Tupple
            #endregion

            
        }
    }
}
