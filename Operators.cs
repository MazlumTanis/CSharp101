using System;

namespace operators
{
    class Program
    {
        static void Main2(string[] args)
        {
            // Atama ve islemli atama
            int x = 10;
            int y = 2;
            y = y + 2;
            y += 2;
            Console.WriteLine(y);
            y /= 6;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantiksal operatorler ( || (veya) , && (ve) , ! (degil) )
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("PERFECT !");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("GREAT !");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("FINE !");
            }

            // Iliskisel operatorler (<, >, <=, >=, ==, !=)
            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);


            // Aritmetik Operatorler (+, -, *, /, %, ++, --)
            int num1 = 10;
            int num2 = 5;
            int res = num1 / num2;
            Console.WriteLine(res);
            res = num1 + num2;
            Console.WriteLine(res);
            res = ++num1;
            Console.WriteLine(res);

            // % : mod almak icin kullanilir
            int res2 = 20%3;
            Console.WriteLine(res2);
        }
    }
}