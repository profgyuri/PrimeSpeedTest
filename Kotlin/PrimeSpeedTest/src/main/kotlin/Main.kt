import java.time.Duration
import java.time.LocalDateTime
import java.util.Timer

fun main(args: Array<String>) {
    val milestones = listOf(
        100_000, 200_000, 500_000,
        1_000_000, 2_000_000, 5_000_000,
        10_000_000, 20_000_000, 50_000_000,
        100_000_000)

    val primeFinder = PrimeFinder()

    // start measuring runtime
    val start = LocalDateTime.now()
    var end = LocalDateTime.now()

    milestones.forEach {
        primeFinder.calculateFirstNPrimes(it)
        end = LocalDateTime.now()
        println("$it: ${calculateRuntime(start, end)}")
    }

}

// Function to calculate the runtime of the program
// Returns a formatted string with the runtime in minutes, seconds, and milliseconds
fun calculateRuntime(start: LocalDateTime, end: LocalDateTime): String {
    val runtime = Duration.between(start, end)
    val minutes = runtime.toMinutes()
    val seconds = runtime.minusMinutes(minutes).seconds
    val milliseconds = runtime.minusSeconds(seconds).toMillis()
    return String.format("%d:%02d.%03d", minutes, seconds, milliseconds)
}