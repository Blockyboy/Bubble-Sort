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

            Console.WriteLine("Before Sort");
            Display(ref numbers);

            BubbleSort(ref numbers);
        }

        public static void Display(ref int[] numbers)
        {
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

            Console.WriteLine("After Sort");
            Display(ref numbers);
        }
        static void Main(string[] args)
        {
            Initialise();
        }
    }
}
