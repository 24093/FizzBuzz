using System.IO.MemoryMappedFiles;

namespace FizzBuzz
{
    internal class Line
    {
        public readonly int Number;
        public readonly string Replacement;

        public string Result => (Replacement ?? Number.ToString());

        public Line(int number, string replacement = null)
        {
            Number = number;
            Replacement = replacement;
        }

        public override string ToString()
        {
            return Number + " => " + Result;
        }
    }
}