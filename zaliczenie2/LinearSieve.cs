using System;
using System.Collections.Generic;
using System.Text;

namespace zaliczenie2
{
    class LinearSieve
    {
        private void remove()
        {

        }
        private void next()
        {

        }

        public static int[] getResult(int[] numbers)
        {
            if (numbers[0] < 2)
                throw new ArgumentException("The first integer of the array cannot be smaller than two.");

            if (numbers[1] <= numbers[0] || numbers[1] - numbers[0] != 1)
                throw new ArgumentException("The list of integers is not consecutive.");

            int[] result;
            int p = numbers[0];
            int q;
            int x;

            while (p * p <= numbers[^1])
            {
                q = p;

                while (p * q <= numbers[^1])
                {
                    x = p * q;
                }
            }

            return result;
        }
    }
}
