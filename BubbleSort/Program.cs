namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 2, 8, 4, 10, 3 };

            // Bubble Sort - Här är magin!
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Byt plats
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // Skriv ut resultatet
            Console.WriteLine("Sorterade värden:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}
