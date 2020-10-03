using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    interface IMyList<T>
    {
        T this[int index] { get; set; }
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
    }
    interface IMyCollection<T>
    {
        int Count { get; }
        int Сapacity { get; }
        void Clear();
        bool Contains(T item);
        bool Remove(T item);
        void Add(T element);
        void RemoveAt(int index);
        void Insert(int index, T element);
    }

    class MyList<T> : IMyList<T>, IMyCollection<T>, IEnumerable<T>
    {
        private T[] arr = new T[0];
        public T this[int index] { get => arr[index]; set => arr[index] = value; }

        public int Count => arr.Count();

        public int Сapacity => arr.Length;

        public void Add(T element)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = element;
        }

        public void Clear()
        {
            Array.Clear(arr, 0, arr.Length);
        }

        public bool Contains(T item)
        {
            foreach (var el in arr)
                if (item.Equals(el))
                    return true;
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
                if (item.Equals(arr[i]))
                    return i;
            return -1;
        }

        public void Insert(int index, T item)
        {
            T[] newArr = new T[arr.Length + 1];
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i];

            newArr[index] = item;

            for (int i = index + 1; i < newArr.Length; i++)
                newArr[i] = arr[i - 1];

            arr = newArr;
        }

        public bool Remove(T item)
        {
            T[] newArr = new T[arr.Length - 1];
            int offset = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (arr[i].Equals(item))
                    offset += 1;

                newArr[i] = arr[i + offset];
            }
            arr = newArr;
            return offset == 1;
        }

        public void RemoveAt(int index)
        {
            T[] newArr = new T[arr.Length - 1];
            int offset = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i == index)
                    offset += 1;

                newArr[i] = arr[i + offset];
            }
            arr = newArr;
        }

        public int LastIndexOf(T element)
        {
            for (int i = arr.Length - 1; i >= 0 ; i--)
                if (arr[i].Equals(element))
                    return i;

            return -1;
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> res = new List<T>();
            foreach (var item in arr)
                if (match(item))
                    res.Add(item);

            return res;
        }

        public T Find(Predicate<T> match)
        {
            foreach (var item in arr)
                if (match(item))
                    return item;

            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)arr.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
    class Program
    {
        static void Print(IEnumerable arr, string name = "Arr", string separator = " ")
        {
            Console.Write($"{name}: ");
            foreach (var item in arr)
                Console.Write($"{item}{separator}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var rand = new Random();
            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 20; i++)
                list.Add(rand.Next(0, 10));

            Print(list);
            Console.WriteLine($"IsContain: {list.Contains(0)}");
            Console.WriteLine($"IsContain: {list.Contains(10)}");

            Console.WriteLine($"IndexOf: {list.IndexOf(5)}");
            Console.WriteLine($"IndexOf: {list.IndexOf(10)}");

            list.Insert(5, 11);
            Print(list);

            list.Remove(11);
            Print(list);

            list.RemoveAt(19);
            Print(list);

            Console.WriteLine($"LastIndexOf: {list.LastIndexOf(3)}");
            Console.WriteLine($"LastIndexOf: {list.LastIndexOf(15)}");

            Console.Write("FindAll -> ");
            Print(list.FindAll(x => x % 2 == 0));

            Console.WriteLine($"Find -> {list.Find(x => x == 5)}");

        }
    }
}
