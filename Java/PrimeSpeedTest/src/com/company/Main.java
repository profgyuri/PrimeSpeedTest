package com.company;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Main {

    public static void main(String[] args) {
        PrimeFinder finder = new PrimeFinder();
        long start = System.currentTimeMillis();

        //return after 1 sec
        finder.CalculateFirstNPrimes(1_000_000);
        System.out.println(System.currentTimeMillis() - start + " ms");
        //return after ~3.6 seconds
        finder.CalculateFirstNPrimes(2_000_000);
        System.out.println(System.currentTimeMillis() - start + " ms");
        //return after ~13.6 seconds
        finder.CalculateFirstNPrimes(5_000_000);
        System.out.println(System.currentTimeMillis() - start + " ms");
        //return after ~40.3 seconds
        finder.CalculateFirstNPrimes(10_000_000);
        System.out.println(System.currentTimeMillis() - start + " ms");
    }
}
