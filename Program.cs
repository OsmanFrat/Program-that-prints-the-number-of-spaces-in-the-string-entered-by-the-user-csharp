using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Console;


namespace metotlar
{
    public class deneme
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            WriteLine("Please input a string: ");
            string str1 = ReadLine();

            foreach(char x in str1)
            {
                if(x == ' ')
                {
                    sum = sum + 1;
                }
            }
            WriteLine(str1 + " contains " + sum + " spaces.");
        }
       
    }
}
