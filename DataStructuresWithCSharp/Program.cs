using System;
using System.Collections;

namespace StackProgram
{
    public class Program 
    {
        /* Non -Generic Stack */
        public static void Main(string[] args)
        {
            Stack myStack = new Stack();

            bool x = true;
            // this will loop through infinitely until x = false
            while (x)
            {
                //Asking for the operation
                Console.WriteLine("***** Non-generic Stack Operations *****");
                Console.WriteLine("1) Push Operation");
                Console.WriteLine("2) Pop Operation");
                Console.WriteLine("3) Peek Operation");
                Console.WriteLine("4) Display Operation");
                Console.WriteLine("5) Exit");
                Console.WriteLine("Enter the operation no. : ");
               
                int input_op = int.Parse(Console.ReadLine());
               //switch case
                switch (input_op)
                {
                    //Push Operation in Stack
                    case 1:
                        Console.WriteLine("Enter what you want to push:");
                        var input_push = Console.ReadLine();
                        myStack.Push(input_push);
                        break;
                    //Pop Operation in Stack
                    case 2:
                        Console.WriteLine("Popping the top item");
                        // Check if stack is empty or not
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
                    // Peek the top item
                    case 3:
                        Console.WriteLine("Peeking in the stack");
                        Console.WriteLine(myStack.Peek());
                        break;
                    // Display/Traverse in stack
                    case 4:
                        Console.WriteLine("Looping through stack");
                        foreach (var item in myStack)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    // exit from the program
                    case 5:
                        Console.WriteLine("Exiting from program");
                        x = false;
                        break;
                    // if user enters something else
                    default:
                        Console.WriteLine("Sorry! Please type a valid operation no.");
                        break;
                }
                
            }
        }
    }
}