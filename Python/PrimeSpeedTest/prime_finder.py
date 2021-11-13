import math


class PrimeFinder:
    def __init__(self):
        self.primes = [2, 3]

    def is_prime(self, number):
        if number == self.primes[-1]:
            return False

        for i in range(len(self.primes)):
            prime = self.primes[i]

            if number % prime == 0:
                return False

            if prime > math.sqrt(number):
                break

        return True

    def calculate_first_n_primes(self, count):
        counter = len(self.primes)
        current = self.primes[-1] + 1

        while current % 6 != 0:
            current += 2

        while counter < count:
            lower = current - 1
            higher = current + 1

            if self.is_prime(lower):
                self.primes.append(lower)
                counter += 1

                if counter == count:
                    break

            if self.is_prime(higher):
                self.primes.append(higher)
                counter += 1

            current += 6

        return self.primes
