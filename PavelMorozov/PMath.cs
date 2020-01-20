namespace PavelMorozov
{
    public static class PMath
    {
        private static int MinMove(int n, int minus, int k)
        {
            int kolMove = 0;
            if (n >= 0 && k >= 2 && minus >= 1)
                while (n > 0)
                {
                    if (n % k == 0) n = n / k; else n = n - 1;
                    kolMove++;
                }
            else return -1;
            return kolMove;
        }
    }
}
