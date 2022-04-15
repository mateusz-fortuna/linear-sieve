using System;
using System.Collections.Generic;
using System.Linq;

namespace zaliczenie2
{
    class LinearSieve
    {
        private List<int> integers = new List<int>();
        private List<int> removedIntegers = new List<int>();

        public LinearSieve(int listLength)
        {
            for (int i = 0; i < listLength; i++)
            {
                integers.Add(i + 2);
            }
        }

        private static bool ExistsInList<T>(List<T> list, T el)
        {
            return list.IndexOf(el) != -1;
        }

        private static int GetNextInt(List<int> list, int i)
        {
            return list[list.IndexOf(i) + 1];
        }

        private static int GetNextNotRemovedInt(
            List<int> removedIntegers,
            List<int> integers,
            int i
        )
        {
            int index = integers.IndexOf(i);
            int nextIndex = index + 1;
            int nextInt = integers[nextIndex];

            while (ExistsInList<int>(removedIntegers, nextInt))
            {
                nextIndex++;
            }

            return nextInt;
        }

        public List<int> GetResult()
        {
            List<int> result = new List<int>();
            int p = integers[0];
            int q;
            int x;

            while (p * p <= integers[^1])
            {
                q = p;

                while (p * q <= integers[^1])
                {
                    x = p * q;

                    while (x <= integers[^1])
                    {
                        integers.Remove(x);
                        removedIntegers.Add(x);
                        x = p * x;
                    }

                    q = GetNextNotRemovedInt(removedIntegers, integers, q);
                }

                p = GetNextInt(integers, p);
            }

            for (int i = 2; i < integers[^1]; i++)
            {
                if (ExistsInList(integers, i))
                    result.Add(i);
            }

            return result;
        }
    }
}
