using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // stating the lab
            Console.WriteLine("Lab : Reverse Array");
            //array for equation to work
            int[] intArray = new int[] {1,2,3,4,5,6,7,8,9};

            // writing the original array first
            Console.WriteLine("Original array: ");
            foreach (var i in intArray)
            {
                Console.WriteLine($"{i}  ");
            }

            // function invocation
            int[] revArray = ReversedArray(intArray);
            
            // displaying the reversed array
            Console.WriteLine("Reversed array: ");
            foreach (var j in revArray)
            {
                Console.WriteLine($"{j}  ");
            }
        }
        // this will reverse the array
        // input= integer array
        // output= integer array in reverse order
        static int[] ReversedArray(int[] array)
        {
            int[] revArray = new int[array.Length];

            for (int i=0 ; i < array.Length; i++)
            {
                revArray[i] = array[array.Length - (i + 1)];
            }
            return revArray;
        }
    }
}
