using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Pen drawPen = new Pen(Color.Red, 15);

        }

        public void DrawTriangle (Pen drawPen, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(drawPen, x1, y1, x2, y2);
            formGraphics.DrawLine(drawPen, x2, y2, x3, y3);
            formGraphics.DrawLine(drawPen, x3, y3, x1, y1);
        }
        
    }
}
