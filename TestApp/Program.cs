using Library;
using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the default comparer for this type
            var comparer = EqualityComparer<StructWithValue>.Default;

            // loop through the full ushort range.
            for (ushort i = ushort.MinValue; i <= ushort.MaxValue; i++)
            {
                var a = new StructWithValue(i);
                var b = new StructWithValue(i);

                if (comparer.Equals(a, b))
                    continue;

                // the value of 32768 will show this message and end the loop
                // every value > 32767 is affected...
                Console.WriteLine($"Problem start at {i}");
                break;
            }
        }
    }
}
