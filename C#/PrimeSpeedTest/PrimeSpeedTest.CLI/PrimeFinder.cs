namespace PrimeSpeedTest.CLI;

internal class PrimeFinder
{
    private List<long> _primes;
    private long _sqrtBase;

    public PrimeFinder()
    {
        _primes = new() { 2, 3 };
        _sqrtBase = 2;
    }

    /// <summary>
    /// We only need to compare the integer part of the square root.
    /// Only marginally, but faster than Math.Sqrt <br/>
    /// For the logic of this method see: https://youtu.be/PJHtqMjrStk
    /// </summary>
    /// <param name="number"></param>
    private void SetSqrtBase(long number)
    {
        if (number - _sqrtBase * _sqrtBase > _sqrtBase + _sqrtBase)
        {
            _sqrtBase++;
        }
    }

    private long GetCurrent()
    {
        long current = _primes[^1];
        //make the current number equal to the next number divisible by 6
        current += 6 - current % 6;

        if (current - 1 == _primes[^1])
        {
            CheckIfPrime(current + 1);
            current += 6;
        }

        return current;
    }

    private void CheckIfPrime(long number)
    {
        SetSqrtBase(number);
        //We skip number 2 and 3 from checking, since we don't need it based on the 6 step idea.
        //Also we don't need to go above the square root of the number.
        for (int i = 2; i < _primes.Count; i++)
        {
            //If the remainder of division with any prime equals to 0, the checked number is not a prime.
            if (number % _primes[i] == 0)
            {
                return;
            }

            if (_primes[i] > _sqrtBase)
            {
                break;
            }
        }

        //If we don't get 0 as remainder, the number is prime.
        _primes.Add(number);
    }

    public void CalculateFirstNPrimes(int n)
    {
        if (_primes.Count >= n)
        {
            return;
        }

        //To continue calculation from the last prime already in the list.
        long current = GetCurrent();

        while (_primes.Count < n)
        {
            CheckIfPrime(current - 1);
            //not checking if we have the correct amount here sacrifices precision in favor of speed
            CheckIfPrime(current + 1);

            //increasing the current base value, taking into account that every prime number is next to a multiple of 6
            current += 6;
        }

        if (_primes.Count > n)
        {
            _primes.RemoveAt(_primes.Count - 1);
        }
    }

    public int GetCalculatedPrimesLength()
    {
        return _primes.Count;
    }
}
