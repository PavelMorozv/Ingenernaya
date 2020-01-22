﻿using PavelMorozov;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelOutPut.Text = Convert.ToString(PMath.MinMove(Convert.ToInt32(UpDownN.Value), Convert.ToInt32(UpDownNmin.Value), Convert.ToInt32(UpDownK.Value), Convert.ToInt32(UpDownMin.Value)));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpDownMin_ValueChanged(object sender, EventArgs e)
        {
            UpDownMin.Maximum = UpDownN.Value;
        }

        private void UpDownNmin_ValueChanged(object sender, EventArgs e)
        {
            UpDownNmin.Maximum = UpDownN.Value;
        }

        private void UpDownK_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownN.Value >= UpDownK.Minimum) UpDownK.Maximum = UpDownN.Value;
            else if (UpDownN.Value <= 2) UpDownK.Minimum = 2;
        }
    }
}
