﻿using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            // Write your code here!
            if(y.Equals(0))
            {
                throw new ArgumentOutOfRangeException("NO!");
            }
            return x / y;
        }

       /*static int CheckFileExtension(string fileName)
        {
            // Write your code here!
        }
        */

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(8, 0));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


        }
    }
}
