using System;
using System.Collections.Generic;
using System.Text;

namespace Separator
{
    
    public class ConsoleSeparator
    {   
        //public delegate void SeparatorDelegate();
        //public event SeparatorDelegate OnSeparate;
        public char Ch { get; private set; }
        public int Amount { get; private set; }
        public ConsoleSeparator( char ch, int amount)
        {
            Ch = ch;
            Amount = amount;
        }
        //private ConsoleSeparator(char ch, int amount)
        //{
        //    Ch = ch;
        //    Amount = amount;
        //}
        public void Separator()
        {
            Console.WriteLine(new string(Ch, Amount));
        }
    }
}
