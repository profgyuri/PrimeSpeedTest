mod PrimeFinder;

use std::time::Instant;

fn main() {
    let milestones = vec![
        100_000, 200_000, 500_000,
        1_000_000, 2_000_000, 5_000_000,
        10_000_000, 20_000_000, 50_000_000,
        100_000_000];

    let mut prime_finder = PrimeFinder::PrimeFinder::new();
    let start = Instant::now();

    for milestone in milestones {
        prime_finder.calculate_first_n_primes(milestone);
        let end = Instant::now();
        println!("{} primes found in {}", milestone, end.duration_since(start).as_millis());
    }
}
