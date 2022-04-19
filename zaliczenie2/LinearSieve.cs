using System.Collections.Generic;

namespace zaliczenie2
{
    class LinearSieve
    {
        List<int> primeNumbers = new List<int>();
        List<int> minimumPrimeFactors = new List<int>();
        int listLength = 0;

        public LinearSieve(int listLength)
        {
            for (int i = 0; i < listLength + 1; i++)
            {
                minimumPrimeFactors.Add(0);
            }

            this.listLength = listLength;
        }

        public List<int> GetResult()
        {
            for (int i = 2; i < listLength; i++)
            {
                if (minimumPrimeFactors[i] == 0)
                {
                    minimumPrimeFactors[i] = i;
                    primeNumbers.Add(i);
                }

                for (
                    int j = 0;
                    j < primeNumbers.Count
                        && primeNumbers[j] <= minimumPrimeFactors[i]
                        && i * primeNumbers[j] <= listLength;
                    j++
                )
                {
                    minimumPrimeFactors[i * primeNumbers[j]] = primeNumbers[j];
                }
            }

            return primeNumbers;
        }
    }
}
