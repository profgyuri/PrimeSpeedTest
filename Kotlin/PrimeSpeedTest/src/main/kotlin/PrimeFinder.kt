import java.time.LocalDateTime
import kotlin.math.sqrt

class PrimeFinder {
    private var primes = mutableListOf<ULong>(2u, 3u, 5u)
    private var sqrtBase : ULong = 2u

    fun calculateFirstNPrimes(n: Int) {
        if (primes.size >= n) return

        var current = getCurrent()

        while (primes.size < n) {
            checkIfPrime(current - 1u)
            checkIfPrime(current + 1u)

            current += 6u
        }

        if (primes.size > n){
            primes.removeAt(primes.size - 1)
        }
    }

    private fun setSqrtBase(n: ULong) {
        if (n - sqrtBase * sqrtBase > sqrtBase + sqrtBase)
        {
            sqrtBase++;
        }
    }

    private fun getCurrent() : ULong {
        var current = primes.last()
        current += 6u - current % 6u

        if (current - 1u == primes.last())
        {
            checkIfPrime(current + 1u)
            current += 6u
        }

        return current
    }

    private fun checkIfPrime(n: ULong) {
        setSqrtBase(n)

        for (i in (2..primes.size)){
            if (n % primes[i] == 0.toULong()) {
                return
            }

            if (primes[i] > sqrtBase) {
                break
            }
        }

        primes.add(n)
    }

    fun getPrimesCount() : Int {
        return primes.size
    }
}