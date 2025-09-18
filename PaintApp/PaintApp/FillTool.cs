using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class FillTool : ITool
    {
        Color fill_color;
        public FillTool(Color color)
        {
            fill_color = color;
        }

        public void ToolMouseDown(Point point, Graphics graphics, Bitmap bitmap)
        {
            Color old_color = bitmap.GetPixel(point.X, point.Y);
            if (old_color != fill_color)
            {
                Fill(point, bitmap, old_color);
            }
        }

        void Fill(Point point, Bitmap bitmap, Color old_color)
        {
            // domyslnie wszystkie pola flase
            // tablica zeby zapisac co bylo odwiedzone
            bool[,] visited = new bool[bitmap.Width, bitmap.Height];
            // do przetworzenia
            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(point);

            while (pixels.Count > 0)
            {
                Point p = pixels.Dequeue();

                // czy poza polem bitmapy
                if (p.X < 0 || p.X >= bitmap.Width || p.Y < 0 || p.Y >= bitmap.Height)
                    continue;

                // czy byl odiwedzony
                if (visited[p.X, p.Y])
                    continue;

                // jak ma odpowiedni kolor
                if (bitmap.GetPixel(p.X, p.Y) != old_color)
                    continue;

                visited[p.X, p.Y] = true;
                bitmap.SetPixel(p.X, p.Y, fill_color);

                pixels.Enqueue(new Point(p.X + 1, p.Y)); // prawy
                pixels.Enqueue(new Point(p.X - 1, p.Y)); // lewy
                pixels.Enqueue(new Point(p.X, p.Y + 1)); // dol
                pixels.Enqueue(new Point(p.X, p.Y - 1)); // gora

            }
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
