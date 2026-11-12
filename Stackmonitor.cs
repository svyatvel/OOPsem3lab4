using System;

namespace Lab34
{
    // Клас-обробник події №1
    public class StackMonitor
    {
        public void OnStackOverflow(object sender, StackOverflowEventArgs e)
        {
            var stack = (LimitedStack)sender;
            Console.WriteLine($"[Монітор] Переповнення стеку! Ємність: {e.Capacity}, " +
                              $"елемент {e.RejectedItem} не додано (кількість: {stack.Count}).");
        }
    }
}