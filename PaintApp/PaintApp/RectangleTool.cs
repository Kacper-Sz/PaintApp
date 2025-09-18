using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class RectangleTool : ShapeTool
    {
        public RectangleTool(int size, Color color) : base(size, color)
        {

        }

        protected override void DrawShape(Graphics graphics, Rectangle fig)
        {
            graphics.DrawRectangle(pen, fig);
        }
    }
}
