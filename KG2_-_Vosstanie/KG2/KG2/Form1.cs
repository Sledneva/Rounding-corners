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

namespace KG2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawRect dR = new drawRect(g, textLength, textWidth);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            drawAngles dA = new drawAngles(g, textRadius, textLength, textWidth);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }
    }
}
