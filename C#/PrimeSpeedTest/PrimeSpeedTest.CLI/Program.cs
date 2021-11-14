// See https://aka.ms/new-console-template for more information
using PrimeSpeedTest.CLI;

var startTime = DateTime.Now;
var intervals = new int[] { 
    100_000,
    200_000,
    500_000,
    1_000_000,
    2_000_000,
    5_000_000,
    10_000_000,
    20_000_000,
    50_000_000
};
PrimeFinder primeFinder = new();

for (int i = 0; i < intervals.Length; i++)
{
    if (primeFinder.CalculateFirstNPrimes(intervals[i]) is string result)
    {
        Console.WriteLine(result);
    }
}