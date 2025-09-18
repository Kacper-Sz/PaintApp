using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class ToolManager
    {
        // cale info o aktualnych narzedziach

        // obecnie wybrane narzedzie
        public ITool current_tool
        {
            get;
            set;
        }

        // obecna nazwa narzedzia (enum)
        public Tools name_tool
        {
            get;
            set;
        }

        // obecny kolor
        public Color color_tool
        {
            get;
            set;
        }

        // obecny rozmiar
        public int size_tool
        {
            get;
            set;
        }

        


        public ToolManager(Tools name, Color color, int size)
        {
            // domyslnie jest pedzel
            //name_tool = Tools.Brush;
            name_tool = name;

            // domyslny kolor bedzie czarny - taki jak na wyswietlaczu koloru
            //color_tool = Color.Black;
            color_tool = color;

            // domyslny rozmiar bedzie 3
            //size_tool = 3;
            size_tool = size;

            // obecne narzedzie
            //current_tool = new BrushTool(size_tool, color_tool);
            Update();
            
        }

        public void Update()
        {
            
            // zmiana narzedzia na odpowiedni interfejs
            switch (name_tool)
            {
                case Tools.Brush:
                    current_tool = new BrushTool(size_tool, color_tool);
                    break;
                case Tools.Eraser:
                    current_tool = new BrushTool(size_tool, Color.White);
                    break;
                case Tools.Fill:
                    current_tool = new FillTool(color_tool);
                    break;
                case Tools.Text:
                    current_tool = new TextTool(color_tool, size_tool);
                    break;
                case Tools.ColorPicker:
                    current_tool = new ColorPickerTool(this);
                    break;
                case Tools.Line:
                    current_tool = new LineTool(size_tool, color_tool);
                    break;
                case Tools.Rectangle:
                    current_tool = new RectangleTool(size_tool, color_tool);
                    break;
                case Tools.Ellipse:
                    current_tool = new EllipseTool(size_tool, color_tool);
                    break;
                case Tools.Triangle:
                    current_tool = new TriangleTool(size_tool, color_tool);
                    break;
                default:
                    MessageBox.Show("blad");
                    break;
            }
        }


    }
}
