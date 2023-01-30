using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            /*  do - while - 
*/
            Console.WriteLine("Uso do - while");
            do
            {
                Console.WriteLine(i);
                i = i + 1000;
            } while (i <= 8000);
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Comando For");

            // for(inicia var; testelógico; iteração)

            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine(a);
            }
            int b = 1000;
            Console.WriteLine("Uso do While");
            while (b <= 5000)
            {
                Console.WriteLine(i);
                b = b + 1000;
            }
        }
    }
}
