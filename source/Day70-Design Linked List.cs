  public class MyLinkedList
    {
        /** Initialize your data structure here. */
        private Node head;
        private int count = 0;

        private int length
        {
            get { return count - 1; }
        }

        public MyLinkedList()
        {
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */

        public int Get(int index)
        {
            if (index > length || index < 0)
                return -1;
            int i = 0;
            var curr = head;
            while (i != index)
            {
                i++;
                curr = curr.Next;
            }
            Console.WriteLine(curr.Val);
            return curr.Val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */

        public void AddAtHead(int val)
        {
            if (count == 0)
                head = new Node(val);
            else
            {
                var newHead = new Node(val, head);
                head = newHead;
            }
            count++;
        }

        /** Append a node of value val to the last element of the linked list. */

        public void AddAtTail(int val)
        {
            if (count == 0)
                head = new Node(val);
            else
            {
                var curr = head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = new Node(val);
            }
            count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */

        public void AddAtIndex(int index, int val)
        {
            if (index > count || index < 0)
                return;
            if (index == count)
            {
                AddAtTail(val);
                return;
            }
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            var i = -1;
            var fakeHead = new Node(-1, head);
            var curr = fakeHead;
            while (i + 1 != index)
            {
                i++;
                curr = curr.Next;
            }
            var newNode = new Node(val, curr.Next);
            curr.Next = newNode;
            count++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */

        public void DeleteAtIndex(int index)
        {
            if (index > length || index < 0)
                return;
            var i = 0;
            var preHead = new Node(-1, head);
            while (i != index)
            {
                i++;
                preHead = preHead.Next;
            }
            if (i == 0)
            {
                head = head.Next;
            }
            else
            {
                preHead.Next = preHead.Next.Next;
            }
            count--;
        }

        private class Node
        {
            public Node(int val)
            {
                Val = val;
            }

            public Node(int val, Node next) : this(val)
            {
                Next = next;
            }

            public int Val { get; }
            public Node Next { get; set; }
        }
    }

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
