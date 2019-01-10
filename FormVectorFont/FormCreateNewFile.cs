using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormVectorFont
{
    public partial class FormCreateNewFile : Form
    {

        public Image ImageBack { get; set; }

        public FormCreateNewFile()
        {
            InitializeComponent();
            colorDialogBackground.Color=Color.White;
            pictureBoxColor.BackColor = colorDialogBackground.Color;
        }

        private void buttonSetSizeCanvas_Click(object sender, EventArgs e)
        {
            int width, hight;
            if (int.TryParse(txtCanvasWidth.Text, out width) && int.TryParse(txtCanvasHight.Text, out hight))
            {
                ImageBack = new Bitmap(width, hight);
                Graphics g = Graphics.FromImage(ImageBack);
                g.Clear(colorDialogBackground.Color);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot create file.Incorrect data.", "Message", MessageBoxButtons.OK);
            }
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColor.BackColor = colorDialogBackground.Color;
            }
        }
    }
}
