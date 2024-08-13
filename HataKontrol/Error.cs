namespace Demo
{
    class Error
    {
        static void Main(string[] args)
        {
            #region Try-Catch
            // Try - catch yapılanması olası hatanın olduğu kodları durmadan kontrol eden maliyetli bir yapıdır.
            // Bu yüzden sadece olası hata verebilecek kodları içine yazmak gereklidir.

            //int a1 = 0, a2 = 0;
            //Console.WriteLine("Birinci sayı: ");
            //try
            //{
            //    a1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("İkinci sayı: ");
            //    a2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Toplam: " + (a1 + a2));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Lütfen doğru ifade giriniz.");
            //}



            #endregion

            #region Try-Catch Hata Parametreleri

            string b5 = "a";

            try
            {
                int.Parse("abc");

                int b1 = 0, b2 = 10;
                int b3 = b2 / b1;

                object b4 = null;
                b4.ToString();
            }
            catch (FormatException ex) when (b5 == "c") // when keyword'ü ile şart uygulanır. VE anlamına gelir.
            {
                Console.WriteLine("Format Hata Mesajı: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Zero Hata Mesajı: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Diğer Hata Mesajı: " + ex.Message);
            }

            #endregion
        }
    }
}

