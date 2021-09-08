using System;
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

       static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            else if (fileName.EndsWith(""))
            {
                throw new ArgumentNullException("File extension must hava a value!");
            }
            else if (fileName.EndsWith(""))
            {
                throw new ArgumentNullException("File extension must have a value!");
            } else
            {
                return 0;
            }
        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            /*try
            {
                Console.WriteLine(Divide(8, 0));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }*/

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students) {
                try
                {
                    Console.WriteLine(CheckFileExtension(student.Value));
                }
                catch(ArgumentNullException e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
