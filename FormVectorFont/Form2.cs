using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

namespace FormEditFont
{
    public partial class EditFont : Form
    {

        private Font font { get; set; } = new Font(FontFamily.GenericSerif, 10);
        private Symbol symbol;

        private Symbol Symbol
        {
            get { return symbol; }
            set
            {
                symbol = value;
                if (drawer != null)
                {
                    //drawer.MyString = SymbolX.ToString();
                    //Redraw();
                }
            }
        }

        private Bitmap Canvas { get; set; }
        private Bitmap Canvas2 { get; set; }
        private Graphics G { get; set; }
        private Drawer drawer { get; set; }
        private char SymbolX { get; set; }
        private Pen Pen = new Pen(Color.Black);
        private int numberOfMove;

        public EditFont()
        {
            InitializeComponent();
            pictureBox1.Width = pictureBox1.Height = 500;
            this.Width = 800;
            this.Height = 600;
            Symbol = new Symbol();
            Canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Canvas2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            G = Graphics.FromImage(Canvas);
            drawer = new Drawer(Canvas2, new LogicLibrary.Point(100, 100), new Pen(Color.Black), 3, 3);
            SymbolX = 'X';
            drawer.Alphabet.Add(SymbolX, Symbol);
            drawer.MyString = SymbolX.ToString();
            numberOfMove = -1;
            DrawLines();
            Redraw();
            pictureBox1.BackgroundImage = Canvas;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //единичный квадрат для символов = 100 пикселей
            if (numberOfMove == -1)
            {
                Symbol.Points.Add(new LogicLibrary.Point((e.X-100) / 3, (e.Y-100) / 3));
                G.DrawRectangle(Pen, e.X, e.Y, 2, 2);
                G.DrawString(Symbol.Points.Count.ToString(), Font, new SolidBrush(Color.Black), e.X,
                    e.Y);
                
                //drawer.WriteString();
                RedrawPoints();
                pictureBox1.BackgroundImage = Canvas;
                DrawLines();
                Redraw();
            }
        }

        private void radioButtonBezier_CheckedChanged(object sender, EventArgs e)
        {
            //textBoxp2.Enabled = radioButtonBezier.Checked;
            //textBoxp3.Enabled = radioButtonBezier.Checked;
            textBoxp3.Visible = radioButtonBezier.Checked;
            textBoxp2.Visible= radioButtonBezier.Checked;
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            int p1, p2, p3, p4;
            if (radioButtonLine.Checked)
            {
                if (int.TryParse(textBoxp1.Text, out p1) && int.TryParse(textBoxp4.Text, out p4) &&
                    p1 >= 0 && p4 < symbol.Points.Count && p1 >= 0 && p4 < symbol.Points.Count)
                    Symbol.Links.Add(
                        new Link() {P1 = Symbol.Points[p1], P2 = Symbol.Points[p4], LinksType = Links.Line});
                else
                {
                    MessageBox.Show("Incorrect data.");
                }
            }
            else if (radioButtonBezier.Checked)
            {
                if (int.TryParse(textBoxp1.Text, out p1) && int.TryParse(textBoxp4.Text, out p4) &&
                    int.TryParse(textBoxp2.Text, out p2) && int.TryParse(textBoxp3.Text, out p3) && p1 >= 0 &&
                    p1 < symbol.Points.Count && p4 >= 0 && p4 < symbol.Points.Count &&
                    p2 >= 0 && p2 < symbol.Points.Count && p3 >= 0 && p3 < symbol.Points.Count)
                    Symbol.Links.Add(new Link()
                    {
                        P1 = Symbol.Points[p1], P2 = Symbol.Points[p2], LinksType = Links.Bezier,
                        P3 = Symbol.Points[p3],
                        P4 = Symbol.Points[p4]
                    });
                else
                {
                    MessageBox.Show("Incorrect data.");
                }
            }

            drawer.WriteString();
            Redraw();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddSymbolInAlphabet_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataFile.SaveTablePaths(
                    new SymbolPath(Convert.ToChar(textBoxSymbol.Text[0]), saveFileDialogSymbol.FileName),
                    openFileDialog1.FileName);
            }
        }

        void Redraw()
        {
            Bitmap temp = (Bitmap) drawer.Canvas.Clone();
            temp.MakeTransparent(drawer.BackColor);
            pictureBox1.Image = temp;
        }

        void RedrawPoints()
        {
            G.Clear(Color.White);
            for (var i = 0; i < Symbol.Points.Count; i++)
            {
                G.DrawRectangle(Pen, Symbol.Points[i].X * 3 + 100, Symbol.Points[i].Y * 3 + 100, 2, 2);
                G.DrawString(i.ToString(), font, new SolidBrush(Color.Black),
                    Symbol.Points[i].X * 3 + 100, Symbol.Points[i].Y * 3 + 100);
            }
        }

        void DrawLines()
        {
            G.DrawLine(Pen, 100, 0, 100, 500);
            G.DrawLine(Pen, 400, 0, 400, 500);
            G.DrawLine(Pen, 0, 100, 500, 100);
            G.DrawLine(Pen, 0, 400, 500, 400);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Symbol.Points.Count; i++)
            {
                if (Math.Sqrt((e.X - Symbol.Points[i].X * 3-100) * (e.X - Symbol.Points[i].X * 3-100) +
                              (e.Y - Symbol.Points[i].Y * 3-100) * (e.Y - Symbol.Points[i].Y * 3-100)) <
                    20)
                {
                    numberOfMove = i;
                    break;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (numberOfMove > -1)
            {
                //!!!!!!!!!!!!!!!!!!!!!!   1!!!!!!!!!!!
                Symbol.Points[numberOfMove].X = (e.X-100) / 3 ;
                Symbol.Points[numberOfMove].Y = (e.Y-100) / 3;
                numberOfMove = -1;
                drawer.WriteString();
                RedrawPoints();
                DrawLines();
                pictureBox1.BackgroundImage = Canvas;
                Redraw();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialogSymbol.Filter = "Symbol files(*.sym) | *.sym";
            //if (openFileDialogSymbol.ShowDialog() == DialogResult.OK)
            //{
            //    Symbol = DataFile.OpenSymbol(openFileDialogSymbol.FileName);
            //    RedrawPoints();
            //    drawer.WriteString();
            //    Redraw();
            //}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogSymbol.Filter = "Symbol files(*.sym) | *.sym";
            if (saveFileDialogSymbol.ShowDialog() == DialogResult.OK)
            {
                DataFile.SaveSymbol(saveFileDialogSymbol.FileName, Symbol);
                if (checkBoxAddToAlphabet.Checked)
                {
                    if (textBoxSymbol.Text.Length == 1)
                        DataFile.SaveTablePaths(
                            new SymbolPath(Convert.ToChar(textBoxSymbol.Text[0]), saveFileDialogSymbol.FileName),
                            "../../../Source/alphabet.txt");
                    else
                        MessageBox.Show("Incorrect data");
                }
            }
        }

        private void ShowMessageBox()
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRemoveLink_Click(object sender, EventArgs e)
        {
            if (symbol.Links.Count > 0)
            {
                Symbol.Links.RemoveAt(symbol.Links.Count - 1);
                drawer.WriteString();
                Redraw();
            }
        }

        private void buttonRemovePoint_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(textBoxRemovePoint.Text, out index) && index >= 0 && index < Symbol.Points.Count)
            {
                for(int i=0;i<Symbol.Links.Count;i++)
                {
                    if (Equals(Symbol.Links[i].P1, Symbol.Points[index]) || Equals(Symbol.Links[i].P2, Symbol.Points[index]) ||
                        Equals(Symbol.Links[i].P3, Symbol.Points[index]) || Equals(Symbol.Links[i].P4, Symbol.Points[index]))
                    {
                        Symbol.Links.RemoveAt(i);
                    }
                }
                Symbol.Points.RemoveAt(index);
                drawer.WriteString();
             
                RedrawPoints();
                DrawLines();
                Redraw();
            } 
        }
    }
}
