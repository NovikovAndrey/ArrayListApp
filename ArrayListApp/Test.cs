using Separator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayListApp
{
    class Test
    {
        public delegate void SeparatorDelegate();
        public event SeparatorDelegate OnSeparate;
        public void Display()
        {
            OnSeparate();
        }
    }
}
