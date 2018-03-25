namespace Udemy
{
    public class Util
    {
        #region Métodos

        public static int MenorDeTres(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            } else if (b < c)
            {
                return b;
            } else
            {
                return c;
            }
        }

        #endregion
    }
}
