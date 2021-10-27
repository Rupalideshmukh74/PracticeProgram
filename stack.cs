using System;
using System.Collections.Generic;
using System.Text;

namespace stack_and_queue
{
    public class stack
    {
        int[] element = new int[5];
        int top=-1;
         int max=5;
       

        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                
            }
            else
            {
                top++;
               element [top] = item;
            }
        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                
            }
            else
            {
                Console.WriteLine("{0} popped from stack ", element[top]);
                top--;
            }
        }

        

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                
            }
            else
            {
                for (int i = top; i>=0; i--)
                {
                    Console.WriteLine("{0} pushed into stack", element[i]);
                }
            }
        }
    }
}

