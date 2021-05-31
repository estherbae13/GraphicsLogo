using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Ikea";

            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Goldenrod);
            SolidBrush drawBrush2 = new SolidBrush(Color.DarkBlue);
            Font drawFont = new Font("Impact", 80, FontStyle.Bold);
            Font drawFont2 = new Font("Arial", 10, FontStyle.Regular);

            g.Clear(Color.DarkBlue);

            g.FillEllipse(drawBrush, 15, 10, 490, 190);

            g.DrawString("I  K  E  A", drawFont, drawBrush2, 85, 45);

            g.TranslateTransform(400, 185);
            g.RotateTransform(350);
            g.DrawString("E", drawFont2, drawBrush, 0, 0);
            g.ResetTransform();

            g.TranslateTransform(410, 184);
            g.RotateTransform(345);
            g.DrawString("S", drawFont2, drawBrush, 0, 0);
            g.ResetTransform();

            g.TranslateTransform(420, 182);
            g.RotateTransform(345);
            g.DrawString("T", drawFont2, drawBrush, 0, 0);
            g.ResetTransform();

            g.TranslateTransform(430, 179);
            g.RotateTransform(343);
            g.DrawString("H", drawFont2, drawBrush, 0, 0);
            g.ResetTransform();

            g.TranslateTransform(440, 176);
            g.RotateTransform(340);
            g.DrawString("E", drawFont2, drawBrush, 0, 0);
            g.ResetTransform();

            g.TranslateTransform(450, 173);
            g.RotateTransform(335);
            g.DrawString("R", drawFont2, drawBrush, 0, 0);
            g.ResetTransform();
        }
    }
}
