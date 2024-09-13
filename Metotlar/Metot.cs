namespace Metotlar
{
    class Metot
    {
        static void Main(string[] args)
        {
            // Yöntem, yordam, fonksiyon
            // Yazılımda fiili olarak gerçekleştirdiğimiz tüm operasyonlar bir metotdur. Matematikteki fonksiyonlarla ile bire bir aynı mantıktadır.
            // Prosedürel programlamanın temel elemanıdır. Bir iş, fiiliyat, operasyon yapan en küçük program parçacıklarıdır. Kodun yazıldığı yer metotdur. 

            /* 
             Metot tanımlama (metodun imzası): [erişim belirleyicisi] [geri dönüş değeri] [metodun adı]()
             {
                Metot gövdesi
             }
            */

            // Erişim Belirleyicisi (Access Modifier): Public, private, protected, internal, protected internal, private protected
            // Metotlar yaptıkları işlemler sonucunda geriye değer döndürebilmektedir.
            /* Dört farklı türde metot oluşturulbilir. 
             1. Geri değer döndürmeyen, parametre almayan
             2. Geri değer döndürmeyen, parametre alan
             3. Geri değer döndüren, parametre almayan
             4. Geri değer döndüren, parametre alan
            */

            string ad = "Ali";
            int y = 30;

            bool sonuc = Ekle("ad", y);
            Console.WriteLine(sonuc);
        }

        static public bool Ekle(string ad, int yas) 
        { 
            if(yas > 20){

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}