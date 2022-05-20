using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp15052022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //1
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    //1.1создаем объект класса графикс
        //    //Приводим к типу график
        //    Graphics g = e.Graphics;
        //    //1.2. цвет задаемчерез brush, цвет который хотим, ширина
        //    Pen pn = new Pen(Brushes.Red, 5);//цвет , ширина
        //    //1.3.свойство Dashstyle, стиль линии Pen, пунктирная линия
        //    pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        //    //1.4. рисуем эллипс, рисовать draw чего либо, задать координаты
        //    //4 координаты,X и Н-откуда, и до чего
        //    g.DrawEllipse(pn, 50, 100, 170, 40);
        //    //1.4. очищение паямти от динамически созданных мотивов
        //    g.Dispose();
        //}

        //2 заливки объектов
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    //для него мы хотим заливать цветом
        //    //абстрактный класс brush, у него есть потомки
        //    //дописываем библиотеку, 0.0f-точка, true-угол преобразования

        //    Graphics g = e.Graphics;
        //    Rectangle rect1 = new Rectangle(20, 20, 200, 40);
        //    LinearGradientBrush lbr = new LinearGradientBrush(rect1, Color.Green, Color.Yellow, 0.0f, true);
        //    g.FillRectangle(lbr, rect1);

        //    //хэтчбраш сплошная заливка узором
        //    Rectangle rect2 = new Rectangle(20, 80, 200, 40);
        //    HatchBrush hbr = new HatchBrush(HatchStyle.Cross, Color.Blue);
        //    g.FillRectangle(hbr, rect2);

        //    ////текстур браш
        //    Rectangle rect3 = new Rectangle(20, 140, 200, 50);
        //    TextureBrush txBr = new TextureBrush(new Bitmap("sky.bmp"));
        //    g.FillRectangle(txBr, rect3);

        //    g.Dispose();
        //}

        //3 заливка картинки на всю форму
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle rect = this.ClientRectangle;
        //    Image im = new Bitmap("sky.bmp");
        //    g.DrawImage(im, rect);
        //    g.Dispose();
        //    //
        //}

        //4
        //List<Point> points = new List<Point>();
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    foreach (Point item in points)
        //    {
        //        g.FillRectangle(Brushes.Green,item.X,item.Y,15f,15f);
        //        // как рисовать

        //    }

        //}
        //private void Form2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    points.Add(new Point(e.X, e.Y));
        //    // Метод прорисовки
        //    Invalidate();
        //}

        //5
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int x = 23;
        //    int y = 33;
        //    int height = 60;
        //    int width = 60;
        //    Pen pn = new Pen(Brushes.Red, 4);
        //    Point pt = new Point(10, 10);
        //    Size sz = new Size(160, 160);
        //    Rectangle rect1 = new Rectangle(pt, sz);
        //    Rectangle rect2 = new Rectangle(x,y,width,height);
        //    g.FillRectangle(Brushes.Black, rect1);
        //    g.DrawEllipse(pn, rect2);
        //    g.Dispose();
        //}

        //6
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int x = 20;
        //    int y = 30;
        //    int height = 60;
        //    int width = 60;
        //    Point pt = new Point(10, 10);
        //    Size sz = new Size(160, 160);
        //    Rectangle rect1 = new Rectangle(pt, sz);
        //    Rectangle rect2 = new Rectangle(x, y, width, height);
        //    g.FillRectangle(Brushes.Black, rect1);
        //    g.DrawRectangle(new Pen(Brushes.Red,2), rect2);
        //    g.Dispose();
        //}

        //7 прорисовка линии
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    //функция сдвига начала координат
        //    g.TranslateTransform(10, 50);
        //    Point A = new Point(0, 0);
        //    Point B = new Point(120, 120);
        //    g.DrawLine(new Pen(Brushes.Blue, 3), A, B);
        //}

        //8 прорисовка текст рисуем текст
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Font f = new Font("Verdana", 14, FontStyle.Bold | FontStyle.Italic);
        //    g.DrawString("Hello Font",f,Brushes.Blue,30,55);

        //}
    }
}
