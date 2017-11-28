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
    public partial class DrawStar : Form
    {
        public DrawStar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen starPen = new Pen(Color.Yellow);
        }
    }

    public void DrawStar(int x, int y, int Size)
    {
        
    }
    
}
