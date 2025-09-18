using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{   
    internal class TriangleTool : ITool
    {
        bool is_painting = false;
        Point start_p, end_p;

        Pen pen;

        public TriangleTool(int size, Color color)
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
            var fig = Figure();
            graphics.DrawPolygon(pen, fig);
        }

        public void ToolPaint(Graphics graphics)
        {
            if (is_painting)
            {
                var fig = Figure();
                graphics.DrawPolygon(pen, fig);
            }
        }
        private Point [] Figure()
        { 
            int left_x = Math.Min(start_p.X, end_p.X);
            int up_y = Math.Min(start_p.Y, end_p.Y);
            int right_x = Math.Max(start_p.X, end_p.X);
            int down_y = Math.Max(start_p.Y, end_p.Y);

            Point top = new Point((left_x + right_x) / 2, up_y);
            Point left = new Point(left_x, down_y);
            Point right = new Point(right_x, down_y);

            Point[] fig = { top, right, left };

            return fig;
        }
    }
}
