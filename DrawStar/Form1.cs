using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Star : Form
    {
        public Star()

        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            float x = Convert.ToSingle(xBox.Text);
            float y = Convert.ToSingle(yBox.Text);
            float size =  Convert.ToSingle(sizeBox.Text);
            Pen starPen = new Pen(Color.Yellow);
            DrawStar(starPen, x, y, size);
        }

        public void DrawStar(Pen pen, float x, float y, float size)
        {
            float scale = size / 90;
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(pen, 0 *scale + x, 35 * scale + y, 35 * scale + x, 35 * scale + y);
            formGraphics.DrawLine(pen, 35 * scale + x, 35 * scale + y, 45 * scale + x, 0 * scale + y);
            formGraphics.DrawLine(pen, 45 * scale + x, 0 * scale + y, 55 * scale + x, 35 * scale + y);
            formGraphics.DrawLine(pen, 55 * scale + x, 35 * scale + y, 90 * scale + x, 35 * scale + y);
            formGraphics.DrawLine(pen, 90 * scale + x, 35 * scale + y, 60 * scale + x, 55 * scale + y);
            formGraphics.DrawLine(pen, 60 * scale + x, 55 * scale + y, 70 * scale + x, 85 * scale + y);
            formGraphics.DrawLine(pen, 70 * scale + x, 85 * scale + y, 45 * scale + x, 65 * scale + y);
            formGraphics.DrawLine(pen, 45 * scale + x, 65 * scale + y, 17 * scale + x, 85 * scale + y);
            formGraphics.DrawLine(pen, 17 * scale + x, 85 * scale + y, 30 * scale + x, 55 * scale + y);
            formGraphics.DrawLine(pen, 30 * scale + x, 55 * scale + y, 0 * scale + x, 35 * scale + y);
        }
    } 
}
