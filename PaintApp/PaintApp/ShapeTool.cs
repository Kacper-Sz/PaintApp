using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal abstract class ShapeTool : ITool
    {
        protected bool is_painting = false;
        protected Point start_p, end_p;

        protected Pen pen;

        public ShapeTool(int size, Color color)
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
            DrawShape(graphics, Figure());
        }

        public void ToolPaint(Graphics graphics)
        {
            if (is_painting)
            {
                DrawShape(graphics, Figure());
            }                
        }
        protected Rectangle Figure()
        {
            int x = Math.Min(start_p.X, end_p.X);
            int y = Math.Min(start_p.Y, end_p.Y);
            int width = Math.Abs(end_p.X - start_p.X);
            int height = Math.Abs(end_p.Y - start_p.Y);
            var fig = new Rectangle(x, y, width, height);
            return fig;
        }

        // abstrakcyjna metoda do nadpisania
        protected abstract void DrawShape(Graphics graphics, Rectangle fig);
    }
}
