using System;

namespace Lab34
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ----- Завдання 1: анонімний метод і лямбда-вираз -----
            string text = "програмування";
            char symbol = 'р';

            FindCharDelegate anonymous = delegate (string s, char c)
            {
                for (int i = 0; i < s.Length; i++)
                    if (s[i] == c) return i;
                return -1;
            };

            FindCharDelegate lambda = (s, c) => s.IndexOf(c);

            Console.WriteLine($"Анонімний метод: {anonymous(text, symbol)}");
            Console.WriteLine($"Лямбда-вираз:    {lambda(text, symbol)}");
            Console.WriteLine($"Символ 'z':      {lambda(text, 'z')}\n");

            // ----- Завдання 2-3: компонент + додаток -----
            var stack = new LimitedStack(3);
            var monitor = new StackMonitor();
            var logger = new Logger();

            stack.StackOverflow += monitor.OnStackOverflow;
            stack.StackOverflow += logger.Log;

            for (int i = 1; i <= 5; i++)
            {
                if (stack.Push(i * 10))
                    Console.WriteLine($"Додано {i * 10}");
            }

            Console.WriteLine();
            while (stack.Count > 0)
                Console.WriteLine($"Видалено {stack.Pop()}");
        }
    }
}