using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1-Çift mi?");
            Console.WriteLine("2-Eşit ya da Büyük mü?");
            Console.WriteLine("3-Ters Kelime");
            Console.WriteLine("4-Kaç Harf Kaç kelime");
            Console.WriteLine("Lütfen işlem seçin: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    isEven();
                    break;
                case 2:
                    isEqualOrBig();
                    break;
                case 3:
                    reverseWords();
                    break;
                case 4:
                    calcWordsAndLetters();
                    break;
            }

            Console.Read();
        }

        public static void isEven()
        {
            List<int> list = new List<int>();
            int listLength, numb;
            Console.Write("Lütfen eleman sayısını giriniz: ");
            listLength = int.Parse(Console.ReadLine());

            for (int i = 0; i < listLength; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ", i + 1);
                numb = int.Parse(Console.ReadLine());
                if (numb % 2 == 0)
                {
                    list.Add(numb);
                }
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void isEqualOrBig()
        {
            List<int> list = new List<int>();
            int listLength, refNumb, numb;
            Console.Write("Lütfen eleman sayısını giriniz: ");
            listLength = int.Parse(Console.ReadLine());
            Console.Write("Lütfen referans sayısını giriniz: ");
            refNumb = int.Parse(Console.ReadLine());


            for (int i = 0; i < listLength; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ", i + 1);
                numb = int.Parse(Console.ReadLine());
                if (numb == refNumb || refNumb%numb==0)
                {
                    list.Add(numb);
                }
            }
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }
        public static void reverseWords()
        {
            List<string> list = new List<string>();
            int listLength;
            string word;
            Console.Write("Lütfen eleman sayısını giriniz: ");
            listLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < listLength; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ", i + 1);
                word = Console.ReadLine();
                list.Add(word);
            }
            list.Reverse();
            foreach (string item in list)
            {
                Console.Write("{0}, ",item);
            }
        }
        public static void calcWordsAndLetters()
        {
            string sentence;
            int countLetter=0;
            Console.Write("Lütfen bir cümle giriniz: ");
            sentence=Console.ReadLine();

            string[] words = sentence.Split(' ');

            foreach(string word in words)
            {
                countLetter += word.Length;
            }
            Console.WriteLine("Words count:{0}\nLetter count: {1}",words.Length,countLetter);
        }
    }
}
