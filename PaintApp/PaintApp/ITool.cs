using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal interface ITool
    {
        // bitmap jest potzrzebne tylko w mouse down 

        // reakcja na wcisniecie przycisku
        void ToolMouseDown(Point point, Graphics graphics, Bitmap bitmap);

        // reakcja na ruch
        void ToolMouseMove(Point point, Graphics graphics);

        // reakcja na puszczenie przycisku
        void ToolMouseUp(Point point, Graphics graphics);

        // tymczasowe rysowanie pokazujace
        // jak bedzie wygladal ksztalt
        void ToolPaint(Graphics graphics);

    }
}



