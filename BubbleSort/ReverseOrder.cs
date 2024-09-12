using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class ReverseOrder
    {
        static void ReverseSort()
        {
            // För att sortera i omvänd ordning ändrade jag bara jämförelsen...
            // från array[j] > array[j + 1]
            // till array[j] < array[j + 1].
            int[] array = { 6, 2, 8, 4, 10, 3 };

            // Bubble Sort i omvänd ordning
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1]) // Ändra jämförelsen till "<" för omvänd ordning
                    {
                        // Byt plats
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // Skriv ut resultatet
            Console.WriteLine("Sorterade värden i omvänd ordning:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }

    }
}
