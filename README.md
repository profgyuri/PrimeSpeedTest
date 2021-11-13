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
C#       |0:0.177  |0:0.439  |0:1.41   |0:3.47     |0:9.01     |0:33.05    |-           |-           |-
Python   |0:2.8    |0:7.5    |-        |1:17       |-          |-          |-           |-           |-
Java     |0:0.048  |0:0.121  |0:0.409  |0:1.0      |0:2.72     |0:9.94     |0:26.77     |1:12.4      |~4:31.81
