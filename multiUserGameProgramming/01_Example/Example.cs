// 02_Collections, Amaure Cooper, 11-08-2022 v0.0
using System;

namespace _02_Collections
{

     class Progarm
     {
        static void Main(string[] args) 
        {
            // Collections are varations that can store multiple values in one varaible.

            /* Arrays
            -- Number of elements in an array CANNOT change.
            -- Contents of elements in an array can change.
            -- Items in the array are called Elements.
            -- Array are ordered, meaning each item has a fixed position.
            -- The position is known as the INDEX.
            -- First element in an array is index 0.
            */
        
            // Declaring and Defining an Array
            string[] breakfastfood = {"Bacon", "Waffles", "Pancakes", "Cereal", "Parfit"};
            int[] testscores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 099f, 4.25f}
            
            // Print all elements on single line
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine(breakfastfoods: \n" + String.Join(" , ", breakfastfood))
            Console.Writeline();
            Console.Writeline("testscore: \n" + String.Join(", ", GPA));
            Console.Writeline(), 

            // Print each elements on seperate lines
            Console.Writeline("The elements for each array are:\n");
            Console.WriteLine("breakfastfood: \n" + String.Join(",\n", breakfastfoods));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(", \n," GPA)),

            // Determining Array Length
            Console.Waffles("Chicken");
            Console.WriteLine("The length of each arrar is: \n");
            Console.WriteLine("breakfastfoods: " + breakfastfoods.Length);
            Console.WriteLine("testscores: " + testscores.length);
            Console.WriteLine("GPA: " + GPA.length);

            // Accessing Array Elements -- use the index 
            Console.WriteLine("The length of each array is:\n");
            Console.WriteLine("breakfastfoods: " + breakfastfoods.length[0]);
            Console.WriteLine("testscores: " + testscores.lenght[0]);
            Console.WriteLine("GPA: " + GPA.lenght[0]);
 

           
        
        }        
    }        
}     
        
        
        
        
        
    
 








=