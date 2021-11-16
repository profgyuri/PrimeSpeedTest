# PrimeSpeedTest

The purpose of this project is to compare the running times of the same algorithm on different languages. The code calculates the firs n prime numbers.

Hardware used for the results:
 - AMD Ryzen 7 5800x @ 3.8 GHz
 - Trident Z Neo 32 GB, 3600 MHz, 16-19-19-39

OS: Win11

Time format: MM(minutes):SS(seconds).FF(miliseconds)

Results (so far) with a timeout of 10 minutes:

Language | 100_000  | 200_000  | 500_000  | 1_000_000  | 2_000_000  | 5_000_000  | 10_000_000  | 20_000_000  | 50_000_000  | 100_000_000 | 200_000_000 | 1 hour      
:-------:|:--------:|:--------:|:--------:|:----------:|:----------:|:----------:|:-----------:|:-----------:|:-----------:|:-----------:|:-----------:|:-----------:
C#       |00:00.05  |00:00.13  |00:00.47  |00:01.24    |00:03.32    |00:12.33    |00:33.47     |01:31.01     |05:43.37     |15:40.83     |-            |-            
Python   |00:02.82  |00:07.54  |00:27.91  |01:15.27    |03:23.32    |DNF         |DNF          |DNF          |DNF          |-            |-            |-            
Java     |00:00.05  |00:00.12  |00:00.41  |00:01.01    |00:02.72    |00:09.94    |00:26.77     |01:12.40     |04:31.81     |-            |-            |-            

All these results move somewhere near these times, and are not exact at all (as background tasks may chenge the values with a very small amount) but give a good idea of the real running time.
