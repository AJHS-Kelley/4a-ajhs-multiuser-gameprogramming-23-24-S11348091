// Amaure Cooper, Program Template, v0.0

using System;
using System.Collections;
using System.toint32;
namespace GameMethod
{

   class Program
   {

    static string CarModels()
    {
        var CarModels = new ArrayList()
        {
            "[0] Camero ss", "[1] Lambo Hurricane", "[2] Ford Mustang", "[3] McLaren sc", "[4] F1", "[5] Bugatti"
        };
        Console.WriteLine("Car selection: \n");
        // Have the player type the number of the car they want, make sure to save it to a variable. Example: carSelection
        foreach (var item in CarModels)
        {
            Console.WriteLine(item);    
        }
        Console.WriteLine("Choose your car.\n");
        int carSelection = Convert.toint32(Console.ReadLine());
        Console.WriteLine(carSelection);
        return CarModels[carSelection];
    }
    

    static void MotionCapture()
    {
    
    }


    static int Speed()
    {
      return 90;
    }
      
    
      
    //Keep Main at the bottom
    static void Main(string[] args)
    {
        CarModels();
    }
   } 
}   

