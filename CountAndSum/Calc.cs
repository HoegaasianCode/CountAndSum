
namespace CountAndSum
{
    public class Calc
    {
        private readonly int[] _integers;

        public Calc(int[] integers)
        {
            _integers = integers;
        }

        public int[] CalcSum()
        {
            int x = 0;
            int y = 0;
            foreach(var n in _integers)
            {
                if (n > 0)
                {
                    x += 1;
                }
                else
                {
                    y -= n;
                }
            }

            return new int[] { x, y };
        }
    }
}
