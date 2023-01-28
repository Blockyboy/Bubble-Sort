using System;

namespace BubbleSort
{
    class Program
    {

        public static void Initialise()
        {
            int[] numbers = new int[50];
            Random r = new Random();

            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = r.Next(0, 100);
            }

            DisplayBeforeAndAfterSort(ref numbers);
        }

        public static void DisplayBeforeAndAfterSort(ref int[] numbers)
        {

            Console.WriteLine("Before Sort");

            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine(Convert.ToString(numbers[i]));
            }

            BubbleSort(ref numbers);

            Console.WriteLine("");

            Console.WriteLine("After Sort");
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine(Convert.ToString(numbers[i]));
            }

        }

        public static void BubbleSort(ref int[] numbers)
        {
            bool notSorted = true;
            var temp = 0;

            while (notSorted)
            {
                for (int i = 0; i < numbers.Length - 1; ++i)
                {
                    if (i != numbers.Length)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            temp = numbers[i + 1];
                            numbers[i + 1] = numbers[i];
                            numbers[i] = temp;

                            notSorted = true;
                        }
                    }

                }

                notSorted = false;

                for (int i = 0; i < numbers.Length - 1; ++i)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        notSorted = true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Initialise();
        }
    }
}
