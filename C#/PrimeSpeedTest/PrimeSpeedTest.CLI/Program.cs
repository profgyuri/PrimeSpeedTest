// See https://aka.ms/new-console-template for more information
using PrimeSpeedTest.CLI;

PrimeFinder primeFinder = new();
var startTime = DateTime.Now;

//returns after ~3.4 seconds
primeFinder.CalculateFirstNPrimes(1_000_000);
Console.WriteLine($"{DateTime.Now - startTime}");

//returns after ~9 seconds
primeFinder.CalculateFirstNPrimes(2_000_000);
Console.WriteLine($"{DateTime.Now - startTime}");

//returns after ~33 seconds
primeFinder.CalculateFirstNPrimes(5_000_000);
Console.WriteLine($"{DateTime.Now - startTime}");
