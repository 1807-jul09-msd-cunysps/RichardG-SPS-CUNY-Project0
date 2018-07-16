using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Classlib
    {
        public bool Pall(string Input)
        {
            string arr = Input.Substring(0, Input.Length / 2);
            char[] arr1 = Input.ToCharArray();
            Array.Reverse(arr1);
            string arr2 = new string(arr1);
            string Output = arr2.Substring(0, arr2.Length / 2);
            return arr.Equals(Output);
        }
    }
}