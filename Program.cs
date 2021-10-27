using System;

namespace stack_and_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            stack s = new stack();
            int choice; int num;Boolean state = true;
            while (state)
            {


                Console.WriteLine("enter your choice");
                Console.WriteLine("1.push\n2.pop\n3.printStack\n4.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data element");
                        num = int.Parse(Console.ReadLine());
                        s.push(num);
                        break;
                    case 2:
                        s.pop();
                        break;
                    case 3:
                        s.printStack();
                        break;
                    case 4:state = false;
                        break;

                    default:
                        Console.WriteLine("you enter wrong input");
                        break;

                }
            }
        }
    }
}