using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace KG2
{
    class drawRect
    {
        public drawRect(Graphics g, TextBox textLength, TextBox textWidth)
        {
            
            g.Clear(System.Windows.Forms.Control.DefaultBackColor);
            int a =0;
            int b=0;
            try
            {
                a = Convert.ToInt32(textLength.Text);
                b = Convert.ToInt32(textWidth.Text);
            }
            catch
            {
                MessageBox.Show("Введите длину и ширину!");
            }

            
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, 50, 50, a, b);
        }
    }
}
