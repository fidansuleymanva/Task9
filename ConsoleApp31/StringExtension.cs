using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal static class StringExtension
    {
        public static int MatchCount(this string str, string word)
        {
            string[] a = str.Split(' ');


            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {


                if (word.Equals(a[i]))
                    count++;
            }
            return count;
        }
    }
}
