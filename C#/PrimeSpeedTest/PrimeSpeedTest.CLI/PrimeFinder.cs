namespace PrimeSpeedTest.CLI;
using System;
using System.Globalization;

internal class PrimeFinder
{
    private ulong[] _primes;
    private DateTime _start;
    private int _timeoutMinutes = 10;
    private int _currentPosition;

    public PrimeFinder()
    {
        _start = DateTime.Now;

        _primes = new ulong[50_000_000];
        _primes[0] = 2;
        _primes[1] = 3;
        _currentPosition = 2;
    }

    public string CalculateFirstNPrimes(int count)
    {
        if (DateTime.Now - _start >= TimeSpan.FromMinutes(_timeoutMinutes))
        {
            return null;
        }

        ulong current = _primes[_currentPosition - 1] + 1;

        while (current % 6 != 0)
        {
            current += 2;
        }

        while (_currentPosition < count)
        {
            ulong lower = current - 1;
            ulong higher = current + 1;

            if (IsPrime(lower))
            {
                _primes[_currentPosition++] = lower;

                //If we have the desired number of primes, we don't have to check the higher.
                if (_currentPosition == count)
                {
                    break;
                }
            }

            if (IsPrime(higher))
            {
                _primes[_currentPosition++] = higher;
            }

            current += 6;
        }

        return $"{DateTime.Now - _start:mm':'ss'.'ff} - {_currentPosition.ToString("N", CultureInfo.InvariantCulture)}";
    }

    private bool IsPrime(ulong number)
    {
        //If the input is the last of the primes list just return false or it may be added again.
        if (number == _primes[^1])
        {
            return false;
        }

        for (int i = 0; i < _currentPosition; i++)
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
