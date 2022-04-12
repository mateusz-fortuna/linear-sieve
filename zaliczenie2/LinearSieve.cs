using System;
using System.Collections.Generic;
using System.Linq;

namespace zaliczenie2
{
    class LinearSieve
    {
        private void RemoveInt(int[] arr, int i)
        {
            arr.Where(val => val != i);
        }

        private int GetNextInt(int[] arr, int i)
        {
            return Array.IndexOf(arr, i) + 1;
        }

        public List<int> GetResult(int[] numbers)
        {
            if (numbers[0] < 2)
                throw new ArgumentException("The first integer of the array cannot be smaller than two.");

            if (numbers[1] <= numbers[0] || numbers[1] - numbers[0] != 1)
                throw new ArgumentException("The list of integers is not consecutive.");

            List<int> result = new List<int>();
            int p = numbers[0];
            int q;
            int x;

            while (p * p <= numbers[^1])
            {
                q = p;

                while (p * q <= numbers[^1])
                {
                    x = p * q;

                    while (x <= numbers[^1])
                    {
                        RemoveInt(numbers, x);
                        x = p * x;
                    }

                    q = GetNextInt(numbers, q);
                }

                p = GetNextInt(numbers, p);
            }

            // Return numbers from 1 to n that exist in array

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Array.IndexOf(numbers, i) != -1)
                    result.Append(i);
            }

            return result;
        }
    }
}
