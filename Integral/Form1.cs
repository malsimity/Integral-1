using Integral.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cbmMetod.SelectedIndex = 0;//Высвечивает на табло каким методом считаешь, если его не выбрал
        }

        private ICalculator GetCalculator()
        {
            if (_cbmMetod.SelectedItem == "Метод трапеции")
                return new TrapezoidCalc();
            return new RectangleCalculator();
        }
        private void Calculate()
        {
            chart1.Series["Series1"].Points.Clear();
            double a = Convert.ToDouble(_tbMIN.Text);
            double b = Convert.ToDouble(_tbMAX.Text);
            double result;
            int n = Convert.ToInt32(_nudN.Value);
            ICalculator calcul = GetCalculator();//Создаём переменную и присваемый ей выбранный класс
            Stopwatch t = new Stopwatch();
            TimeSpan stoptime;
            for (int i = 1; i < n + 1; i+=n/10)
            {
                t.Restart();
                result = calcul.Calculate(a, b, n, x => 7 * x - Math.Log(7 * x) + 8);
                t.Stop();
                stoptime = t.Elapsed;
                chart1.Series["Series1"].Points.AddXY(i, stoptime.TotalMilliseconds);
                _rtbResult.Text = $"Ответ: {result}";
            }
            
        }
        private void _btCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        
    }
}
