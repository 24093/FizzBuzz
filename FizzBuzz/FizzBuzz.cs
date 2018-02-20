using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FizzBuzzUnitTests")]

namespace FizzBuzz
{
    internal static class FizzBuzz
    {
        public static IEnumerable<Line> GenerateLines(IEnumerable<int> numbers, ICollection<(int divisor, string replacement)> dict)
        {
            foreach (var number in numbers)
            {
                var hits = dict.Where(d => number % d.divisor == 0).OrderBy(d => d.divisor).Select(d => d.replacement).ToArray();
                yield return new Line(number, hits.Any() ? string.Join(string.Empty, hits) : null);
            }
        }
    }
}