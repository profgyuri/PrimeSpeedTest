#include "PrimeFinder.h"

void Primes::prime_finder::set_sqrt_base(const long number)
{
	if (number - sqrt_base_ * sqrt_base_ > sqrt_base_ + sqrt_base_)
	{
		sqrt_base_++;
	}
}

void Primes::prime_finder::check_if_prime(const long number)
{
	set_sqrt_base(number);

	for (unsigned long long i = 2; i < primes_.size(); i++)
	{
		if (number % primes_[i] == 0)
		{
			return;
		}

		if (primes_[i] > sqrt_base_)
		{
			break;
		}
	}

	primes_.push_back(number);
}

long Primes::prime_finder::get_current()
{
	long current = primes_.back();
	current += 6 - current % 6;

	if (current - 1 == primes_.back())
	{
		check_if_prime(current + 1);
		current += 6;
	}

	return current;
}

Primes::prime_finder::prime_finder()
{
	sqrt_base_ = 2;
	primes_.push_back(2);
	primes_.push_back(3);
}

void Primes::prime_finder::calculate_first_n_primes(const int n)
{
	if (primes_.size() >= n)
	{
		return;
	}

	long current = get_current();

	while (primes_.size() < n)
	{
		check_if_prime(current - 1);
		check_if_prime(current + 1);

		current += 6;
	}

	if (primes_.size() > n)
	{
		primes_.pop_back();
	}
}

unsigned long long Primes::prime_finder::get_calculated_primes_length() const
{
	return primes_.size();
}

long Primes::prime_finder::get_last_prime() const
{
	return primes_.back();
}
