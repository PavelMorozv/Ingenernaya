using System.Windows.Forms;

namespace PavelMorozov
{
    public static class PMath
    {
        public static int MinMove(int n, int minus, int k, int m)
        {
            int kolMove = 0;
            string text = "";
            if (n >= m && k >= 2 && minus >= 1 && m >= 0)
                while (n > m)
                {
                    if (n % k == 0 && n/k >= m ) 
                    { 
                        n = n / k;
                        text += (kolMove + 1) + ") " + (n * k) + " : " + k + " = " + n + ";\n";
                    } else
                    {
                        n = n - 1;
                        text += (kolMove + 1) + ") " + (n + minus) + " - " + minus + " = " + n + ";\n";
                    }

                    kolMove++;
                }

            else
            {
                return -1;
            }


            MessageBox.Show("Число шагов = " + kolMove + "\n" + text, "Подробное решение");
            return kolMove;
        }


    }
}
