using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList("5");
            list.append("9");
            list.append("7");
            list.append("5");

            Console.WriteLine(list);
            Console.WriteLine("------------------");
            list.insert(3, "43");
            Console.WriteLine(list);
            Console.WriteLine("------------------");
            list.remove(3);
            Console.WriteLine(list);
            Console.WriteLine("------------------");

            //list.removeAll(); remove all elements

            int? n1 = list.returnIndexOfFirstValue("5");
            Console.WriteLine("Index of first value 5 is: "+ n1);
            Console.WriteLine("------------------");

            int? n2 = list.returnIndexOfLastValue("5");
            Console.WriteLine("Index of last value 5 is: " + n2);
            Console.WriteLine("------------------");

            string? value = list.returnValue(2);
            Console.WriteLine("Value of index 2 is: " + value);
            Console.WriteLine("------------------");








        }
    }
}
