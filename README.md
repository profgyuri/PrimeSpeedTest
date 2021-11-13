# PrimeSpeedTest

The purpose of this project is to compare the running times of the same algorithm on different languages. The code calculates the firs n prime numbers.

Hardware used for the results:
 - AMD Ryzen 7 5800x @ 3.8 GHz
 - Trident Z Neo 3600 MHz 16-19-19-39

OS: Win11

Time format: M(minutes):SS(seconds).FF(miliseconds)

Results (so far) with a timeout of 10 minutes:

Language | 100_000 | 200_000 | 500_000 | 1_000_000 | 2_000_000 | 5_000_000 | 10_000_000 | 20_000_000 | 50_000_000
:-------:|:-------:|:-------:|:-------:|:---------:|:---------:|:---------:|:----------:|:----------:|:----------:
C#       |0:00.25  |0:00.48  |0:01.42  |0:03.55    |0:09.11    |0:33.21    |1:29.54     |4:03.05     |DNF
Python   |0:02.98  |0:07.98  |0:28.96  |1:18.34    |3:32.13    |DNF        |DNF         |DNF         |DNF
Java     |0:00.05  |0:00.12  |0:00.41  |0:01.01    |0:02.72    |0:09.94    |0:26.77     |1:12.40     |4:31.81

All these results move somewhere near these times, and are not exact at all (as background tasks may chenge the values with a very small amount) but give a good idea of the real running time.
