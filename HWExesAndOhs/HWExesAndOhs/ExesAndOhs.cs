using System.Linq;

namespace HWExesAndOhs
{
    public class ExesAndOhs
    {
        public static bool Xo(string xo)
        {
            var xAmount = 0;
            var oAmount = 0;

            if (!string.IsNullOrEmpty(xo))
            {
                xAmount = xo.ToLower().Count(x => x == 'x');
                oAmount = xo.ToLower().Count(x => x == 'o');
            }

            return xAmount == oAmount;
        }
    }
}