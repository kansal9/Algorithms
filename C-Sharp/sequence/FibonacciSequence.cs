using System.Collections.Generic;
using System.Numerics;

namespace Algorithms.Sequences
{
    /// <summary>
    /// <para>
    ///     Fibonacci sequence.
    /// </para>
    /// <para>
    ///     Wikipedia: https://wikipedia.org/wiki/Fibonacci_number.
    /// </para>
    /// </summary>
    public class FibonacciSequence : ISequence
    {
        /// <summary>
        /// Gets Fibonacci sequence.
        /// </summary>
        public IEnumerable<BigInteger> Sequence
        {
            get
            {
                yield return 0;
                yield return 1;
                BigInteger previous = 0;
                BigInteger current = 1;
                while (true)
                {
                    var next = previous + current;
                    previous = current;
                    current = next;
                    yield return next;
                }
            }
        }
    }
}
