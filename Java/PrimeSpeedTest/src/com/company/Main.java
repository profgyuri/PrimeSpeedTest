package com.company;

public class Main {

    public static void main(String[] args) {
        PrimeFinder finder = new PrimeFinder();
        int[] intervals = new int[] {
                100_000,
                200_000,
                500_000,
                1_000_000,
                2_000_000,
                5_000_000,
                10_000_000,
                20_000_000,
                50_000_000,
                100_000_000
        };
        long start = System.nanoTime();

        for (int interval:
                intervals) {
            finder.CalculateFirstNPrimes(interval);
            // print out formatted time since start
            System.out.printf("%d: %.2f seconds\n", interval, (System.nanoTime() - start) / 1_000_000_000.0);
        }
    }
}
