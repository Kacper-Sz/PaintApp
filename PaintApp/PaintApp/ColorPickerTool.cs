using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class ColorPickerTool : ITool
    {
        private ToolManager tool_manager;

        // klasy to typy referencyjne
        public ColorPickerTool(ToolManager manager)
        {
            tool_manager = manager;
        }
        public void ToolMouseDown(Point point, Graphics graphics, Bitmap bitmap)
        {
            Color picked_color = bitmap.GetPixel(point.X, point.Y);
            tool_manager.color_tool = picked_color;
        }
        public void ToolMouseMove(Point point, Graphics graphics)
        {

        }
        public void ToolMouseUp(Point point, Graphics graphics)
        {

        }
        public void ToolPaint(Graphics graphics)
        {

        }
    }
}
