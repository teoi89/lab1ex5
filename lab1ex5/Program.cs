using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
            descrescatoare.
                • Exemplu: citim 3,9,0 Afisam : 9 3 0 */

            Console.WriteLine("Introduce two numbers, and I`ll show them in ascending order");
            Console.WriteLine("Introduce your first number");
            
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce your second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Your numbers in asscending order are:");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(secondNumber + " " + firstNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + " " + secondNumber);
            }
        }
    }
}
