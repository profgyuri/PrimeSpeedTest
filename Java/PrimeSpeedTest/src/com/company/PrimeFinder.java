package com.company;

import java.util.ArrayList;
import java.util.List;

public class PrimeFinder {
    private final List<Long> primes;
    private Long sqrtBase;

    public PrimeFinder()
    {
        primes = new ArrayList<>();
        primes.add((long)2);
        primes.add((long)3);

        sqrtBase = 2L;
    }

    private void SetSqrtBase(Long number){
        if (number - sqrtBase * sqrtBase > sqrtBase + sqrtBase)
        {
            sqrtBase++;
        }
    }

    private void CheckIfPrime(long number) {
        SetSqrtBase(number);
        //We skip number 2 and 3 from checking, since we don't need it based on the 6-step idea,
        //also we don't need to go above the square root of the number.
        for (int i = 2; i < primes.size(); i++) {
            //If the remainder of division with any prime equals to 0, the checked number is not a prime.
            if (number % primes.get(i) == 0) {
                return;
            }

            if (primes.get(i) > sqrtBase) {
                break;
            }
        }

        primes.add(number);
    }

    private long GetCurrent()
    {
        long current = primes.get(primes.size() - 1);
        //make the current number equal to the next number divisible by 6
        current += 6 - current % 6;

        if (current - 1 == primes.get(primes.size() - 1))
        {
            CheckIfPrime(current + 1);
            current += 6;
        }

        return current;
    }

    public void CalculateFirstNPrimes(int n)
    {
        if (primes.size() >= n)
        {
            return;
        }

        //To continue calculation from the last prime already in the list.
        long current = GetCurrent();

        while (primes.size() < n)
        {
            CheckIfPrime(current - 1);
            //not checking if we have the correct amount here sacrifices precision in favor of speed
            CheckIfPrime(current + 1);

            //increasing the current base value, taking into account that every prime number is next to a multiple of 6
            current += 6;
        }

        if (primes.size() > n)
        {
            primes.remove(primes.size() - 1);
        }
    }

    public int GetCalculatedPrimesLength()
    {
        return primes.size();
    }
}
