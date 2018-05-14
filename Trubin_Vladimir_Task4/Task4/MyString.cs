using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char[] nchar;

        public MyString(string newString)
        {
            nchar = newString.ToCharArray(0, newString.Length);
        }

        public override string ToString()
        {
            return new string(nchar);
        }

        public override bool Equals(object obj)
        {
            var str = obj as MyString;
            if (str != null)
            {
                return str == this;
            }

            return false;
        }

        public static MyString operator + (MyString myString, string newString)
        {
            var result = myString.ToString() + newString.ToString();
            return new MyString(result);
        }

        public static MyString operator - (MyString myString, string newString)
        {
            string demo = myString.ToString();
            demo = demo.Replace(newString, string.Empty);
            return new MyString(demo);
        }

        public static bool operator == (MyString myStringA, MyString myStringB)
        {
            string demoA = myStringA.ToString();
            string demoB = myStringB.ToString();

            return String.Compare(demoA, demoB) == 0;
        }

        public static bool operator != (MyString myStringA, MyString myStringB)
        {
            string demoA = myStringA.ToString();
            string demoB = myStringB.ToString();

            return String.Compare(demoA, demoB) != 0;
        }
        
    }
}
