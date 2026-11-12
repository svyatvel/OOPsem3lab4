using System;

namespace Lab34
{
    // Клас-аргумент події переповнення стеку
    public class StackOverflowEventArgs : EventArgs
    {
        public int Capacity { get; }
        public int RejectedItem { get; }
        public DateTime Time { get; }

        public StackOverflowEventArgs(int capacity, int rejectedItem)
        {
            Capacity = capacity;
            RejectedItem = rejectedItem;
            Time = DateTime.Now;
        }
    }
}