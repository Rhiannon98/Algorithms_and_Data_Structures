using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search!");
            // hard coded array:
            int[] intArray = new int[]{1,4,5,8,9,10,17,22,44,45,66};
            // displaying the array:
            for(int i=0; i<intArray.Length; i++){Console.WriteLine($"{intArray[i]}  ");}
            // hard coded search key: 
            int sKey = 17;
            // showing the user the search key
            Console.WriteLine($"the search key is:: {sKey}");
            // writing the index result from the console
            Console.WriteLine(BinarySearch(intArray, sKey, 0, intArray.Length-1));
        }
        static int BinarySearch(int[] array, int sKey, int Min, int Max)
        {
            // if element DNE, just return -1 for result
            int result = -1;

            // the mid point of the array changes per time the function runs
            int Mid = (Max - Min)/2 + Min;

            //grab that first half of the array
            if (sKey < array[Mid])
            {
                // we have to reassign max if we need to run through this again
                Max = Mid;
                return BinarySearch(array, sKey, Min, Max);
            }
            // grabbing the second half if sKey isnt in first half
            if (sKey > array[Mid])
            {
                // we need to reassign the min here
                // same reason as the max reassigned
                Min = Mid;
                return BinarySearch(array, sKey, Min, Max);
            }
            // we are wanting to return the index of sKey if we have found it (mid is afterall just an index)
            if (array[Mid] == sKey)
            {
                result = Mid;
            }
            return result;
        }
    }
}
