using System;

namespace operators
{
    class Program
    {
        static void Main2(string[] args)
        {
        //Sınav notunu isteyelim.
            //0-50 arası "Daha çok çalışmalısın"
            //50-70 arası "Daha iyi olabilir"
            //70-100 arası "Başarılı"
            Console.WriteLine("Lutfen sınav notunu giriniz");

            try
            {
                int not = Convert.ToInt32(Console.ReadLine());

                if (not >= 0 && not <= 50)
                {
                    Console.WriteLine("Daha çok çalışmalaısın");
                }
                else if (not >= 51 && not <= 69)
                {
                    Console.WriteLine("Daha iyi olabilir");
                }
                else if (not >= 70 && not <= 100)
                {
                    Console.WriteLine("Başarılı");
                }
            }
            catch
            {

                Console.WriteLine("Sayı girmediniz.İşleme devam edilmiyor");
            }
         }
    }
}
