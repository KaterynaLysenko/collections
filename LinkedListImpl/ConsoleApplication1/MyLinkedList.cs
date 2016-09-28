using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyLinkedList
    {
        class ListNode
        {
            public object item;
            public ListNode next;
            public ListNode prev;

            public ListNode(object item, ListNode next, ListNode prev)
            {
                this.item = item;
                this.next = next;
                this.prev = prev;
            }

            public ListNode()
            {
            }
        } 


        private ListNode head;
        private ListNode tail;
        private int size;

        public MyLinkedList()
        {
            size = 0;
            head = null;
        }

        public int Length()
        {
            return size;
        }
        public void Add(object item)
        {
            if (size == 0)
            {
                ListNode l1 = new ListNode();
                l1.item = item;
                l1.next = l1.prev = null;
                head = tail = l1;
                size++;
            }
            else
            {
                ListNode ln = new ListNode();
                ln.item = item;
                ln.next = null;
                ln.prev = tail;
                tail.next = ln;
                tail = ln;
                size++;
            }
        }

        public void AddAt(object item, int index)
        {
            if (index < 0 || index > size-1)
            {
                throw new IndexOutOfRangeException();
            }
            if (size == 0 || index == size -1)
            {
                Add(item);
            }
            else
            {
                ListNode ln = new ListNode();
                ListNode currentNode = GetListNodeAt(index);
                ln.item = item;
                ln.prev = currentNode.prev;
                ln.next = currentNode;
                if (currentNode == head)
                {
                    head = ln;
                }
               /* else if (currentNode == tail)
                {
                    tail = ln;
                }*/
                else
                {
                    currentNode.prev.next = ln;
                    currentNode.prev = ln;
                    
                }
                size++;
            }
        }

        public object EllementAt(int index)
        {
            return GetListNodeAt(index).item;
        }

        public void Remove()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException();
            }
            tail = tail.prev;
            size--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == size + 1)
            {
                Remove();
            }  
            else
            {
                ListNode ln = GetListNodeAt(index);
                ln.next.prev = ln.prev;
                ln.prev.next = ln.next;
                size--;
            }
        }
        private ListNode GetListNodeAt(int index)
        {
            ListNode currentNode = head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.next;
            }
            return currentNode;
        }
    }

   
}
