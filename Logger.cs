using System;

namespace Lab34
{
    // Клас-обробник події №2
    public class Logger
    {
        public void Log(object sender, StackOverflowEventArgs e)
        {
            Console.WriteLine($"[Лог {e.Time:HH:mm:ss}] Джерело: {sender.GetType().Name}, " +
                              $"відхилено значення {e.RejectedItem}");
        }
    }
}