using System;
using System.Collections;
using Separator;

namespace ArrayListApp
{

    class Program
    {
       
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('-', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;
            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(55);
            list.AddRange(new string[] { "Hello", "Hell" });
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            separateEvent.Display();
            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list);
            separateEvent.Display();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
