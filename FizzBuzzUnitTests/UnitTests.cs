using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            var results = new[]
            {
                (1, "1"),
                (2, "2"),
                (3, "Fizz"),
                (4, "4"),
                (5, "Buzz"),
                (6, "Fizz"),
                (7, "7"),
                (8, "8"),
                (9, "Fizz"),
                (10, "Buzz"),
                (11, "11"),
                (12, "Fizz"),
                (13, "13"),
                (14, "14"),
                (15, "FizzBuzz"),
            };

            var numbers = results.Select(r => r.Item1);
            var dict = new[]
            {
                (3, "Fizz"),
                (5, "Buzz")
            };

            var lines = FizzBuzz.FizzBuzz.GenerateLines(numbers, dict).ToArray();

            for (var i = 0; i < results.Length; ++i)
            {
                Assert.AreEqual(results[i].Item2, lines[i].Result);
            }
        }
    }
}
