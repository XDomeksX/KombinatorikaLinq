using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KombinatorikaLinq
{
	public class Program
	{
		public static void Main()
		{
            int[] oneToNine = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query =
                from i1 in oneToNine
                from i2 in oneToNine
                where i2 != i1
                   && (i1 * 10 + i2) % 2 == 0
                from i3 in oneToNine
                where i3 != i2 && i3 != i1
                   && (i1 * 100 + i2 * 10 + i3) % 3 == 0
                from i4 in oneToNine
                where i4 != i3 && i4 != i2 && i4 != i1
                   && (i1 * 1000 + i2 * 100 + i3 * 10 + i4) % 4 == 0
                from i5 in oneToNine
                where i5 != i4 && i5 != i3 && i5 != i2 && i5 != i1
                   && (i1 * 10000 + i2 * 1000 + i3 * 100 + i4 * 10 + i5) % 5 == 0
                from i6 in oneToNine
                where i6 != i5 && i6 != i4 && i6 != i3 && i6 != i2 && i6 != i1
                   && (i1 * 100000 + i2 * 10000 + i3 * 1000 + i4 * 100 + i5 * 10 + i6) % 6 == 0
                from i7 in oneToNine
                where i7 != i6 && i7 != i5 && i7 != i4 && i7 != i3 && i7 != i2 && i7 != i1
                   && (i1 * 1000000 + i2 * 100000 + i3 * 10000 + i4 * 1000 + i5 * 100 + i6 * 10 + i7) % 7 == 0
                from i8 in oneToNine
                where i8 != i7 && i8 != i6 && i8 != i5 && i8 != i4 && i8 != i3 && i8 != i2 && i8 != i1
                   && (i1 * 10000000 + i2 * 1000000 + i3 * 100000 + i4 * 10000 +
                       i5 * 1000 + i6 * 100 + i7 * 10 + i8) % 8 == 0
                from i9 in oneToNine
                where i9 != i8 && i9 != i7 && i9 != i6 && i9 != i5 && i9 != i4 && i9 != i3 && i9 != i2 && i9 != i1
                let number = i1 * 100000000 +
                             i2 * 10000000 +
                             i3 * 1000000 +
                             i4 * 100000 +
                             i5 * 10000 +
                             i6 * 1000 +
                             i7 * 100 +
                             i8 * 10 +
                             i9 * 1
                where number % 9 == 0
                select number;

            foreach (var s in query)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}