using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///     Функциональность ПО.
        /// </summary>
        private decimal SDF;

        /// <summary>
        ///     Продуктивность команды.
        /// </summary>
        private decimal TP;

        /// <summary>
        ///     Управление командой.
        /// </summary>
        private decimal TMG;

        /// <summary>
        ///     Нагрузка и дедлайны.
        /// </summary>
        private decimal SPD;

        /// <summary>
        ///     Навыки програмистов.
        /// </summary>
        private decimal PS;

        // <summary>
        ///     Колличество проведенных тестов.
        /// </summary>
        private decimal QAT;

        // <summary>
        ///     Прогрманое обеспечение.
        /// </summary>
        private decimal SD;

        // <summary>
        ///     Колличество проведенных тестов.
        /// </summary>
        private decimal N=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!MainTimer.Enabled)
            {
                PS = PSNum.Value;
                TP = TPNUm.Value;
                SPD = SPDNum.Value;
                MainTimer.Start();
            }
            else
            {
                MainTimer.Stop();
                SDFGraf.Series["Software functionality"].Points.Clear();
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Calc();
            SDFGraf.Series["Software functionality"].Points.AddXY(N, SDF);
        }
        private void Calc()
        {
            N++;
            TMG = PS + SPD;
            SD= SD + TMG;
            QAT =QAT+SD/TP;
            SDF = QAT;   
        }

    }
}
