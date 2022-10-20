#include <iostream>
#include <chrono>
#include "PrimeFinder.h"

using namespace Primes;
using namespace std::chrono;
using namespace std;

int main()
{
    prime_finder finder;
    vector<int> milestones = {
    	100000, 200000, 500000,
    1000000, 2000000, 5000000,
    10000000, 20000000, 50000000,
    100000000};
    const auto start = high_resolution_clock::now();

	for (auto milestone : milestones)
	{
		finder.calculate_first_n_primes(milestone);
		const auto end = high_resolution_clock::now();
		const auto duration = duration_cast<milliseconds>(end - start);
		cout <<  milestone << " in: " << duration.count() << "ms" << endl;
	}
	
    return 0;
}