using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    internal interface IList<T>
    {
        public void AddList(T value);
        public bool Remove(Node<T> item);
        public bool Remove(int value);
    }
}
