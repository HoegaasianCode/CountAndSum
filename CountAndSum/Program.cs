using System;

namespace CountAndSum
{
    class Program
    {
        // https://edabit.com/challenge/SXeEZPxDM9Y5HzLvw
        // SOLVED

        static void Main(string[] args)
        {
            var integer = new Calc(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -10, -15 });
            var x = integer.CalcSum();
            foreach (var n in x) Console.WriteLine(n);
        }
    }
}
