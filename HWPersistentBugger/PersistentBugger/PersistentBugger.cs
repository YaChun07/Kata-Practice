namespace PersistentBugger
{
    public class PersistentBugger
    {
        public static int Persistence(long n)
        {
            if (n.ToString().Length <= 1)
            {
                return 0;
            }
            return 1 + Persistence(MultiplyDigits(n));
        }

        private static int MultiplyDigits(long num, int total = 1)
        {
            for (var i = 0; i < num.ToString().Length; i++)
            {
                total *= (int)char.GetNumericValue(num.ToString()[i]);
            }
            return total;
        }
    }
}