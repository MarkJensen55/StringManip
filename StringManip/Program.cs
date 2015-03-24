using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManip
{

    // 1) Reverse the order by word of the string on the command line
    // 2) Print the command line entry in upper case
    // 3) Concatenante the words from the command line strings with commas
    class Program
    {
        static void Main(string[] args)
        {

            // find out how many arguments (words) were passed
            int wordCount = args.Count();

            // create a string to hold the new output
            string outputString = null;

            // read the args in reverse order
            for (int i = wordCount-1; i >= 0; i--)
            {
                outputString = string.Concat(outputString, args[i]);
                outputString = string.Concat(outputString, " ");
            }

            Console.WriteLine(outputString);
            Console.WriteLine();

            
            // read the args array, convert each to upper & concatenate

            // clear the output string
            outputString = null;

            for (int i = 0; i < wordCount; i++)
            {
                outputString = string.Concat(outputString, args[i].ToUpper());
                outputString = string.Concat(outputString, " ");
            }

            Console.WriteLine(outputString);
            Console.WriteLine();

            // read the args array & output with commas in place of spaces

            // clear the output string
            outputString = null;

            for (int i = 0; i < wordCount; i++)
            {
                outputString = string.Concat(outputString, args[i]);
                outputString = string.Concat(outputString, ",");
            }

            Console.WriteLine(outputString);


            Console.ReadLine();


        }
    }
}
