using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsC
{
    class Types
    {
        public void Lists()
        {
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(20);
            l.Add(30);
            l.Add(40);
            Console.WriteLine("Added elements");
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            l.Insert(0, 50);
            l.Insert(5, 60);
            Console.WriteLine("after insertion elements");
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            l.Remove(40);
            l.RemoveAt(1);
            Console.WriteLine("after removing elements");
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
        }
        public void Dictionaries()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Sri");
            d.Add(2, "Ram");
            d.Add(3, "Krish");
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
        public void SortedLists()
        {
            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(23, "anji");
            s.Add(18, "kevi");
            s.Add(22, "vasu");
            Console.WriteLine("sorted list elements");
            foreach (KeyValuePair<int, string> kvp in s)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
        public void SortedDictionary()
        {
            SortedDictionary<int,string> s1= new SortedDictionary<int,string> ();
            s1.Add(23, "anji");
            s1.Add(18, "kevi");
            s1.Add(22, "vasu");
            Console.WriteLine("sorted dictionary elements");
            foreach (KeyValuePair<int, string> kvp in s1)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
        public void SortedSets()
        {
            SortedSet<string> s3 = new SortedSet<string> ();
            s3.Add("vehicle");
            s3.Add("bike");
            s3.Add("car");
            Console.WriteLine("sorted set elements");
            foreach(string i in s3)
            {
                Console.WriteLine(i);
            }
        }
        public void Stacks()
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(50);
            Console.WriteLine("pushed elements");
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            s.Pop();
            s.Pop();
            Console.WriteLine("after popped elements");
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
        }
        public void Queues()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.WriteLine("inserted elements");
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("after deleted elements");
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
