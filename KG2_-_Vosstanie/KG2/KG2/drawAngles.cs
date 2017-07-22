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
    class drawAngles
    {
        public drawAngles(Graphics g, TextBox textRadius, TextBox textWidth, TextBox textLength)
        {
            int radius = 0;
            int width = 0;
            int height = 0;
            g.Clear(System.Windows.Forms.Control.DefaultBackColor);
            try
            {
                radius = Convert.ToInt32(textRadius.Text);
                width = Convert.ToInt32(textWidth.Text);
                height = Convert.ToInt32(textLength.Text);
            }
            catch
            {
                MessageBox.Show("Введите длину, ширину и радиус!");
                return;
            }

                if (radius > (width + height) / 2)
            {
                MessageBox.Show("Введите меньший радиус");
            }
            
            
            GraphicsPath gp = new GraphicsPath();
            int x = 50;
            int y = 50;

            gp.AddLine(x + radius, y, x + width - (radius * 2), y); // Line
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2)); // Line
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height); // Line
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90); // Corner
            gp.AddLine(x, y + height - (radius * 2), x, y + radius); // Line
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90); // Corner
            gp.CloseFigure();
            g.DrawPath(new Pen(Color.Black), gp);
            gp.Dispose();
            }
        
    }
}
