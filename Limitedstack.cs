using System;

namespace Lab34
{
    // Клас, у якому оголошена подія та метод, що її викликає
    public class LimitedStack
    {
        private readonly int[] _items;
        private int _top;

        // Подія переповнення (стандартний generic EventHandler)
        public event EventHandler<StackOverflowEventArgs> StackOverflow;

        public int Capacity => _items.Length;
        public int Count => _top;

        // Ініціалізація стеку
        public LimitedStack(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Ємність має бути додатною", nameof(capacity));
            _items = new int[capacity];
            _top = 0;
        }

        // Метод, що викликає подію
        protected virtual void OnStackOverflow(StackOverflowEventArgs e)
        {
            StackOverflow?.Invoke(this, e);
        }

        // Розміщення даних у стеку
        public bool Push(int item)
        {
            if (_top == _items.Length)
            {
                OnStackOverflow(new StackOverflowEventArgs(Capacity, item));
                return false;
            }
            _items[_top++] = item;
            return true;
        }

        // Видалення даних зі стеку
        public int Pop()
        {
            if (_top == 0)
                throw new InvalidOperationException("Стек порожній");
            return _items[--_top];
        }
    }
}