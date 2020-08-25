using System;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;
        public int size = 0;

        public LinkedList(string ValueOfHead)
        {
            head = new Node(ValueOfHead);
            size += 1;
            Console.WriteLine("The Value: " + ValueOfHead + " has been added");
        }

        public LinkedList()
        {
        }


        public void append(string Value)
        {
            if (size == 0)
            {
                head = new Node(Value);
                size += 1;

                Console.WriteLine("The Value: " + Value + " has been added");
            }
            else if (size == 1)
            {
                Node Pointer = head;

                Pointer.setNext(Value);
                size += 1;

                Console.WriteLine("The Value: " + Value + " has been added");
            }
            else 
            {
                Node Pointer = head;
                for(int count = 1; count < size; count++)
                {
                    Pointer = Pointer.next;
                }

                Pointer.setNext(Value);
                size += 1;

                Console.WriteLine("The Value: " + Value + " has been added");
            }
        }

        public override string ToString()
        {
            if (size == 0)
            {
                return "list is empty";
            }
            else {
                string str = "";
                Node Pointer = head;
                str += "0: " + head + "\n";
                for (int count = 1; count < size; count++)
                {

                    Pointer = Pointer.next;
                    str += count + ": " + Pointer.value + "\n";
                }

                return str;
            }
            
        }

        public void remove(int index) {
            if (index == 0) {
                Node Pointer = head;
                head = Pointer.next;
                size -= 1;
                Console.WriteLine("The Position: " + index + " has been removed");
            }
            else if (index >= size)
            {
                Console.WriteLine("List index out of range");
            }
            else
            {
                Node Pointer = head;
                Node Pointer2;

                for (int n = 1; n < index; n++)
                {
                    Pointer = Pointer.next;
                }

                if ((size - 1) == index)
                {
                    Pointer.resetNext();
                    size -= 1;
                    Console.WriteLine("The Position: " + index + " has been removed");
                }
                else
                {
                    Pointer2 = Pointer.next.next;
                    Pointer.next = Pointer2;
                    size -= 1;
                    Console.WriteLine("The Position: " + index + " has been removed");
                }
            }
            
        }

        public void removeAll()
        {
            head = new Node();
            size = 0;
        }

        public void insert(int index, string Value)
        {   
            if (index == 0)
            {
                Node Pointer = head;
                Node Pointer2 = new Node(Value);
                Pointer2.next = head;
                head = Pointer2;
                size += 1;
                Console.WriteLine("The Value: " + Value + " has been added in " + index + " position");

            }
            else if (index >= size)
            {
                Console.WriteLine("List out of range");
            }
            else if (index == size - 1)
            {
                Node Pointer = head;
                for (int n = 1; n < index; n++)
                {
                    Pointer = Pointer.next;

                }

                Node Pointer2 = new Node(Value);
                Node Pointer3 = Pointer.next;

                Pointer.next = Pointer2;
                Pointer2.next = Pointer3;
                size += 1;
                Console.WriteLine("The Value: " + Value + " has been added in " + index + " position");

            }
            else
            {
                Node Pointer = head;
                for (int n = 0; n < index-1; n++)
                {
                    Pointer = Pointer.next;
                }
                Node Pointer2 = new Node(Value);
                Node Pointer3 = Pointer.next;

                Pointer.next = Pointer2;
                Pointer2.next = Pointer3;

                size += 1;

                Console.WriteLine("The Value: " + Value + " has been added in " + index + " position");
            }
            


        }

        public int? returnIndexOfFirstValue(string Value)
        {
            Node Pointer = head;
            if (Pointer.value == Value)
            {
                return 0;
            }
            for (int n = 1; n < size; n++) {
                Pointer = Pointer.next;
                if (Pointer.value == Value)
                {
                    return n;
                }
            }
            Console.WriteLine("The Value doesn't exist in list");
            return null;
        }

        public int? returnIndexOfLastValue(string Value)
        {
            Node Pointer = head;
            int index = -1;
            if (Pointer.value == Value)
            {
                index = 0;
            }
            for (int n = 1; n < size; n++)
            {
                Pointer = Pointer.next;
                if (Pointer.value == Value)
                {
                    index = n;
                }
            }
            if (index != -1)
            {
                return index;
            }
            Console.WriteLine("The Value doesn't exist in list");
            return null;
        }

        public string? returnValue(int index)
        {
            Node Pointer = head;
            if (index >= size || index < 0)
            {
                Console.WriteLine("List out of range");
                return null;
            }
            else if (index == 0)
            {
                return Pointer.value;
            }
            else
            {
                for (int n = 1; n<=index; n++)
                {
                    Pointer = Pointer.next;
                }

                return Pointer.value;
            }
            
        }

    }
}
