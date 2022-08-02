# PrimeSpeedTest

The purpose of this project is to compare the running times of the same algorithm on different languages. The code calculates the firs n prime numbers.

Hardware used for the results:
 - AMD Ryzen 7 5800x @ 3.8 GHz
 - Trident Z Neo 32 GB, 3600 MHz, 16-19-19-39

OS: Win11

Time format: MM(minutes):SS(seconds).FF(miliseconds)

Results (so far) with a timeout of 60 minutes:

Language/Count | 100_000  | 200_000  | 500_000  | 1_000_000  | 2_000_000  | 5_000_000  | 10_000_000  | 20_000_000  | 50_000_000  | 100_000_000 | 200_000_000 
:-------------:|:--------:|:--------:|:--------:|:----------:|:----------:|:----------:|:-----------:|:-----------:|:-----------:|:-----------:|:-----------:
C#             |00:00.04  |00:00.11  |00:00.37  |00:00.98    |00:02.60    |00:09.65    |00:26.17     |01:11.06     |04:27.53     |12:12.13     |33:27.67     
Python         |00:02.82  |00:07.54  |00:27.91  |01:15.27    |03:23.32    |-           |-            |-            |-            |-            |-            
Java           |00:00.05  |00:00.12  |00:00.41  |00:01.01    |00:02.72    |00:09.94    |00:26.77     |01:12.40     |04:31.81     |-            |-            
Kotlin         |00:00.06  |00:00.15  |00:00.46  |00:01.18    |00:03.10    |00:11.30    |00:30.45     |01:22.61     |05:08.30     |13:52.78     |-

All these results move somewhere near these times, and are not exact at all (as background tasks may chenge the values with a very small amount) but give a good idea of the real running time.
