package com.company;

import java.util.ArrayList;
import java.util.List;

public class PrimeFinder {
    private List<Long> primes;
    private long start;

    public PrimeFinder()
    {
        start = System.currentTimeMillis();

        primes = new ArrayList<>();
        primes.add((long)2);
        primes.add((long)3);
    }

    private boolean isPrime(long number)
    {
        int primesSize = primes.size();

        if(number == primes.get(primesSize - 1))
        {
            return false;
        }

        for (int i = 0; i < primesSize; i++)
        {
            long prime = primes.get(i);

            if (number % prime == 0)
            {
                return false;
            }

            if(prime > Math.sqrt(number))
            {
                break;
            }
        }

        return true;
    }

    public List<Long> CalculateFirstNPrimes(int count)
    {
        int counter = primes.size();
        long current = primes.get(primes.size() - 1) + 1;
        while (current % 6 != 0)
        {
            current += 2;
        }

        while (counter < count)
        {
            long lower = current - 1;
            long higher = current + 1;

            if (isPrime(lower))
            {
                primes.add(lower);
                counter++;
            }
            if (counter == count)
            {
                break;
            }
            if (isPrime(higher))
            {
                primes.add(higher);
                counter++;
            }

            current += 6;

            //if we reach the 10 minutes then just stop
            if (System.currentTimeMillis() - start >= 600_000)
            {
                return primes;
            }
        }

        return primes;
    }
}
