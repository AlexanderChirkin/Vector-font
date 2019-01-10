using System.Collections.Generic;
using System.Drawing;

namespace LogicLibrary
{ 
/// <summary>
/// Используется для рисования строки симолов на bitmap в определённом месте, определённым размером...  
/// </summary>
    public class Drawer
    {
        private Bitmap canvas;
        public Bitmap Canvas
        {
            get { return canvas; }
            set
            {
                canvas = value;
                Graphics = Graphics.FromImage(canvas);
                ClearCanvas();
            }
        }

        // точка, откуда начинается строка
        private Point position0;
        public Point Position0
        {
            get { return position0;}
            set
            {
                position0 = value;
                Position = (Point)position0.Clone();
            }
        }

        public Graphics Graphics { get; set; }

        public Dictionary<char, IDrawableObject> Alphabet { get; set; }

        public IDrawableObject SpecialSymbol { get; set; }  // специальный символ печатается, если пользователь ввёл такой символ, которогот нет в алфавите

        public Point Position { get;private set; } 

        public int WidthSymbol = 100; // моноширийный, при sizeX=1 ширина одного символа -100

        public Color BackColor { get;private set; } 

        private string myString;
        public string MyString
        {
            get { return myString; }
            set
            {
                myString = value;
                //myString = value.ToUpper();
            }
        }

        private double sizeX;
        public double SizeX
        {
            get { return sizeX; }
            set
            {
                sizeX = value;
            }
        }

        private double sizeY;
        public double SizeY
        {
            get { return sizeY;}
            set
            {
                sizeY = value;
            }
        }

        private Pen pen;
        public Pen Pen
        {
            get { return pen; }
            set
            {
                pen = value;
                BackColor = GetNegative(pen.Color);
                if (Graphics != null)
                    Graphics.Clear(BackColor);
            }
        }

        public void ClearCanvas()
        {
            Graphics.Clear(BackColor);
        }

        //используется для получения цвета фона чтобы цвет фона не совпадал с цветом шрифта 
        private Color GetNegative(Color color)
        {
            Color negative = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            return negative;
        }

        public Drawer()
        {
            Alphabet = new Dictionary<char, IDrawableObject>();
        }

        public Drawer(Bitmap canvas, Point position ,Pen pen , int sizeX, int sizeY)
        {
            this.Alphabet = new Dictionary<char, IDrawableObject>();
            this.Canvas = canvas;
            this.Position0 = position;
            this.Pen = pen;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
        }

        //если приходит лист с несколькими одинаковыми ключами,
        //то в алфавит записывается первый символ по повторяющемуся ключу
        public void CreateAlphabet(List<SymbolPath> table)
        {
            foreach (var line in table)
            {
                if (!Alphabet.ContainsKey(line.Symbol))
                    this.Alphabet.Add(line.Symbol, DataFile.OpenSymbol(line.Path));
            }
        }

        public void DrawCursor()
        {
            Graphics.DrawLine(pen, Position.X, Position.Y, Position.X,
                Position.Y + (int) (SizeY * (double) WidthSymbol));
        }

        public void WriteString()
        {
            if (MyString == null)
                return;
            ClearCanvas();
            Position = Position0;
            foreach (char symbol in MyString)
            {
                if (Alphabet.ContainsKey(symbol))
                {
                  WriteSymbol(Alphabet[symbol]);
                }
                else
                {
                    WriteSymbol(SpecialSymbol);
                }
                Position = new Point(Position.X + (int) (WidthSymbol * SizeX), Position.Y);
            }
        }

        private void WriteSymbol(IDrawableObject symbol)
        {
            foreach (var link in symbol.Links)
            {
                if (link.LinksType == Links.Line)
                {
                    Graphics.DrawLine(Pen, (int)(Position.X + link.P1.X * SizeX),
                        Position.Y + (int)(link.P1.Y * SizeY),
                        Position.X + (int)(link.P2.X * SizeX),
                        Position.Y + (int)(link.P2.Y * SizeY));
                }
                else if (link.LinksType == Links.Bezier)
                {
                    Graphics.DrawBezier(Pen,
                        (int)(Position.X + link.P1.X * SizeX), Position.Y + (int)(link.P1.Y * SizeY),
                        Position.X + (int)(link.P2.X * SizeX), Position.Y + (int)(link.P2.Y * SizeY),
                        Position.X + (int)(link.P3.X * SizeX), Position.Y + (int)(link.P3.Y * SizeY),
                        Position.X + (int)(link.P4.X * SizeX), Position.Y + (int)(link.P4.Y * SizeY));
                }
            }
        }
    }
}
