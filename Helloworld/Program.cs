using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {  // this is a single line comment
            /* this is multi line comment
             The two major components of .NET Framework are the Common Language Runtime and the .NET Framework Class Library.

     The Common Language Runtime (CLR) is the execution engine that handles running applications. It provides services like thread management, garbage collection, type-safety, exception handling, and more.
     The Class Library provides a set of APIs and types for common functionality. It provides types for strings, dates, numbers, etc. The Class Library includes APIs for reading and writing files, connecting to databases, drawing, and more.
     .NET applications are written in the C#, F#, or Visual Basic programming language. Code is compiled into a language-agnostic Common Intermediate Language (CIL). Compiled code is stored in assemblies—files with a .dll or .exe file extension.

     When an app runs, the CLR takes the assembly and uses a just-in-time compiler (JIT) to turn it into machine code that can execute on the specific architecture of the computer it is running on.
              */
            // comment shortcut ctrl+k+c
            // int harry = 34; // integer variable
            /* data types in c#
             * integer - int harry; ->> 4 bytes
             * Long - long harry; ->> 8 bytes
             * Double - double harry; ->> 8 bytes
             * floating point number - float that; ->> 4 bytes
             * Character - char a ='A'; ->> 2 bytes
             * Boolean - bool isGreat = true; ->> 1 bit
             * string inp = "Harry"; ->>2 bytes per character
             */
            //int harry = 34;
            //Console.WriteLine("Hello world");
            //Console.Write("Hello sagar");
            //Console.Write(" i love c# and the number "+harry);
            //string inp=Console.ReadLine();
            //Console.WriteLine(inp);
            ////Console.ReadLine();
            //int a = 34;
            //float b = 34.4F;

            //double c = 34.4D;
            //bool isGreat = true;
            //char d = 'z';
            //string str = " this is a string";
            //Console.WriteLine(a+b+c);
            //Console.WriteLine(d);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(str);
            ////Console.ReadLine();

            //// Type casting
            ///*
            // * There are two type of type casting
            // * 1.Implicit casting
            // * char to int to long to float to double
            // * 2.Explicit casting
            // * 
            // */



            //int e =(int) 3.5;
            //int f = 'y';
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //float g = Convert.ToInt32(34.4); 
            ////Convert.ToDouble
            ////Convert.ToString
            //Console.WriteLine(g);
            //Console.WriteLine("Hey Please enter your name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey! "+ name);
            //Console.WriteLine("How many candies do you want : ");
            //string candy = Console.ReadLine();

            //Console.WriteLine("you will get 4 more candies " + (Convert.ToInt32(candy) + 4) );
            //Console.ReadLine();

            ///* opertators in c++
            // * 1. Arithmetic operators
            // * 2. Assignment Operator
            // * 3. logical operators
            // * 4. Comparision operator
            // */
            ////arithmetic operator
            //int sagar = 6;
            //int shadmani = 7;
            //Console.WriteLine("The value of sagar and shadmani is :" + (sagar+shadmani));
            //Console.WriteLine("The value of sagar and shadmani is :" + (sagar-shadmani));
            //Console.WriteLine("The value of sagar and shadmani is :" + (sagar*shadmani));
            //Console.WriteLine("The value of sagar and shadmani is :" + (sagar/shadmani));

            ////assignment operator

            //int a1 = 4;
            //int b1 = 8;
            //b1 += a1;
            //b1 /= a1;
            //b1 *= a1;
            //b1 -= a1;

            //Console.WriteLine(b1);

            //Console.ReadLine() ;

            ////Logical operator

            //Console.WriteLine( true && false);
            //Console.WriteLine( true && true);
            //Console.WriteLine( false && false);
            //Console.WriteLine( true || false);
            //Console.WriteLine( true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(!true);
            //Console.WriteLine(!false);

            //Console.ReadLine() ;

            //// Comparision operator

            //Console.WriteLine(324>555);
            //Console.WriteLine(324<=555);
            //Console.WriteLine(324>=555);
            //Console.WriteLine(324!=555);
            //Console.WriteLine(5!=5);

            //Console.ReadLine();
            //// Math class
            //a = Math.Max(10, 15);
            //b = Math.Min(10, 15);
            //double s=  Math.Sqrt(36);

            //// string in c#

            //string hello = " hello my name is sagar";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());

            //Console.WriteLine(string.Concat(hello," you are nice"));
            //Console.ReadLine();

            //// string interpolation
            //string name1 = Console.ReadLine();
            //string age = Console.ReadLine();
            //Console.WriteLine($"Your name is {name1} and your age is {age}");
            //Console.WriteLine();
            // escape sequence characters
            //string hello = "Hello world \" s is sagar";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("world"));
            //Console.WriteLine(hello.Substring(1));

            string val = Console.ReadLine();
            int age = Convert.ToInt32(val);
            if (age > 18)
            {
                Console.WriteLine("you can drive");
            }
            else if (age < 10)
            {
                Console.WriteLine("please finish your highschool");
            }
            else if(age < 18) 
            {
                Console.WriteLine("you are below 18");
            }
            else
            {
                Console.WriteLine(" you cannot drive");
            }

            // switch statement in c#

            switch(age)
            {
                case 18:
                    Console.WriteLine("please wait for an year");
                    break;
                case var expression when age > 18:
                    Console.WriteLine("you can drive");
                    break;
                default:
                    Console.WriteLine("you cannot drive");
                    break;


            }
            // loops in c#
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            Console.ReadLine();
        }

    }
}
