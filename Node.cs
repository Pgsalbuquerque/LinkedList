using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public Node next;
        public string value;

        public Node(string Value)
        {
            value = Value;
        }


        public override string ToString()
        {
            return value;
        }


    }
}
