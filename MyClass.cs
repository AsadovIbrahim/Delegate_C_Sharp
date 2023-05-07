using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_C_Sharp
{
    internal class MyClass
    {
        public void Space(string str)
        {
            string space="";
            foreach(var item in str)
            {
                space += item;
                if (str.IndexOf(item) != str.Length - 1)space += "_";
            }
            Console.WriteLine(space);
        }
        public void Reverse(string str)
        {
            string reverse = "";
            for(int i = str.Length-1; i > -1; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
        }
        public MyClass() { }
    }

}
