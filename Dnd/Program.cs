using System;
using Dnd.ActionInput;

namespace Dnd
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Traveler!");
            Console.WriteLine("Welcome to Dnd!");


            FinalInput finalInput = new FinalInput();
            
            finalInput.StartInput();
            
            finalInput.OngoingInput();
            
            
            
            
           
        } 
    }
}