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
C#       |0:00.17  |0:00.43  |0:01.41  |0:03.47    |0:09.01    |0:33.05    |-           |-           |-
Python   |0:02.98  |0:07.98  |0:28.96  |1:18.34    |-          |-          |-           |-           |-
Java     |0:00.05  |0:00.12  |0:00.41  |0:01.01    |0:02.72    |0:09.94    |0:26.77     |1:12.40     |4:31.81
