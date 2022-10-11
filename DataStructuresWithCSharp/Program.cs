using System;
using System.Collections;

namespace StackProgram
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Stack myStack = new Stack();

            bool x = true;
            while (x)
            {
                Console.WriteLine("***** Non-generic Stack Operations *****");
                Console.WriteLine("1) Push Operation");
                Console.WriteLine("2) Pop Operation");
                Console.WriteLine("3) Peek Operation");
                Console.WriteLine("4) Display Operation");
                Console.WriteLine("5) Exit");
                Console.WriteLine("Enter the operation no. : ");
                int input_op = int.Parse(Console.ReadLine());
                switch (input_op)
                {
                    case 1:
                        Console.WriteLine("Enter what you want to push:");
                        var input_push = Console.ReadLine();
                        myStack.Push(input_push);
                        break;
                    case 2:
                        Console.WriteLine("Popping the top item");
                        if (myStack.Count > 0)
                        {
                            Console.WriteLine("Popped item: "+myStack.Peek );
                            myStack.Pop();
                            
                        }
                        else
                        {
                            Console.WriteLine("Sorry we are not able to pop");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Peeking in the stack");
                        Console.WriteLine(myStack.Peek());
                        break;
                    case 4:
                        Console.WriteLine("Looping through stack");
                        foreach (var item in myStack)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting from program");
                        x = false;
                        break;
                    
                    default:
                        Console.WriteLine("Sorry! Please type a valid operation no.");
                        break;
                }
                
            }
        }
    }
}