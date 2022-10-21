# PrimeSpeedTest

The purpose of this project is to compare the running times of the same algorithm on different languages. The code calculates the firs n prime numbers.

Hardware used for the results:
 - AMD Ryzen 7 5800x @ 3.8 GHz
 - Trident Z Neo 32 GB, 3600 MHz, 16-19-19-39

OS: Win11

Time format: MM(minutes):SS(seconds).FF(miliseconds)

Results (so far) up to 100 million primes:

Language/Count | 100_000  | 200_000  | 500_000  | 1_000_000  | 2_000_000  | 5_000_000  | 10_000_000  | 20_000_000  | 50_000_000  | 100_000_000 
:-------------:|:--------:|:--------:|:--------:|:----------:|:----------:|:----------:|:-----------:|:-----------:|:-----------:|:-----------:
C++            |00:00.03  |00:00.08  |00.00.29  |00:00.76    |00:02.01    |00:07.42    |00:20.15     |00:55.00     |03:27.84     |09:30.44 
Rust           |00:00.03  |00:00.08  |00:00.29  |00:00.77    |00:02.07    |00:07.71    |00:20.97     |00:57.17     |03:36.17     |09:54.42
C#             |00:00.04  |00:00.12  |00:00.37  |00:00.94    |00:02.47    |00:09.01    |00:24.52     |01:06.58     |04:10.64     |11:28.81
Java           |00:00.05  |00:00.12  |00:00.37  |00:00.96    |00:02.50    |00:09.17    |00:24.80     |01:07.21     |04:12.22     |11:29.13
Kotlin         |00:00.06  |00:00.15  |00:00.49  |00:01.25    |00:03.32    |00:12.28    |00:33.31     |01:30.61     |05:42.30     |15:41.90
Python         |00:01.46  |00:03.90  |00:14.54  |00:39.60    |01:48.21    |06:47.92    |18:34.58     |DNF          |DNF          |DNF

All these results move somewhere near these times, and are not exact at all (as background tasks may chenge the values with a very small amount) but give a good idea of the real running time.

Also important to note, that I'm not an expert in unmanaged languages, so it is possible to make the code better, but the learning curve is simply too steep to justify the cause of optimization for this relatively small project.

## Rules
 - Only object oriented languages are allowed!
 - The primeFinder class must be in a seperate file from the main method!
 - Only vanilla code allowed (no 3rd party libraries)!
 
If you want to see how an other, not yet listed language would perform, send a PR or just simply contact me (profgyuri@gmail.com) and I'll try my best to translate the code.
