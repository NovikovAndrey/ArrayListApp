using System;
using System.Collections;
using Separator;

namespace ArrayListApp
{

    class Program
    {
       
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('_', 50);
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
            list.SetSeparate(separateEvent);
            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list);
            list.SetSeparate(separateEvent);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
    public static class Test
    {
        public static void SetSeparate(this ArrayList arrayList, SeparateEvent separateEvent)
        {
            separateEvent.Display();
        }
    }
}
