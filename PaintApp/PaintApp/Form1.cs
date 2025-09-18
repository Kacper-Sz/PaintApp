using System.Drawing;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        // zmienne
        Bitmap bitmap
        {
            get;
            set;
        }
        Graphics graphics
        {
            get;
            set;
        }

        ToolManager tool_manager;
        HistoryManager history_manager;

        // okno do wyboru koloru
        ColorDialog color_dialog = new ColorDialog();


        public Form1()
        {
            InitializeComponent();
            StartPanel();
            StartColorBtn();
            this.MouseWheel += Form1_MouseWheel;
        }

        // przygotowanie panelu
        private void StartPanel()
        {
            bitmap = new Bitmap(PANEL_RYSOWANIE.Width, PANEL_RYSOWANIE.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);


            tool_manager = new ToolManager(Tools.Brush, CURRENT_PEN_COLOR.BackColor, (int)SIZE_CHANGER.Value);
            history_manager = new HistoryManager();

            PANEL_RYSOWANIE.Image = bitmap;

            // s to obiekt ktory wywoluje zdarzenie
            // e to argumenty zdarzenia - zawiera info o zdarzeniu
            PANEL_RYSOWANIE.MouseDown += (s, e) =>
            {
                if (tool_manager.name_tool != Tools.ColorPicker)
                {
                    history_manager.UpdateStatus(bitmap);
                }

                /*
                // gdyby mialo tylko raaz zapisuwac zmiane koloru
                if (tool_manager.name_tool == Tools.Fill)
                {
                    Color old_color = bitmap.GetPixel(e.X, e.Y);
                    Color fill_color = tool_manager.color_tool;

                    if (old_color != fill_color)
                    {
                        history_manager.UpdateStatus(bitmap);
                    }
                }
                */
                // MessageBox.Show(e.Button.ToString());

                tool_manager.current_tool.ToolMouseDown(e.Location, graphics, bitmap);

                if (tool_manager.name_tool == Tools.ColorPicker)
                {
                    CURRENT_PEN_COLOR.BackColor = tool_manager.color_tool;
                }

                // odswiezanie panelu
                PANEL_RYSOWANIE.Invalidate();

            };

            PANEL_RYSOWANIE.MouseMove += (s, e) =>
            {
                tool_manager.current_tool.ToolMouseMove(e.Location, graphics);
                PANEL_RYSOWANIE.Invalidate();
            };

            PANEL_RYSOWANIE.MouseUp += (s, e) =>
            {
                tool_manager.current_tool.ToolMouseUp(e.Location, graphics);
                PANEL_RYSOWANIE.Invalidate();
            };

            PANEL_RYSOWANIE.Paint += (s, e) =>
            {
                tool_manager.current_tool.ToolPaint(e.Graphics);
            };
        }

        // resize odswiezany caly czas
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                return;
            }


            if (WindowState == FormWindowState.Maximized)
            {
                ResizePanel(PANEL_RYSOWANIE.Width, PANEL_RYSOWANIE.Height);
                PANEL_RYSOWANIE.Image = bitmap;
                PANEL_RYSOWANIE.Invalidate();
            }
            else if (PANEL_RYSOWANIE.Width > bitmap.Width || PANEL_RYSOWANIE.Height > bitmap.Height)
            {
                Bitmap temp = new Bitmap(PANEL_RYSOWANIE.Width, PANEL_RYSOWANIE.Height);
                using (Graphics g = Graphics.FromImage(temp))
                {
                    g.Clear(Color.White);
                    g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
                }
                PANEL_RYSOWANIE.Image = temp;
            }
            else
            {
                // stara bitmapa
                PANEL_RYSOWANIE.Image = bitmap;
            }
        }

        // resize odswiezony na koniec
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            ResizePanel(PANEL_RYSOWANIE.Width, PANEL_RYSOWANIE.Height);
            history_manager.Clear();
            PANEL_RYSOWANIE.Image = bitmap;
            PANEL_RYSOWANIE.Invalidate();
        }

        // metoda resize panelu
        private void ResizePanel(int width, int height)
        {
            if (width <= 0 || height <= 0) return;

            Bitmap new_bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(new_bitmap))
            {
                g.Clear(Color.White);

                // rysowanie w punkcje 0,0
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            }

            // zwolnienie zasobow
            bitmap.Dispose();
            graphics.Dispose();

            // podmiana na nowe 
            bitmap = new_bitmap;
            graphics = Graphics.FromImage(bitmap);
        }


        // ustalenie rozmiaru
        private void SIZE_CHANGER_ValueChanged(object sender, EventArgs e)
        {
            tool_manager.size_tool = (int)SIZE_CHANGER.Value;
            tool_manager.Update();
        }

        // zmiana rozmiaru scrolem
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // delta kierunek scrola
            if (e.Delta > 0)
            {
                SIZE_CHANGER.Value = Math.Min(SIZE_CHANGER.Value + 1, 100);
            }
            else if (e.Delta < 0)
            {
                SIZE_CHANGER.Value = Math.Max(SIZE_CHANGER.Value - 1, 1);
            }
        }


        // paleta kolorow
        private void COLORS_BTN_Click(object sender, EventArgs e)
        {
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                tool_manager.color_tool = color_dialog.Color;
                CURRENT_PEN_COLOR.BackColor = color_dialog.Color;
                tool_manager.Update();
            }
        }

        // dziala kolorow
        private void StartColorBtn()
        {
            // robie liste przyciskow z panelu
            List<Button> colors_btn = new List<Button>();

            foreach (var el in COLORS_tableLayoutPanel.Controls)
            {
                if (el is Button)
                {
                    colors_btn.Add((Button)el);
                }
            }


            foreach (var el in colors_btn)
            {
                el.Click += (s, e) =>
                {
                    tool_manager.color_tool = el.BackColor;
                    CURRENT_PEN_COLOR.BackColor = el.BackColor;
                    tool_manager.Update();
                };
            }

        }





        // zmiana narzedzi
        private void BRUSH_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Brush;
            tool_manager.Update();
        }

        private void FILL_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Fill;
            tool_manager.Update();
        }

        private void TEXT_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Text;
            tool_manager.Update();
        }

        private void ERASER_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Eraser;
            tool_manager.Update();
        }

        private void COLOR_PICKER_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.ColorPicker;
            tool_manager.Update();
        }

        private void LINE_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Line;
            tool_manager.Update();
        }

        private void RECTANGLE_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Rectangle;
            tool_manager.Update();
        }

        private void ELLIPSE_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Ellipse;
            tool_manager.Update();
        }

        private void TRIANGLE_BTN_Click(object sender, EventArgs e)
        {
            tool_manager.name_tool = Tools.Triangle;
            tool_manager.Update();
        }
        //


        // czyszczenie obrazu
        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            history_manager.UpdateStatus(bitmap);
            graphics.Clear(Color.White);
            PANEL_RYSOWANIE.Invalidate();
        }

        // zapisanie obrazu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save";
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg";
            // autoamtycznie doda rozszerzenie
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(sfd.FileName);
                MessageBox.Show($"Zapisano plik.\n {sfd.FileName}");
            }
        }

        // otwieranie obrazu
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap load_bitmap = new Bitmap(ofd.FileName);

                bitmap.Dispose();
                bitmap = load_bitmap;

                graphics.Dispose();
                graphics = Graphics.FromImage(bitmap);

                ResizePanel(PANEL_RYSOWANIE.Width, PANEL_RYSOWANIE.Height);

                PANEL_RYSOWANIE.Image = bitmap;
                history_manager.Clear();
                PANEL_RYSOWANIE.Invalidate();
                MessageBox.Show($"Otwarto plik.\n {ofd.FileName}");
            }
        }

        // cofniecie akcji
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Dispose();
            bitmap = history_manager.Undo(bitmap);
            graphics = Graphics.FromImage(bitmap);
            PANEL_RYSOWANIE.Image = bitmap;
            PANEL_RYSOWANIE.Invalidate();
        }

        // powrot akcji
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Dispose();
            bitmap = history_manager.Redo((Bitmap)bitmap);
            graphics = Graphics.FromImage(bitmap);
            PANEL_RYSOWANIE.Image = bitmap;
            PANEL_RYSOWANIE.Invalidate();
        }

        
    }
}
