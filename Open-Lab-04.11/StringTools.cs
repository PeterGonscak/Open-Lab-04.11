using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] ar = str.ToCharArray();
            Array.Sort(ar);
            return new string(ar);
        }
    }
}
