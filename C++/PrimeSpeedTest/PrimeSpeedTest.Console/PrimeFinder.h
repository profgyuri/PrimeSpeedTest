//PrimeFinder.h

#pragma once
#include <vector>

namespace Primes
{
	class prime_finder
	{
	private:
		long sqrt_base_;
		std::vector<int> primes_;
		void set_sqrt_base(long number);
		void check_if_prime(long number);
		long get_current();
	public:
		prime_finder();
		void calculate_first_n_primes(int n);
		unsigned long long get_calculated_primes_length() const;
		long get_last_prime() const;
	};
}
