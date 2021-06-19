// Prime numbers up to the number passed to the method's signature. 
// Based on pseudocode at https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;

    class PrimeNumbers
    {
        public static int[] GetPrimes(int num)
        {
            int lim = (int) Math.Sqrt(num);
            bool[] isPrime = new bool[num + 1];
            for(int i = 0; i< isPrime.Length; i++)
            {
                isPrime[i] = true;
            }
            for(int i = 2; i < lim; i++)
            {
                if (isPrime[i])
                {
                    int count = 0;
                    for(int j = (int)Math.Pow(i, 2); j < isPrime.Length; j = ((int)Math.Pow(i, 2) + (count * i)))
                    {
                        isPrime[j] = false;
                        count++;
                    }
                }
            }
            List<int> primeNums = new List<int>();
            for (int i = 0; i < num; i++)
            {
                if (isPrime[i])
                {
                    if(i >= 2)
                    {
                        primeNums.Add(i);
                    }
                }
            }
            return primeNums.ToArray();
        }
        public static void Main(string[] args)
        {
            int[] primes = GetPrimes(100);
            foreach(var num in primes)
            {
                Console.Write(num + " ");
            }
        }
    }
}
