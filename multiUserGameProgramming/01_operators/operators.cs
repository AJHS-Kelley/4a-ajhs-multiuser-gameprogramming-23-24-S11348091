// Amaure Cooper, operators , v0.0
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creat Two sting, Interger, and Float varaiables.
            string1 hello = "hello"; 
            string2 hi = "hi";

            int thing1 = 564;
            int thing2 = -8;

            float myFloat1 = 0.2F;
            float myFloat2 = -3.25f;

            //Arithmetic Operators 
            Console.WriteLine(myInt1 + myInt2);
            Console.WriteLine(myString1 + mystring2);
            Console.WriteLine(myFloat1 + myFloat2);
            Console.WriteLine(myInt1 + myFloat2);

            Console.WriteLine(myInt1 - myInt2);
            Console.WriteLine(myString1 - mystring2);
            Console.WriteLine(myFloat1 - myFloat2);
            Console.WriteLine(myInt1 - myFloat2);
            
            Console.WriteLine(myInt1 / myInt2);
            Console.WriteLine(myString1 / mystring2);
            Console.WriteLine(myFloat1 / myFloat2);
            Console.WriteLine(myInt1 / myFloat2);

            Console.WriteLine(myInt1 * myInt2);
            Console.WriteLine(myString1 * mystring2);
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myInt1 * myFloat2); 

            Console.WriteLine(myInt1 * myInt2);
            // Console.WriteLine(myString1 * myString2;
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myInt1 * myFloat2);

            //Modulus
            Console.WriteLIne("Modulus");
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            
            int myInt4 = 2;
            myInt3--;
            Console.WriteLine(myInt4);

            // Assignment Operators
            // =
            // +=
            // -=
            // *=
            // /= 

            // Comparison Operators
            // Is Equal To 
            // Greater Than 
            // Greater Than or Equal To
            // Less Than
            // Less Than or Equal To 
            // Not Equal To

            // Logical Operators
            // And
            // Or
            // Not
        
            //Dercement
            int myInt4 = 2,
            myInt4--,
            Console.WriteLIne(myInt4);

            //Assignment Opertaors
            //=
            int nTH1 = 100;
            int nTH2 = 50;
            // += 
            nTh1 += 25;
            // -=
            nTh1 -= nTh2; 
            // *= 
            nTh1 *= 2; 
            // /=
            nTh2 /= 5;

            //Comparison Operatods
            // Is Equal To
            Console.WriteLIne(3 == 4);
            // Greater Than
            Console.WriteLIne(5 > 4); 
            // Greater than or Equal To
            Console.WriteLIne(7 .= 7);
            // Less Than 
            Console.WriteLIne(8 < 3);
            // Less Than or Equal To
            Console.WriteLIne(4 <= 6);
            // Not Equal To
            Console.WriteLIne(8 != 0);

            // Logical Operators
            // And
            // Or 
            // Not

            // Logical Operators 
            // And -- ALL CONDITIONS MUST BE TRUE FOR WHOLE STATEMENT TRUE
            Console.WriteLIne(3 > 2 && 2 == 2); //True and True = True
            Console.WriteLIne(3 > 2 && 5 > 6); // True and False = False
            // or -- one condition must be true for the whole statement to be true. 
            Console.WriteLIne(5 < 9 || 5 != 4); // True or True == False
            Console.WriteLIne(9 < 10 || 3 > 5 );// True or False == True
            // Not -- Find the 'opposite' Value.
            Console.WriteLIne(!(5 > 4)); //
            
    

            









        }
    }
} 
