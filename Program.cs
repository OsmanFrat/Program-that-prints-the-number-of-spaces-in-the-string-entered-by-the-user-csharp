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
            int toplam = 0;
            WriteLine("Please input a string: ");
            string yazi = ReadLine();

            foreach(char x in yazi)
            {
                if(x == ' ')
                {
                    toplam = toplam + 1;
                }
            }
            WriteLine(yazi + " contains " + toplam + " spaces.");
        }
       
    }
}