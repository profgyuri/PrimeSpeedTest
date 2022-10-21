pub struct PrimeFinder{
    primes: Vec<u64>,
    sqrt_base: u64,
}

impl PrimeFinder{
    pub fn  new() -> PrimeFinder{
        PrimeFinder{
            primes: vec![2, 3],
            sqrt_base: 2,
        }
    }
}

impl PrimeFinder{
    fn set_sqrt_base(&mut self, number : u64){
        if number - self.sqrt_base * self.sqrt_base > self.sqrt_base + self.sqrt_base
        {
            self.sqrt_base += 1;
        }
    }

    fn get_current(&mut self,) -> u64{
        //set current to last prime
        let mut current = *self.primes.last().unwrap();
        current += 6 - current % 6;

        if current -1 == *self.primes.last().unwrap() {
            Self::check_if_prime(self, current + 1);
            current += 6;
        }

        current
    }

    fn check_if_prime(&mut self, number : u64){
        Self::set_sqrt_base(self, number);

        for i in 2..self.primes.len() {
            if number % self.primes[i] == 0{
                return;
            }

            if self.primes[i] > self.sqrt_base {
                break;
            }
        }

        self.primes.push(number);
    }

    pub fn calculate_first_n_primes(&mut self, n : usize){
        if self.primes.len() >= n{
            return;
        }

        let mut current = Self::get_current(self);

        while self.primes.len() < n{
            Self::check_if_prime(self, current - 1);
            Self::check_if_prime(self, current + 1);
            current += 6;
        }

        if self.primes.len() > n{
            self.primes.pop();
        }
    }
}
