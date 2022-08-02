class PrimeFinder:
    def __init__(self):
        self.primes = [2, 3]
        self.sqrtBase = 2

    def set_sqrt_base(self, number):
        if number - self.sqrtBase * self.sqrtBase > self.sqrtBase + self.sqrtBase:
            self.sqrtBase += 1

    def check_if_prime(self, number):
        self.set_sqrt_base(number)

        for i in range(2, len(self.primes) - 1):
            if number % self.primes[i] == 0:
                return

            if self.primes[i] > self.sqrtBase:
                break

        self.primes.append(number)

    def get_current(self):
        current = self.primes[-1]
        current += 6 - current % 6

        if current - 1 == self.primes[-1]:
            self.check_if_prime(current + 1)
            current += 6

        return current

    def calculate_first_n_primes(self, n):
        if len(self.primes) >= n:
            return

        current = self.get_current()

        while len(self.primes) < n:
            self.check_if_prime(current - 1)
            self.check_if_prime(current + 1)
            current += 6

        if len(self.primes) > n:
            self.primes.pop()

    def get_calculated_primes_length(self):
        return len(self.primes)
