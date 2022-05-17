using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15052022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //создаем объект класса
            //Приводим к типу график
            Graphics g = e.Graphics;
            //
            Pen pn = new Pen(Brushes.Red, 5);//цвет , ширина
            //стиль линии Pen
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawEllipse(pn,50,100,170,40);
            g.Dispose();
        }
    }
}
