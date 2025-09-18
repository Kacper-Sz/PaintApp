namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            PANEL_TABLICY = new TableLayoutPanel();
            PANEL_RYSOWANIE = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            FILL_BTN = new Button();
            BRUSH_BTN = new Button();
            TEXT_BTN = new Button();
            ERASER_BTN = new Button();
            COLOR_PICKER_BTN = new Button();
            CLEAR_BTN = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            ELLIPSE_BTN = new Button();
            RECTANGLE_BTN = new Button();
            LINE_BTN = new Button();
            TRIANGLE_BTN = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            COLORS_tableLayoutPanel = new TableLayoutPanel();
            COLOR_BLACK_BTN = new Button();
            COLOR_RED_BTN = new Button();
            COLOR_GREEN_BTN = new Button();
            COLOR_GRAY_BTN = new Button();
            COLOR_ORANGE_BTN = new Button();
            COLOR_BLUE_BTN = new Button();
            COLOR_WHITE_BTN = new Button();
            COLOR_YELLOW_BTN = new Button();
            COLOR_PINK_BTN = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            COLORS_BTN = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            CURRENT_PEN_COLOR = new Panel();
            groupBox6 = new GroupBox();
            SIZE_CHANGER = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            PANEL_TABLICY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PANEL_RYSOWANIE).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            COLORS_tableLayoutPanel.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SIZE_CHANGER).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PANEL_TABLICY, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(852, 505);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PANEL_TABLICY
            // 
            PANEL_TABLICY.ColumnCount = 3;
            PANEL_TABLICY.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PANEL_TABLICY.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            PANEL_TABLICY.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PANEL_TABLICY.Controls.Add(PANEL_RYSOWANIE, 1, 0);
            PANEL_TABLICY.Dock = DockStyle.Fill;
            PANEL_TABLICY.Location = new Point(3, 129);
            PANEL_TABLICY.Name = "PANEL_TABLICY";
            PANEL_TABLICY.RowCount = 1;
            PANEL_TABLICY.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PANEL_TABLICY.Size = new Size(846, 373);
            PANEL_TABLICY.TabIndex = 0;
            // 
            // PANEL_RYSOWANIE
            // 
            PANEL_RYSOWANIE.Dock = DockStyle.Fill;
            PANEL_RYSOWANIE.Location = new Point(87, 3);
            PANEL_RYSOWANIE.Name = "PANEL_RYSOWANIE";
            PANEL_RYSOWANIE.Size = new Size(670, 367);
            PANEL_RYSOWANIE.TabIndex = 0;
            PANEL_RYSOWANIE.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel3.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel3.Controls.Add(groupBox4, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(846, 120);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 114);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tools";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(FILL_BTN, 1, 0);
            tableLayoutPanel2.Controls.Add(BRUSH_BTN, 0, 0);
            tableLayoutPanel2.Controls.Add(TEXT_BTN, 2, 0);
            tableLayoutPanel2.Controls.Add(ERASER_BTN, 0, 1);
            tableLayoutPanel2.Controls.Add(COLOR_PICKER_BTN, 1, 1);
            tableLayoutPanel2.Controls.Add(CLEAR_BTN, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(199, 88);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FILL_BTN
            // 
            FILL_BTN.BackColor = Color.Transparent;
            FILL_BTN.BackgroundImage = Properties.Resources.fill;
            FILL_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            FILL_BTN.Cursor = Cursors.Hand;
            FILL_BTN.Dock = DockStyle.Fill;
            FILL_BTN.Location = new Point(69, 3);
            FILL_BTN.Name = "FILL_BTN";
            FILL_BTN.Size = new Size(60, 38);
            FILL_BTN.TabIndex = 1;
            FILL_BTN.UseVisualStyleBackColor = false;
            FILL_BTN.Click += FILL_BTN_Click;
            // 
            // BRUSH_BTN
            // 
            BRUSH_BTN.BackColor = Color.Transparent;
            BRUSH_BTN.BackgroundImage = Properties.Resources.brush;
            BRUSH_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            BRUSH_BTN.Cursor = Cursors.Hand;
            BRUSH_BTN.Dock = DockStyle.Fill;
            BRUSH_BTN.Location = new Point(3, 3);
            BRUSH_BTN.Name = "BRUSH_BTN";
            BRUSH_BTN.Size = new Size(60, 38);
            BRUSH_BTN.TabIndex = 0;
            BRUSH_BTN.UseVisualStyleBackColor = false;
            BRUSH_BTN.Click += BRUSH_BTN_Click;
            // 
            // TEXT_BTN
            // 
            TEXT_BTN.BackColor = Color.Transparent;
            TEXT_BTN.BackgroundImage = Properties.Resources.text;
            TEXT_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            TEXT_BTN.Cursor = Cursors.Hand;
            TEXT_BTN.Dock = DockStyle.Fill;
            TEXT_BTN.Location = new Point(135, 3);
            TEXT_BTN.Name = "TEXT_BTN";
            TEXT_BTN.Size = new Size(61, 38);
            TEXT_BTN.TabIndex = 2;
            TEXT_BTN.UseVisualStyleBackColor = false;
            TEXT_BTN.Click += TEXT_BTN_Click;
            // 
            // ERASER_BTN
            // 
            ERASER_BTN.BackColor = Color.Transparent;
            ERASER_BTN.BackgroundImage = Properties.Resources.eraser;
            ERASER_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            ERASER_BTN.Cursor = Cursors.Hand;
            ERASER_BTN.Dock = DockStyle.Fill;
            ERASER_BTN.Location = new Point(3, 47);
            ERASER_BTN.Name = "ERASER_BTN";
            ERASER_BTN.Size = new Size(60, 38);
            ERASER_BTN.TabIndex = 3;
            ERASER_BTN.UseVisualStyleBackColor = false;
            ERASER_BTN.Click += ERASER_BTN_Click;
            // 
            // COLOR_PICKER_BTN
            // 
            COLOR_PICKER_BTN.BackColor = Color.Transparent;
            COLOR_PICKER_BTN.BackgroundImage = Properties.Resources.pipette;
            COLOR_PICKER_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            COLOR_PICKER_BTN.Cursor = Cursors.Hand;
            COLOR_PICKER_BTN.Dock = DockStyle.Fill;
            COLOR_PICKER_BTN.Location = new Point(69, 47);
            COLOR_PICKER_BTN.Name = "COLOR_PICKER_BTN";
            COLOR_PICKER_BTN.Size = new Size(60, 38);
            COLOR_PICKER_BTN.TabIndex = 4;
            COLOR_PICKER_BTN.UseVisualStyleBackColor = false;
            COLOR_PICKER_BTN.Click += COLOR_PICKER_BTN_Click;
            // 
            // CLEAR_BTN
            // 
            CLEAR_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            CLEAR_BTN.Cursor = Cursors.Hand;
            CLEAR_BTN.Dock = DockStyle.Fill;
            CLEAR_BTN.Location = new Point(135, 47);
            CLEAR_BTN.Name = "CLEAR_BTN";
            CLEAR_BTN.Size = new Size(61, 38);
            CLEAR_BTN.TabIndex = 5;
            CLEAR_BTN.Text = "CLEAR";
            CLEAR_BTN.UseVisualStyleBackColor = true;
            CLEAR_BTN.Click += CLEAR_BTN_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(214, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(205, 114);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Shape";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(ELLIPSE_BTN, 2, 1);
            tableLayoutPanel4.Controls.Add(RECTANGLE_BTN, 1, 1);
            tableLayoutPanel4.Controls.Add(LINE_BTN, 0, 1);
            tableLayoutPanel4.Controls.Add(TRIANGLE_BTN, 3, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.Size = new Size(199, 88);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // ELLIPSE_BTN
            // 
            ELLIPSE_BTN.BackColor = Color.Transparent;
            ELLIPSE_BTN.BackgroundImage = Properties.Resources.ellipse;
            ELLIPSE_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            ELLIPSE_BTN.Cursor = Cursors.Hand;
            ELLIPSE_BTN.Dock = DockStyle.Fill;
            ELLIPSE_BTN.Location = new Point(101, 16);
            ELLIPSE_BTN.Name = "ELLIPSE_BTN";
            ELLIPSE_BTN.Size = new Size(43, 55);
            ELLIPSE_BTN.TabIndex = 2;
            ELLIPSE_BTN.UseVisualStyleBackColor = false;
            ELLIPSE_BTN.Click += ELLIPSE_BTN_Click;
            // 
            // RECTANGLE_BTN
            // 
            RECTANGLE_BTN.BackColor = Color.Transparent;
            RECTANGLE_BTN.BackgroundImage = Properties.Resources.rectangle;
            RECTANGLE_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            RECTANGLE_BTN.Cursor = Cursors.Hand;
            RECTANGLE_BTN.Dock = DockStyle.Fill;
            RECTANGLE_BTN.Location = new Point(52, 16);
            RECTANGLE_BTN.Name = "RECTANGLE_BTN";
            RECTANGLE_BTN.Size = new Size(43, 55);
            RECTANGLE_BTN.TabIndex = 1;
            RECTANGLE_BTN.UseVisualStyleBackColor = false;
            RECTANGLE_BTN.Click += RECTANGLE_BTN_Click;
            // 
            // LINE_BTN
            // 
            LINE_BTN.BackColor = Color.Transparent;
            LINE_BTN.BackgroundImage = Properties.Resources.line;
            LINE_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            LINE_BTN.Cursor = Cursors.Hand;
            LINE_BTN.Dock = DockStyle.Fill;
            LINE_BTN.Location = new Point(3, 16);
            LINE_BTN.Name = "LINE_BTN";
            LINE_BTN.Size = new Size(43, 55);
            LINE_BTN.TabIndex = 0;
            LINE_BTN.UseVisualStyleBackColor = false;
            LINE_BTN.Click += LINE_BTN_Click;
            // 
            // TRIANGLE_BTN
            // 
            TRIANGLE_BTN.BackColor = Color.Transparent;
            TRIANGLE_BTN.BackgroundImage = Properties.Resources.triangle;
            TRIANGLE_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            TRIANGLE_BTN.Cursor = Cursors.Hand;
            TRIANGLE_BTN.Dock = DockStyle.Fill;
            TRIANGLE_BTN.Location = new Point(150, 16);
            TRIANGLE_BTN.Name = "TRIANGLE_BTN";
            TRIANGLE_BTN.Size = new Size(46, 55);
            TRIANGLE_BTN.TabIndex = 3;
            TRIANGLE_BTN.UseVisualStyleBackColor = false;
            TRIANGLE_BTN.Click += TRIANGLE_BTN_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(425, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(205, 114);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Colors";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(COLORS_tableLayoutPanel, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(199, 88);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // COLORS_tableLayoutPanel
            // 
            COLORS_tableLayoutPanel.ColumnCount = 3;
            COLORS_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            COLORS_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            COLORS_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            COLORS_tableLayoutPanel.Controls.Add(COLOR_BLACK_BTN, 0, 0);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_RED_BTN, 1, 0);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_GREEN_BTN, 2, 0);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_GRAY_BTN, 0, 1);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_ORANGE_BTN, 1, 1);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_BLUE_BTN, 2, 1);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_WHITE_BTN, 0, 2);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_YELLOW_BTN, 1, 2);
            COLORS_tableLayoutPanel.Controls.Add(COLOR_PINK_BTN, 2, 2);
            COLORS_tableLayoutPanel.Dock = DockStyle.Fill;
            COLORS_tableLayoutPanel.Location = new Point(3, 3);
            COLORS_tableLayoutPanel.Name = "COLORS_tableLayoutPanel";
            COLORS_tableLayoutPanel.RowCount = 3;
            COLORS_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            COLORS_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            COLORS_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            COLORS_tableLayoutPanel.Size = new Size(143, 82);
            COLORS_tableLayoutPanel.TabIndex = 0;
            // 
            // COLOR_BLACK_BTN
            // 
            COLOR_BLACK_BTN.BackColor = Color.Black;
            COLOR_BLACK_BTN.Dock = DockStyle.Fill;
            COLOR_BLACK_BTN.FlatAppearance.BorderSize = 0;
            COLOR_BLACK_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_BLACK_BTN.Location = new Point(3, 3);
            COLOR_BLACK_BTN.Name = "COLOR_BLACK_BTN";
            COLOR_BLACK_BTN.Size = new Size(41, 21);
            COLOR_BLACK_BTN.TabIndex = 0;
            COLOR_BLACK_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_RED_BTN
            // 
            COLOR_RED_BTN.BackColor = Color.Red;
            COLOR_RED_BTN.Dock = DockStyle.Fill;
            COLOR_RED_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_RED_BTN.Location = new Point(50, 3);
            COLOR_RED_BTN.Name = "COLOR_RED_BTN";
            COLOR_RED_BTN.Size = new Size(41, 21);
            COLOR_RED_BTN.TabIndex = 1;
            COLOR_RED_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_GREEN_BTN
            // 
            COLOR_GREEN_BTN.BackColor = Color.Lime;
            COLOR_GREEN_BTN.Dock = DockStyle.Fill;
            COLOR_GREEN_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_GREEN_BTN.Location = new Point(97, 3);
            COLOR_GREEN_BTN.Name = "COLOR_GREEN_BTN";
            COLOR_GREEN_BTN.Size = new Size(43, 21);
            COLOR_GREEN_BTN.TabIndex = 2;
            COLOR_GREEN_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_GRAY_BTN
            // 
            COLOR_GRAY_BTN.BackColor = Color.Gray;
            COLOR_GRAY_BTN.Dock = DockStyle.Fill;
            COLOR_GRAY_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_GRAY_BTN.Location = new Point(3, 30);
            COLOR_GRAY_BTN.Name = "COLOR_GRAY_BTN";
            COLOR_GRAY_BTN.Size = new Size(41, 21);
            COLOR_GRAY_BTN.TabIndex = 3;
            COLOR_GRAY_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_ORANGE_BTN
            // 
            COLOR_ORANGE_BTN.BackColor = Color.Orange;
            COLOR_ORANGE_BTN.Dock = DockStyle.Fill;
            COLOR_ORANGE_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_ORANGE_BTN.Location = new Point(50, 30);
            COLOR_ORANGE_BTN.Name = "COLOR_ORANGE_BTN";
            COLOR_ORANGE_BTN.Size = new Size(41, 21);
            COLOR_ORANGE_BTN.TabIndex = 4;
            COLOR_ORANGE_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_BLUE_BTN
            // 
            COLOR_BLUE_BTN.BackColor = Color.DeepSkyBlue;
            COLOR_BLUE_BTN.Dock = DockStyle.Fill;
            COLOR_BLUE_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_BLUE_BTN.Location = new Point(97, 30);
            COLOR_BLUE_BTN.Name = "COLOR_BLUE_BTN";
            COLOR_BLUE_BTN.Size = new Size(43, 21);
            COLOR_BLUE_BTN.TabIndex = 5;
            COLOR_BLUE_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_WHITE_BTN
            // 
            COLOR_WHITE_BTN.BackColor = Color.White;
            COLOR_WHITE_BTN.Dock = DockStyle.Fill;
            COLOR_WHITE_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_WHITE_BTN.Location = new Point(3, 57);
            COLOR_WHITE_BTN.Name = "COLOR_WHITE_BTN";
            COLOR_WHITE_BTN.Size = new Size(41, 22);
            COLOR_WHITE_BTN.TabIndex = 6;
            COLOR_WHITE_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_YELLOW_BTN
            // 
            COLOR_YELLOW_BTN.BackColor = Color.Yellow;
            COLOR_YELLOW_BTN.Dock = DockStyle.Fill;
            COLOR_YELLOW_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_YELLOW_BTN.Location = new Point(50, 57);
            COLOR_YELLOW_BTN.Name = "COLOR_YELLOW_BTN";
            COLOR_YELLOW_BTN.Size = new Size(41, 22);
            COLOR_YELLOW_BTN.TabIndex = 7;
            COLOR_YELLOW_BTN.UseVisualStyleBackColor = false;
            // 
            // COLOR_PINK_BTN
            // 
            COLOR_PINK_BTN.BackColor = Color.Fuchsia;
            COLOR_PINK_BTN.Dock = DockStyle.Fill;
            COLOR_PINK_BTN.FlatStyle = FlatStyle.Flat;
            COLOR_PINK_BTN.Location = new Point(97, 57);
            COLOR_PINK_BTN.Name = "COLOR_PINK_BTN";
            COLOR_PINK_BTN.Size = new Size(43, 22);
            COLOR_PINK_BTN.TabIndex = 8;
            COLOR_PINK_BTN.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(COLORS_BTN, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(152, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Size = new Size(44, 82);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // COLORS_BTN
            // 
            COLORS_BTN.BackColor = Color.Transparent;
            COLORS_BTN.BackgroundImage = Properties.Resources.colors;
            COLORS_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            COLORS_BTN.Cursor = Cursors.Hand;
            COLORS_BTN.Dock = DockStyle.Fill;
            COLORS_BTN.FlatStyle = FlatStyle.Flat;
            COLORS_BTN.Location = new Point(3, 23);
            COLORS_BTN.Name = "COLORS_BTN";
            COLORS_BTN.Size = new Size(38, 35);
            COLORS_BTN.TabIndex = 0;
            COLORS_BTN.UseVisualStyleBackColor = false;
            COLORS_BTN.Click += COLORS_BTN_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel6);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(636, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(207, 114);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Info";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(groupBox5, 1, 0);
            tableLayoutPanel6.Controls.Add(groupBox6, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 23);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(201, 88);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(CURRENT_PEN_COLOR);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(103, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(95, 82);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Pen Color";
            // 
            // CURRENT_PEN_COLOR
            // 
            CURRENT_PEN_COLOR.BackColor = Color.Black;
            CURRENT_PEN_COLOR.Dock = DockStyle.Fill;
            CURRENT_PEN_COLOR.Location = new Point(3, 23);
            CURRENT_PEN_COLOR.Name = "CURRENT_PEN_COLOR";
            CURRENT_PEN_COLOR.Size = new Size(89, 56);
            CURRENT_PEN_COLOR.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(SIZE_CHANGER);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(94, 82);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Size";
            // 
            // SIZE_CHANGER
            // 
            SIZE_CHANGER.Dock = DockStyle.Fill;
            SIZE_CHANGER.Location = new Point(3, 23);
            SIZE_CHANGER.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SIZE_CHANGER.Name = "SIZE_CHANGER";
            SIZE_CHANGER.Size = new Size(88, 27);
            SIZE_CHANGER.TabIndex = 1;
            SIZE_CHANGER.Value = new decimal(new int[] { 3, 0, 0, 0 });
            SIZE_CHANGER.ValueChanged += SIZE_CHANGER_ValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(852, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(59, 24);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(58, 24);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 533);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "PaintApp";
            ResizeEnd += Form1_ResizeEnd;
            Resize += Form1_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            PANEL_TABLICY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PANEL_RYSOWANIE).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            COLORS_tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SIZE_CHANGER).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel PANEL_TABLICY;
        private PictureBox PANEL_RYSOWANIE;
        private Button FILL_BTN;
        private Button BRUSH_BTN;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button TEXT_BTN;
        private Button ERASER_BTN;
        private Button COLOR_PICKER_BTN;
        private Button CLEAR_BTN;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button LINE_BTN;
        private Button RECTANGLE_BTN;
        private Button ELLIPSE_BTN;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel COLORS_tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel8;
        private Button COLOR_BLACK_BTN;
        private Button COLOR_RED_BTN;
        private Button COLOR_GREEN_BTN;
        private Button COLOR_GRAY_BTN;
        private Button COLOR_ORANGE_BTN;
        private Button COLOR_BLUE_BTN;
        private Button COLOR_WHITE_BTN;
        private Button COLOR_YELLOW_BTN;
        private Button COLOR_PINK_BTN;
        private Button COLORS_BTN;
        private NumericUpDown SIZE_CHANGER;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Panel CURRENT_PEN_COLOR;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button TRIANGLE_BTN;
    }
}
