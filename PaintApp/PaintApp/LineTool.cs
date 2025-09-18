using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class LineTool : ITool
    {
        bool is_painting = false;
        Point start_p, end_p;

        Pen pen;

        public LineTool(int size, Color color)
        {
            pen = new Pen(color, size);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }


        public void ToolMouseDown(Point point, Graphics graphics, Bitmap bitmap)
        {
            start_p = point;
            end_p = point;
            is_painting = true;
        }

        public void ToolMouseMove(Point point, Graphics graphics)
        {
            if (is_painting)
            {
                end_p = point;
            }
        }

        public void ToolMouseUp(Point point, Graphics graphics)
        {
            is_painting = false;
            end_p = point;
            graphics.DrawLine(pen, start_p, end_p);
        }

        public void ToolPaint(Graphics graphics)
        {
            if (is_painting)
            {
                graphics.DrawLine(pen, start_p, end_p);
            }
        }
    }
}
