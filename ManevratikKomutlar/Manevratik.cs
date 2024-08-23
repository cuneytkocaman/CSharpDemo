namespace ManevratikKomutlar
{
    public class Manevratik
    {
        static void Main(string[] args)
        {
            // Kodu durdurmak, devamını okumamak, var olan bir döngüden çıkış yapmak veya metodu sonlandırmak yani kodu yönlendirmek için kullanılır.
            // break, return, goto, continue

            #region BREAK
            //sadece switch-case ve döngülerde kullanılır. Yapıdan çıkış yapmaya yani yapıyı sonlandırmaya yarar.

            // -> Örnek: Kullanıcıdan 't' harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran program.
            /*int toplam = 0;

            while (true) 
            {
                Console.Write("Sayıyı giriniz: ");
                string deger = Console.ReadLine();

                if(deger == "t")
                {
                    Console.WriteLine("Toplam: " + toplam);

                    break; // Şart sağlanınca döngüden çıkıldı.
                }
                else
                {
                    toplam += int.Parse(deger); 
                }
            }*/
            #endregion

            #region CONTINUE
            // Sadece döngülerde kullanılır. Döngüde bir sonraki tura direk geçiş yaptırır.

            //-> Örnek: Çift sayıları ekrana yazdırma

            /*Console.Write("Continue ile çift sayılar: ");

            for(int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                    continue; // Gelen sayı 2'ye tam bölünmediğinde Console.WriteLine komutuna geçmez, döngünün bir sonraki adımını çalıştırır.

                Console.Write(i + " ");
            }

            Console.WriteLine();*/

            // -> Örnek: Girilen sonsuz adet sayıdan pozitif olanları çarpan ve 't' ye basıldığında sonucu ekrana yazdıran program.
            /*int carpim = 1;

            while (true)
            {
                Console.Write("Sayı giriniz: ");   
                string deger1 = Console.ReadLine();

                if(deger1 == "t")
                {
                    Console.Write("Continue ile çarpım sonucu: " + carpim);
                    break;
                }
                else
                {
                    int sayi = int.Parse(deger1);

                    if (sayi < 0)
                        continue; // Sıfırdan küçük sayıları atla ve girilen diğer değerlere bak.
                    carpim *= sayi;
                }
            }*/
            #endregion

            #region RETURN
            // Metot içinde her yerde kullanılabilir. 
            // 1.Nerede çağrılırsa çağrılsın metodu sonlandırır.
            // 2. Metotlarda geriye değer döndürür.

            // ->Örnek: 'c' tuşuna basana kadar sonsuz dögüde dönen program.

            while (true) 
            {
                if(Console.ReadKey().KeyChar == 'c')
                {
                    Console.WriteLine("Uygulama sona ermiştir. ");
                    return;
                }
                Console.WriteLine("Uygulama çalışıyor.");
            }
        #endregion

        }
    }
}
