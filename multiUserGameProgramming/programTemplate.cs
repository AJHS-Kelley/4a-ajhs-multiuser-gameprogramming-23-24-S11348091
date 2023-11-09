// Amaure Cooper, Program Template, v0.0
using System;
/*
Void Method
Method return
Method Parameter
Method with multiple Parameters 
Method with Default Parameters
Method Class using Named Arguments
method overloading
*/
namespace MethodsParameters
{
    class Program MethodsParameters 
    {
        // Method -- name block of code, can be used over again.
        // All methods have a SIGNATURE that defines their names, parameters, and 
        // Example signature
        0 reference 
        static void myMethod()
        {
           Console.writeLine("I Like mine with lettce and tamtos, Heniz 57, and french fries potatoes.\n");
        }
        // static -- this method belongs to the current class, it is not an object
        // void -- This method has no return value.
        
        0 reference
        static int Doubleup();
        {
           int sum = 0;
           Console.writeLine("This methoid will double a number and return it.\n");
           Console.writeLine("Please enetr a number on the next line.\n")
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum = *= 2;
            //Console.writeLine(sum)
            return sum *= 2   
        }
         

          // Methods with parameters
        0 refernce 
        static void MakePancakes(int num)
        {
          Console.writeLine("One golden, fluffy pancake coming up!\n"); 
        }
      } 

        0 refernce 
        static void MakeEggs(int num, string style)
             
        // Using defaults for parameters
        static void MakeBurger(int num = 1)
      {
        Console.writeLine("I am going to cook " + num + "hmburgers.\n");
      }
    
       // Named Arguments
       static void AllmyCHildern(string child1, string child2, string child3)
      {
        Console.WriteLine("My favorite child is " + child3);
      }
       
      // METHOD OVERLOADING
      static int Findsum(int x, int y);
      {
        int sum = x + y;
        Console.WriteLine("Sum: " + sum);
        return sum;

      }

      static void main(string[]args)
      {
        //MyMethod();
        //DoubleUp();
        //MakePancakes();
        //MakeEggs(10, "sunny side up");
        MakeBurger();
        MakeBurger(10);
        AllmyChildern(child3: "Steve", child2: "Susan", Child1: "Chewbacca");
        FindSum(1, 5); // Two INTEGERS
        FindSum(9.5, 2,4); // TWO DOUBLES
        FindSum(5, 2.5); // ONE OF EACH
      {

    }
    
    
  }

   
}


    

    