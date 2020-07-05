using PavelMorozov;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrakticheskayaRabota3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие на обработку кнопки "Вычислить"
        /// По нажатию на кнопу происходит выполнение функции "MinMove" из класса "PMath",
        /// отправляя в нее из:
        /// 1) UpDownN.Value - Число с которым производятся вычисления
        /// 2) UpDownNmin.Value - Вычитаемое число
        /// 3) UpDownK.Value - Число делитель
        /// 4) UpDownMin.Value - Число "Цель"
        /// И записывает ответ в свойство "Text" объекта "LabelOutPut".
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            LabelOutPut.Text = Convert.ToString(PMath.MinMove(Convert.ToInt32(UpDownN.Value), Convert.ToInt32(UpDownNmin.Value), Convert.ToInt32(UpDownK.Value), Convert.ToInt32(UpDownMin.Value)));
        }

        /// <summary>
        /// Ограничвчение на число "Цель"
        /// Ответ не может быть более числа с которым производится вычисления
        /// </summary>
        private void UpDownMin_ValueChanged(object sender, EventArgs e)
        {
            UpDownMin.Maximum = UpDownN.Value;
        }

        /// <summary>
        /// Ограничвчение на вычитаемое число
        /// Вычитаемое число не должно быть больше чем число с которым будут производиться вычисления
        /// </summary>
        private void UpDownNmin_ValueChanged(object sender, EventArgs e)
        {
            UpDownNmin.Maximum = UpDownN.Value;
        }

        /// <summary>
        /// Ограничения для числа делителя
        /// Число делитель не должно быть больше числа над которым производится вычисления,
        /// и не должно быть менее 2
        /// </summary>
        private void UpDownK_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownN.Value >= UpDownK.Minimum) UpDownK.Maximum = UpDownN.Value;
            else if (UpDownN.Value <= 2) UpDownK.Minimum = 2;
        }
    }
}
