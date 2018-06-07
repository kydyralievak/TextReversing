using System;

namespace TextReversing
{
    internal class Program
    {
        public static string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);

            return new String(array);
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите текст(для выхода введите \"выход\")");
                var input = Console.ReadLine();

                if (input == "выход")
                    break;

                Console.WriteLine($"Перевернутая строка:{Reverse(input)}");
            }
        }
    }
}