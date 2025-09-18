using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class EllipseTool: ShapeTool
    {
        public EllipseTool(int size, Color color) : base(size, color)
        {

        }

        protected override void DrawShape(Graphics graphics, Rectangle fig)
        {
            graphics.DrawEllipse(pen, fig);
        }
    }
}
