from prime_finder import PrimeFinder
from datetime import datetime

finder = PrimeFinder()
start_time = datetime.now()

# returns after ~2.8 seconds
finder.calculate_first_n_primes(count=100_000)
print(datetime.now() - start_time)

# returns after ~7.5 seconds
finder.calculate_first_n_primes(count=200_000)
print(datetime.now() - start_time)

# returns after ~77 seconds
finder.calculate_first_n_primes(count=1_000_000)
print(datetime.now() - start_time)
