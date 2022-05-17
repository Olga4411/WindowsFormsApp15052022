using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp15052022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Step = 1;

            for(int i=0;i<=progressBar1.Maximum;i++)
            {
                progressBar1.PerformStep();
                // Отображение изменения
                label1.Text = "Value="+progressBar1.Value.ToString();
                //Прорисовка графики
                Update();
                //задержка выполнения кода программы на 50 милисекунд thread-Поток
                Thread.Sleep(50);
            }
        }
    }
}
//PerformStep-указывает на какое значение
//Increment-Передавая ему в качестве параметра значение
//на который будет изменяться индикатор
//задержка на милисекунды на каждый шаг-цикл
