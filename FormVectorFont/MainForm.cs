using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormEditFont;
using LogicLibrary;

namespace FormVectorFont
{
    public partial class MainForm : Form
    {
        Drawer Drawer { get; set; }
        private Image ImageBack { get; set; }  // фон - фото пользователя или созданный фон
        private bool Enter { get; set; }   // определяет вводятся ли символы сейчас 
        private StringBuilder MyText { get; set; }  // текст, введённый пользователем
        private bool flagMove = false;  //флаг перемещения надписи
        private int downX; // координаты надписи когда её начали перетаскивать 
        private int downY;
        private bool CursorMarker = false;

        public MainForm()
        {
            InitializeComponent();
            Drawer = new Drawer();
            Drawer.SizeY = (double) trackBarSizeY.Value;
            Drawer.SizeX = (double) trackBarSizeX.Value;
            Drawer.Position0 = new LogicLibrary.Point(0, 0);
            Drawer.Pen = new Pen(Color.Black, 1);
            colorDialogPen.Color = Color.Black;
            MyText = new StringBuilder("");
            Enter = false;
            openFileDialogAlphabet.FileName = "../../../Source/alphabet.txt";
            try
            {
                Drawer.CreateAlphabet(DataFile.OpenTablePaths(openFileDialogAlphabet.FileName));
                Drawer.SpecialSymbol = DataFile.OpenSymbol("../../../Source/Symbols/special.sym");
            }
            catch
            {
                MessageBox.Show("File alphabet not found");
                this.Close();
            }
            openFileDialogImage.Filter = "Bitmap files (*.bmp) | *.bmp | Image files (*.jpg) | *.jpg";
            saveFileDialogImage.Filter = "Bitmap files (*.bmp) | *.bmp | Image files (*.jpg) | *.jpg";
        }

        private void DrawerToPictureBox()
        {
            Bitmap temp = (Bitmap) Drawer.Canvas.Clone();
            temp.MakeTransparent(Drawer.BackColor);
            pictureBox.Image = temp;
        }

        private void PrintCaptionOnImageBack()
        {
            Graphics g = Graphics.FromImage(ImageBack);
            Bitmap temp = (Bitmap)Drawer.Canvas.Clone();
            temp.MakeTransparent(Drawer.BackColor);
            g.DrawImage(temp, 0, 0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                ImageBack = Bitmap.FromFile(openFileDialogImage.FileName);
                pictureBox.Visible = true;
                LoadImageBackToPictureBox();
            }
        }

        private void btnChangePenColor_Click(object sender, EventArgs e)
        {
            if (colorDialogPen.ShowDialog() == DialogResult.OK)
            {
                Drawer.Pen.Color = colorDialogPen.Color;
                Drawer.WriteString();
                DrawerToPictureBox();
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Drawer.Pen.Width = trackBarWidthPen.Value;
            Drawer.WriteString();
            DrawerToPictureBox();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                Drawer.WriteString();
                DrawerToPictureBox();
                PrintCaptionOnImageBack();
                ImageBack.Save(saveFileDialogImage.FileName);
                MyText.Clear();
                Drawer.WriteString();
                DrawerToPictureBox();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            int higthSymbol = (int)(Drawer.WidthSymbol * Drawer.SizeY);
            if (e.X >= Drawer.Position0.X && e.X <= Drawer.Position.X && e.Y <= Drawer.Position0.Y &&
                e.Y >= Drawer.Position0.Y + higthSymbol /*&& pictureBox.Cursor == Cursors.Default*/)
            {
                this.Cursor = Cursors.SizeAll;
            }
            else if (pictureBox.Cursor == Cursors.SizeAll)
            {
                pictureBox.Cursor = Cursors.Default;
            }
        }

     
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int higthSymbol = (int)(Drawer.WidthSymbol * Drawer.SizeY);
            if (e.X >= Drawer.Position0.X && e.X <= Drawer.Position.X && e.Y >= Drawer.Position0.Y &&
                e.Y <= Drawer.Position0.Y + higthSymbol /*&& pictureBox.Cursor == Cursors.Default*/)
            {
                downX = e.X;
                downY = e.Y;
                flagMove = true;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (flagMove)
            {
                flagMove = false;
                Drawer.Position0 = new LogicLibrary.Point(Drawer.Position0.X + e.X - downX, Drawer.Position0.Y + e.Y - downY);
                Drawer.WriteString();
                DrawerToPictureBox();
            }
        }

        private void editSymbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFont form = new EditFont();
            form.Show();
        }

        private void addAlphabetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogAlphabet.ShowDialog() == DialogResult.OK)
            {
                Drawer.CreateAlphabet(DataFile.OpenTablePaths(openFileDialogAlphabet.FileName));
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Enter)
            {
                char symbol = e.KeyChar;
                if (symbol == '\b')
                {
                    if(MyText.Length>0)
                        MyText.Remove(MyText.Length - 1,1);
                }
                else
                {
                    MyText.Append(symbol.ToString());
                }
                Drawer.MyString = MyText.ToString();
                Drawer.DrawCursor();
                DrawerToPictureBox();
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Enter)
            {
                Enter = true;
                Drawer.Position0.X = e.Location.X;  
                Drawer.Position0.Y = e.Location.Y;                                  
                timer.Enabled = true;
                label1.Focus();
            }
        }

        private void trackBarSizeX_ValueChanged(object sender, EventArgs e)
        {
            Drawer.SizeX = (double)trackBarSizeX.Value / 10;
            Drawer.WriteString();
            DrawerToPictureBox();
        }

        private void trackBarSizeY_ValueChanged(object sender, EventArgs e)
        {
            Drawer.SizeY = (double) trackBarSizeY.Value / 10;
            Drawer.WriteString();
            DrawerToPictureBox();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Drawer.WriteString();
            if (CursorMarker)
                Drawer.DrawCursor();
            DrawerToPictureBox();
            CursorMarker = !CursorMarker;
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            Drawer.Canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            Drawer.WriteString();
            DrawerToPictureBox();
        }

        private void LoadImageBackToPictureBox()
        {
            pictureBox.Width = ImageBack.Width;
            pictureBox.Height = ImageBack.Height;
            pictureBox.BackgroundImage = ImageBack;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Drawer.WriteString();
            PrintCaptionOnImageBack();
            MyText.Clear();
            Drawer.MyString = MyText.ToString();
            Enter = false;
            
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateNewFile form = new FormCreateNewFile();
            form.Show();
            form.Closed += (object sender2, EventArgs e2) =>
            {
                if (form.ImageBack != null)
                {
                    ImageBack = form.ImageBack;
                    pictureBox.Visible = true;
                    LoadImageBackToPictureBox();
                    Drawer.Canvas = new Bitmap(pictureBox.Width,pictureBox.Height); 
                }
            };
        }
    }
}

