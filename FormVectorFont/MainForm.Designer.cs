namespace FormVectorFont
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSymbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAlphabetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarSizeY = new System.Windows.Forms.TrackBar();
            this.trackBarSizeX = new System.Windows.Forms.TrackBar();
            this.trackBarWidthPen = new System.Windows.Forms.TrackBar();
            this.btnChangePenColor = new System.Windows.Forms.Button();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogAlphabet = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthPen)).BeginInit();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editSymbolsToolStripMenuItem,
            this.addAlphabetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.createToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // editSymbolsToolStripMenuItem
            // 
            this.editSymbolsToolStripMenuItem.Name = "editSymbolsToolStripMenuItem";
            this.editSymbolsToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.editSymbolsToolStripMenuItem.Text = "Edit symbols";
            this.editSymbolsToolStripMenuItem.Click += new System.EventHandler(this.editSymbolsToolStripMenuItem_Click);
            // 
            // addAlphabetToolStripMenuItem
            // 
            this.addAlphabetToolStripMenuItem.Name = "addAlphabetToolStripMenuItem";
            this.addAlphabetToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.addAlphabetToolStripMenuItem.Text = "AddAlphabet";
            this.addAlphabetToolStripMenuItem.Click += new System.EventHandler(this.addAlphabetToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarSizeY);
            this.panel1.Controls.Add(this.trackBarSizeX);
            this.panel1.Controls.Add(this.trackBarWidthPen);
            this.panel1.Controls.Add(this.btnChangePenColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1015, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 660);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ResizeY";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(40, 563);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(225, 75);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(124, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thickness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ResizeX";
            // 
            // trackBarSizeY
            // 
            this.trackBarSizeY.Location = new System.Drawing.Point(40, 468);
            this.trackBarSizeY.Maximum = 100;
            this.trackBarSizeY.Minimum = 1;
            this.trackBarSizeY.Name = "trackBarSizeY";
            this.trackBarSizeY.Size = new System.Drawing.Size(225, 69);
            this.trackBarSizeY.TabIndex = 6;
            this.trackBarSizeY.Value = 10;
            this.trackBarSizeY.ValueChanged += new System.EventHandler(this.trackBarSizeY_ValueChanged);
            // 
            // trackBarSizeX
            // 
            this.trackBarSizeX.Location = new System.Drawing.Point(40, 349);
            this.trackBarSizeX.Maximum = 100;
            this.trackBarSizeX.Minimum = 1;
            this.trackBarSizeX.Name = "trackBarSizeX";
            this.trackBarSizeX.Size = new System.Drawing.Size(225, 69);
            this.trackBarSizeX.TabIndex = 5;
            this.trackBarSizeX.Value = 10;
            this.trackBarSizeX.ValueChanged += new System.EventHandler(this.trackBarSizeX_ValueChanged);
            // 
            // trackBarWidthPen
            // 
            this.trackBarWidthPen.Location = new System.Drawing.Point(45, 231);
            this.trackBarWidthPen.Minimum = 1;
            this.trackBarWidthPen.Name = "trackBarWidthPen";
            this.trackBarWidthPen.Size = new System.Drawing.Size(225, 69);
            this.trackBarWidthPen.TabIndex = 4;
            this.trackBarWidthPen.Value = 1;
            this.trackBarWidthPen.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnChangePenColor
            // 
            this.btnChangePenColor.Location = new System.Drawing.Point(45, 89);
            this.btnChangePenColor.Name = "btnChangePenColor";
            this.btnChangePenColor.Size = new System.Drawing.Size(225, 35);
            this.btnChangePenColor.TabIndex = 3;
            this.btnChangePenColor.Text = "Change pen color";
            this.btnChangePenColor.UseVisualStyleBackColor = true;
            this.btnChangePenColor.Click += new System.EventHandler(this.btnChangePenColor_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // openFileDialogAlphabet
            // 
            this.openFileDialogAlphabet.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelPicture
            // 
            this.panelPicture.AutoScroll = true;
            this.panelPicture.Controls.Add(this.pictureBox);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture.Location = new System.Drawing.Point(0, 33);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(1015, 660);
            this.panelPicture.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 693);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vector font";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthPen)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePenColor;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.TrackBar trackBarWidthPen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.ToolStripMenuItem editSymbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAlphabetToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogAlphabet;
        private System.Windows.Forms.TrackBar trackBarSizeY;
        private System.Windows.Forms.TrackBar trackBarSizeX;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

