using System.Windows.Forms;

namespace PavelMorozov
{
    /// <summary>
    /// Клас с математическими действиями
    /// </summary>
    public static class PMath
    {
        /// <summary>
        /// Метод обределяющий минимальное количество дейтсвий для достижения цели
        /// </summary>
        /// <param name="n">Число от которого будут считаться действия (шаги) к цели "m" </param>
        /// <param name="minus">Действие вычитания. Обычно используется "1"</param>
        /// <param name="k">Действие деления. Может использоваться любое число, но не более число "n"</param>
        /// <param name="m">Число "цель" до которого необходимо выполнять действия вычитания и деления</param>
        /// <returns>При удачном выполнении программмы возвращает количество шагов и выдает MessageBox с подробным решением и ответом,
        /// При не удачном выполнении функция вернет значение "-1"</returns>
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
            else return -1;

            MessageBox.Show("Число шагов = " + kolMove + "\n" + text, "Подробное решение");
            return kolMove;
        }
    }
}