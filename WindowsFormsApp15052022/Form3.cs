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
    public partial class Form3 : Form
    {
        SolidBrush mybrush;
        Graphics mygraphics;
        bool isDrawing = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mybrush = new SolidBrush(panel_color.BackColor);
            mygraphics = panel1.CreateGraphics();
        }

        private void panel_color_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                panel_color.BackColor = colorDialog1.Color;
                mybrush.Color = colorDialog1.Color;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                mygraphics.FillEllipse(mybrush, e.X, e.Y,trackBar1.Value,trackBar1.Value);
            }
        }
    }
}
