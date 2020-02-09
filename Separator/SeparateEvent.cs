using System;
using System.Collections.Generic;
using System.Text;

namespace Separator
{
    public class SeparateEvent
    {
        public delegate void SeparatorDelegate();
        public event SeparatorDelegate OnSeparate;

        public void Display()
        {
            OnSeparate();
           
            OnSeparate();
        }
    }
}
