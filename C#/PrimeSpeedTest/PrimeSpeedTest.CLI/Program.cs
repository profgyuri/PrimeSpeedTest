using System.Diagnostics;
using PrimeSpeedTest.CLI;

Stopwatch _stopwatch = new();

var intervals = new int[] { 
    100_000,
    200_000,
    500_000,
    1_000_000,
    2_000_000,
    5_000_000,
    10_000_000,
    20_000_000,
    50_000_000,
    100_000_000
};
PrimeFinder primeFinder = new();
List<string> list = new();
_stopwatch.Start();

foreach (var item in intervals)
{
    primeFinder.CalculateFirstNPrimes(item);
    Console.WriteLine($"{item:n0} - {_stopwatch.Elapsed:mm':'ss'.'fff} - {primeFinder.GetCalculatedPrimesLength()}");
}