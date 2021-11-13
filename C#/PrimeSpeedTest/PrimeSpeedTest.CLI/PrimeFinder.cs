namespace PrimeSpeedTest.CLI;
using System;
using System.Collections.Generic;

internal class PrimeFinder
{
    private List<ulong> _primes = new() { 2, 3 };

    public List<ulong> CalculateFirstNPrimes(int count)
    {
        int counter = _primes.Count;
        ulong current = _primes[^1] + 1;

        while (current % 6 != 0)
        {
            current += 2;
        }

        while (counter < count)
        {
            ulong lower = current - 1;
            ulong higher = current + 1;

            if (IsPrime(lower))
            {
                _primes.Add(lower);
                counter++;

                //If we have the desired number of primes, we don't have to check the higher.
                if (counter == count)
                {
                    break;
                }
            }

            if (IsPrime(higher))
            {
                _primes.Add(higher);
                counter++;
            }

            current += 6;
        }

        return _primes;
    }

    private bool IsPrime(ulong number)
    {
        //If the input is the last of the primes list just return false or it may be added again.
        if (number == _primes[^1])
        {
            return false;
        }

        for (int i = 0; i < _primes.Count; i++)
        {
            ulong prime = _primes[i];

            //If the remainder of division with any prime equals to 0, the checked number is not a prime.
            if (number % prime == 0)
            {
                return false;
            }

            //If we can't find a prime divisor below the square root of the number, then we won't find above. (src: https://www.youtube.com/watch?v=lJ3CD9M3nEQ)
            if (prime > Math.Sqrt(number))
            {
                break;
            }
        }

        //If we don't get 0 as remainder for any of the currently existing primes, the number is prime.
        return true;
    }
}
