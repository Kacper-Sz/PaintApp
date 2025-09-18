using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class TextTool : ITool
    {
        Color color;
        int size;

        FontDialog fd;

        public TextTool(Color color, int size)
        {
            this.color = color;
            this.size = size;
            fd = new FontDialog();
        }

        public void ToolMouseDown(Point point, Graphics graphics, Bitmap bitmap)
        {
            using (Form input_text_form = new Form())
            {
                input_text_form.Text = "Wpisz tekst";
                // rozciaganie okna
                input_text_form.FormBorderStyle = FormBorderStyle.FixedDialog;
                input_text_form.StartPosition = FormStartPosition.CenterParent;
                input_text_form.Width = bitmap.Width / 3;
                input_text_form.Height = bitmap.Height / 2;

                input_text_form.MaximizeBox = false;
                input_text_form.MinimizeBox = false;

                // pole do pisania
                TextBox text_box = new TextBox
                {
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", size * 2)
                };


                /*
                // zmiana rozmiaru
                NumericUpDown size_font_chang = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = 200,
                    Value = size * 3,
                    Dock = DockStyle.Top
                };
                size_font_chang.ValueChanged += (s, e) =>
                {
                    text_box.Font = new Font("Arial", (int)size_font_chang.Value);
                };

                */

                // ustawienia czcionki
                Button font_settings_btn = new Button
                {
                    Text = "Change settings",
                    Dock = DockStyle.Top,
                    Height = 35
                };
                font_settings_btn.Click += (s, e) =>
                {
                    fd.Font = text_box.Font;
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        text_box.Font = fd.Font;
                    }
                };

                // potwierdzenie
                Button ok_btn = new Button
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Dock = DockStyle.Bottom,
                    Height = 35
                };

                // dodanie elementow
                input_text_form.Controls.Add(text_box);
                //input_text_form.Controls.Add(size_font_chang);
                input_text_form.Controls.Add(font_settings_btn);
                input_text_form.Controls.Add(ok_btn);
                input_text_form.AcceptButton = ok_btn;

                if (input_text_form.ShowDialog() == DialogResult.OK)
                {
                    string text = text_box.Text;
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        using (Brush brush = new SolidBrush(color))
                        {
                            graphics.DrawString(text, text_box.Font, brush, point);
                        }
                    }
                }
            }
        }

        public void ToolMouseMove(Point point, Graphics graphics) { }
        public void ToolMouseUp(Point point, Graphics graphics) { }
        public void ToolPaint(Graphics graphics) { }
    }
}
