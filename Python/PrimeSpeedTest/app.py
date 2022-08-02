from prime_finder import PrimeFinder
from datetime import datetime
from multiprocessing import Process


intervals =\
    [100_000, 200_000, 500_000, 1_000_000,
     2_000_000, 5_000_000, 10_000_000,
     20_000_000, 50_000_000, 100_000_000]
finder = PrimeFinder()
start = datetime.now()


def func():
    print(start)
    for i in intervals:
        finder.calculate_first_n_primes(n=i)
        print(f"{format(i, '_')} - {datetime.now() - start}")


if __name__ == "__main__":
    thread = Process(target=func, args=(), daemon=True)
    thread.start()
    thread.join(3600.0)
    print(f"{finder.get_calculated_primes_length()} - 1 hour")
