namespace Iterasyon
{
    class Iterasyon
    {
        static void Main(string[] args)
        {
            #region Iterasyon
            // İterasyon: Tekrarlama, tekerrür, yineleme, ardışık işlem. Programlamada bir dizi işlemin döngüler kullanarak yazılmasıdır.
            // Mantıksal açıdan her tahminin altında bir iterasyon mantığı yatar.
            #endregion

            #region Iterasyon ve Döngü
            // Foreach (İterasyon) bir döngü değildir. 
            // Döngüler sonsuza kadar çalışabilir ve bir kombinasyona göre işlem yapar, iterasyon eldeki eleman sayısı kadar o veri kümesi üzerinde işlem yapar.

            int[] sayilar = { 17, 2, 30, 4, 7005, 9, 15, 578, 67 };

            for (int i = 0; i < sayilar.Length; i++)
            {

            }

            #endregion

            #region Foreach Iterasyonu
            // Foreach'in çalışabilmesi için kesinlikle veri kümesi (dizi veya koleksiyon) olmalı.

            foreach (object item in sayilar) // in operatörünün solundaki ifade Değişken, sağındaki ifade dizi ve koleksiyon gibi bir veri kümesidir.
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
