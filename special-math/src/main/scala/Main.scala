import scala.math.BigInt;

object Main {
  def main(args: Array[String]) : Unit = {
    if (args.length > 0) {
      var input:Int = args(0).toInt
      println(specialMath(input))
    }
  }

  // This one fails due to stack overflow at high numbers, because the function calls are stored on the stack until all recursvive calls are complete
  def specialMathRecursive(n:Int) : Int = {
    if (n < 2) n else n + specialMathRecursive(n - 1) + specialMathRecursive(n - 2)
  }

  // This one uses tail recursion to avoid keeping too many function calls on the stack
  def specialMath(n:Int): BigInt = {
    def specialMathTailRecursive(current:Int, previous:BigInt, twoBack:BigInt) : BigInt = {
      if (current > n) previous else specialMathTailRecursive(current + 1, current + previous + twoBack, previous)
    }

    // Initialize
    if (n < 2) n else specialMathTailRecursive(2, 1, 0)
  }
}
