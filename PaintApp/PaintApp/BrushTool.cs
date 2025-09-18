using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class BrushTool : ITool
    {

        bool is_painting = false;
        //Point start_p;
        Point end_p;

        Pen pen;


        public BrushTool(int size, Color color)
        {
            pen = new Pen(color, size);
            // daje zaokraglone konce linii przez co nei sa takie ostre
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }

        public void ToolMouseDown(Point point, Graphics graphics, Bitmap bitmap)
        {
            // start_p = point;
            end_p = point;
            is_painting = true;

            // przy pojedynczym kliknieciu
            // bedzie kropka / od kropki zacznie sie linia

            float half_size = pen.Width / 2;
            using var brush = new SolidBrush(pen.Color);
            graphics.FillEllipse(brush, point.X - half_size, point.Y - half_size, pen.Width, pen.Width);
            
        }

        public void ToolMouseMove(Point point, Graphics graphics)
        {
            if(is_painting)
            {
                graphics.DrawLine(pen, end_p, point);
                end_p = point;
            }
        }

        public void ToolMouseUp(Point point, Graphics graphics)
        {
            is_painting = false;
        }

        // tutaj niepotrzbene ale jest w interfejsie
        public void ToolPaint(Graphics graphics)
        {

        }

    }
}
