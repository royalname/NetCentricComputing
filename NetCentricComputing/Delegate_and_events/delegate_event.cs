using System;

namespace NetCentricComputing
{
    class NumberCheck
    {
        // Delegate
        public delegate void EvenNumberHandler(int number);

        // Event
        public event EvenNumberHandler EvenNumberEvent;

        public void CheckNumber(int number)
        {
            Console.WriteLine("Number = " + number);

            if (number % 2 == 0)
            {
                EvenNumberEvent?.Invoke(number);
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            Console.WriteLine();
        }
    }

    class DelegateEventDemo
    {
        public static void DisplayEvenNumber(int number)
        {
            Console.WriteLine(number + " is an even number.");
        }

        public static void Run()
        {
            Console.WriteLine("Delegates and Events");

            NumberCheck numberCheck = new NumberCheck();

            // Subscribe the method to the event
            numberCheck.EvenNumberEvent += DisplayEvenNumber;

            numberCheck.CheckNumber(10);
            numberCheck.CheckNumber(7);
            numberCheck.CheckNumber(20);
        }
    }
}