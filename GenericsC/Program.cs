using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsC
{
    class Program
    {
        static void Main(string[] args)
        {
            Types t = new Types();
            //t.Lists();
            //t.Dictionaries();
            t.SortedLists();
            t.SortedDictionary();
            t.SortedSets();
            //t.Stacks();
            //t.Queues();
        }
    }
}
