using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;     // 0,255 arasinda deger alabilir. 1 byte yer kaplar.
            sbyte c = 5;    // -128,127 arasinda deger alabilir. 1 byte yer kaplar.

            short s = 5;    // -32768,32767 arasinda deger alabilir. 2 byte yer kaplar.
            ushort us = 5;  // 0, 65365 arasinda deger alabilir. 2 byte yer kaplar.

            Int16 i16 = 2;  // -32768, 32767 arasinda deger alabilir. 2 byte yer kaplar.
            int i = 2;      // -2147483648, 2147483647 arasinda deger alabilir. 4 byte yer kaplar.
            Int32 i32 = 2;  // -2147483648, 2147483647 arasinda deger alabilir. 4 byte yer kaplar.
            Int64 i64 = 2;  // -9223372036854775808, 9223372036854775807 arasinda deger alabilir. 8 byte yer kaplar

            uint ui = 2;    // 4 byte yer kaplar.
            long l = 4;     // 8 byte yer kaplar.
            ulong lu = 4;   // 8 byte yer kaplar. Negatif deger alamaz.

            // reel sayilar
            float f = 5;        // 4 byte yer kaplar.
            double d = 5;       // 8 byte yer kaplar.
            decimal de = 5;    // 16 byte yer kaplar.

            char ch = 'a';          // 2 byte yer kaplar. tek bir karakter tutmaya yarar.
            string str = "string";  // Sinirsiz yer kaplar.

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;     // Guncel tarihi almaya yarar.
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 5;
            object o4 = 4.3;
            // Tum degisken tipleri objeden turetilmistir. Dolayisiyla tum degiskenleri object olarak tanimlayabiliriz.

            // String ifadeler
            string str1 = string.Empty;
            str1 = "Adylsha Yumayev";
            string name = "Adylsha";
            string surname = "Yumayev";
            string fullName = name + " " + surname;

            // Integer tanimlama sekilleri
            int in1 = 5;
            int in2 = 3;
            int in3 = in1 * in2;

            // boolean
            bool bool1 = 10 > 2;    // true
            bool bool2 = 10 < 2;    // false

            // Degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string newString = str20 + int20.ToString();
            Console.WriteLine(newString);   // 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);       // 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);       // 40

            // dateTime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

        }
    }
}