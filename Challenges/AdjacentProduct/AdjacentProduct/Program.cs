using System;

namespace AdjacentProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LARGEST Adjacent Product!");

            // hard coded 2d array
            int[,] intArray =
            {
                {1,3,5},
                {2,4,6},
                {7,9,11},
                {8,10,12}
            };
            // invocation of the calculating method
            LargestProduct(intArray);
        }
        // the calculation
        static void LargestProduct(int[,] array)
        {
            // product 1 holds the current product
            // product 2 is what is highest product
            int product1 = 0;
            int product2 = 0;

            for(int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1); j++)
                {
                    if (i+1<array.GetLength(0))
                    {
                        if (product1 < array[i,j] * array[i+1,j])
                        {
                            product1 = array[i,j] * array[i+1,j];
                        }
                        if (j>0)
                        {
                            if (product1 < array[i,j] * array[i+1,j-1])
                            {
                                product1 = array[i,j] * array[i+1,j-1];
                            }
                        }
                    }
                    if (j+1 < array.GetLength(1))
                    {
                        if (product1 < array[i, j] * array[i,j+1])
                        {
                            product1 = array[i,j] * array[i,j+1];
                        }
                    }
                    if (i+1 < array.GetLength(0) && j+1 < array.GetLength(1))
                    {
                        if (product1 < array[i, j] * array[i+1,j+1])
                        {
                            product1 = array[i, j] * array[i+1,j+1];
                        }
                    }
                    product2 = product1;
                }
            }
            Console.WriteLine(product2);
        }
    }
}
