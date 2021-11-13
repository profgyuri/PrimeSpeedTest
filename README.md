# PrimeSpeedTest

The purpose of this project is to compare the running times of the same algorithm on different languages. The code calculates the firs n prime numbers.

Hardware used for the results:
 - AMD Ryzen 7 5800x @ 3.8 GHz
 - Trident Z Neo 3600 MHz 16-19-19-39

OS: Win11

Results (so far):

Language | 100_000 | 200_000 | 500_000 | 1_000_000 | 2_000_000 | 5_000_000 | 10_000_000 | 20_000_000 | 50_000_000
:-------:|:-------:|:-------:|:-------:|:---------:|:---------:|:---------:|:----------:|:----------:|:----------:
C#       |~177ms   |~439ms   |~1.41s   |~3.47s     |~9.01s     |~33.05s    |-           |-           |-
Python   |~2.8s    |~7.5s    |-        |~77s       |-          |-          |-           |-           |-
Java     |~48ms    |~159ms   |~540ms   |~1.54s     |~4.22s     |~14.12s    |~40.75ms    |-           |-
