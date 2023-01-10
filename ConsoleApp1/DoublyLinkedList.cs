using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public void AddList (T value)
        {
            Node<T> list = new Node<T>(value);

            if (head == null)
                head = list;
            else
            {
                tail.NextItem = list;
                list.PrevItem = tail;
            }
            tail = list;
            count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.NextItem;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Item;
                current = current.PrevItem;
            }
        }
    }
}
