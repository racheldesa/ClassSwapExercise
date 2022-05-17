using System;
/// <summary>
/// Console application that allows user to swap references between two different 
/// Elephant objects
/// </summary>

namespace ClassSwapExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant("Lloyd", 40);
            Elephant lucinda = new Elephant("Lucinda", 33);

            int userInput;
            do
            {
                Console.Write("Press 1 for Lloyd, 2 for Lucinda, 3 to swap: ");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("You pressed 1\nCalling lloyd.WhoAmI()\n");
                        Console.WriteLine(lloyd.WhoAmI());
                        break;
                    case 2:
                        Console.WriteLine("You pressed 2\nCalling lucinda.WhoAmI()\n");
                        Console.WriteLine(lucinda.WhoAmI());
                        break;
                    case 3:
                        Elephant temp = lloyd;
                        lloyd = lucinda;
                        lucinda = temp;
                        Console.WriteLine("References have been swapped");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            } while (userInput <= 3);
            
        }
    }
}
