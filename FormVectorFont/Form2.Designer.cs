namespace FormEditFont
{
    partial class EditFont
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemovePoint = new System.Windows.Forms.Button();
            this.textBoxRemovePoint = new System.Windows.Forms.TextBox();
            this.buttonRemoveLink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxAddToAlphabet = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.textBoxp3 = new System.Windows.Forms.TextBox();
            this.textBoxp2 = new System.Windows.Forms.TextBox();
            this.textBoxp4 = new System.Windows.Forms.TextBox();
            this.textBoxp1 = new System.Windows.Forms.TextBox();
            this.radioButtonBezier = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.buttonAddLink = new System.Windows.Forms.Button();
            this.saveFileDialogSymbol = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogSymbol = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(35, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonRemovePoint);
            this.panel1.Controls.Add(this.textBoxRemovePoint);
            this.panel1.Controls.Add(this.buttonRemoveLink);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBoxAddToAlphabet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxSymbol);
            this.panel1.Controls.Add(this.textBoxp3);
            this.panel1.Controls.Add(this.textBoxp2);
            this.panel1.Controls.Add(this.textBoxp4);
            this.panel1.Controls.Add(this.textBoxp1);
            this.panel1.Controls.Add(this.radioButtonBezier);
            this.panel1.Controls.Add(this.radioButtonLine);
            this.panel1.Controls.Add(this.buttonAddLink);
            this.panel1.Location = new System.Drawing.Point(840, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 607);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonRemovePoint
            // 
            this.buttonRemovePoint.Location = new System.Drawing.Point(45, 548);
            this.buttonRemovePoint.Name = "buttonRemovePoint";
            this.buttonRemovePoint.Size = new System.Drawing.Size(222, 45);
            this.buttonRemovePoint.TabIndex = 20;
            this.buttonRemovePoint.Text = "Remove point";
            this.buttonRemovePoint.UseVisualStyleBackColor = true;
            this.buttonRemovePoint.Click += new System.EventHandler(this.buttonRemovePoint_Click);
            // 
            // textBoxRemovePoint
            // 
            this.textBoxRemovePoint.Location = new System.Drawing.Point(169, 503);
            this.textBoxRemovePoint.Name = "textBoxRemovePoint";
            this.textBoxRemovePoint.Size = new System.Drawing.Size(24, 26);
            this.textBoxRemovePoint.TabIndex = 19;
            // 
            // buttonRemoveLink
            // 
            this.buttonRemoveLink.Location = new System.Drawing.Point(45, 430);
            this.buttonRemoveLink.Name = "buttonRemoveLink";
            this.buttonRemoveLink.Size = new System.Drawing.Size(222, 42);
            this.buttonRemoveLink.TabIndex = 18;
            this.buttonRemoveLink.Text = "Remove last link";
            this.buttonRemoveLink.UseVisualStyleBackColor = true;
            this.buttonRemoveLink.Click += new System.EventHandler(this.buttonRemoveLink_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Numbers of points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type";
            // 
            // checkBoxAddToAlphabet
            // 
            this.checkBoxAddToAlphabet.AutoSize = true;
            this.checkBoxAddToAlphabet.Checked = true;
            this.checkBoxAddToAlphabet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddToAlphabet.Location = new System.Drawing.Point(45, 108);
            this.checkBoxAddToAlphabet.Name = "checkBoxAddToAlphabet";
            this.checkBoxAddToAlphabet.Size = new System.Drawing.Size(148, 24);
            this.checkBoxAddToAlphabet.TabIndex = 15;
            this.checkBoxAddToAlphabet.Text = "Add to alphabet";
            this.checkBoxAddToAlphabet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Symbol";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(106, 58);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(26, 26);
            this.textBoxSymbol.TabIndex = 12;
            // 
            // textBoxp3
            // 
            this.textBoxp3.Location = new System.Drawing.Point(153, 302);
            this.textBoxp3.Name = "textBoxp3";
            this.textBoxp3.Size = new System.Drawing.Size(26, 26);
            this.textBoxp3.TabIndex = 9;
            this.textBoxp3.Visible = false;
            // 
            // textBoxp2
            // 
            this.textBoxp2.Location = new System.Drawing.Point(106, 302);
            this.textBoxp2.Name = "textBoxp2";
            this.textBoxp2.Size = new System.Drawing.Size(26, 26);
            this.textBoxp2.TabIndex = 7;
            this.textBoxp2.Visible = false;
            // 
            // textBoxp4
            // 
            this.textBoxp4.Location = new System.Drawing.Point(205, 302);
            this.textBoxp4.Name = "textBoxp4";
            this.textBoxp4.Size = new System.Drawing.Size(26, 26);
            this.textBoxp4.TabIndex = 5;
            // 
            // textBoxp1
            // 
            this.textBoxp1.Location = new System.Drawing.Point(54, 302);
            this.textBoxp1.Name = "textBoxp1";
            this.textBoxp1.Size = new System.Drawing.Size(26, 26);
            this.textBoxp1.TabIndex = 3;
            // 
            // radioButtonBezier
            // 
            this.radioButtonBezier.AutoSize = true;
            this.radioButtonBezier.Location = new System.Drawing.Point(188, 200);
            this.radioButtonBezier.Name = "radioButtonBezier";
            this.radioButtonBezier.Size = new System.Drawing.Size(79, 24);
            this.radioButtonBezier.TabIndex = 2;
            this.radioButtonBezier.TabStop = true;
            this.radioButtonBezier.Text = "Bezier";
            this.radioButtonBezier.UseVisualStyleBackColor = true;
            this.radioButtonBezier.CheckedChanged += new System.EventHandler(this.radioButtonBezier_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Checked = true;
            this.radioButtonLine.Location = new System.Drawing.Point(54, 200);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(64, 24);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // buttonAddLink
            // 
            this.buttonAddLink.Location = new System.Drawing.Point(45, 361);
            this.buttonAddLink.Name = "buttonAddLink";
            this.buttonAddLink.Size = new System.Drawing.Size(222, 39);
            this.buttonAddLink.TabIndex = 0;
            this.buttonAddLink.Text = "Add link";
            this.buttonAddLink.UseVisualStyleBackColor = true;
            this.buttonAddLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialogSymbol
            // 
            this.openFileDialogSymbol.FileName = "openFileDialog2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number of point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Edit Symbol";
            // 
            // EditFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditFont";
            this.Text = "EditSymbol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddLink;
        private System.Windows.Forms.TextBox textBoxp3;
        private System.Windows.Forms.TextBox textBoxp2;
        private System.Windows.Forms.TextBox textBoxp4;
        private System.Windows.Forms.TextBox textBoxp1;
        private System.Windows.Forms.RadioButton radioButtonBezier;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogSymbol;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAddToAlphabet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRemoveLink;
        private System.Windows.Forms.Button buttonRemovePoint;
        private System.Windows.Forms.TextBox textBoxRemovePoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

