namespace FormVectorFont
{
    partial class FormCreateNewFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetSizeCanvas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCanvasHight = new System.Windows.Forms.TextBox();
            this.txtCanvasWidth = new System.Windows.Forms.TextBox();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.colorDialogBackground = new System.Windows.Forms.ColorDialog();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetSizeCanvas
            // 
            this.buttonSetSizeCanvas.Location = new System.Drawing.Point(227, 169);
            this.buttonSetSizeCanvas.Name = "buttonSetSizeCanvas";
            this.buttonSetSizeCanvas.Size = new System.Drawing.Size(111, 33);
            this.buttonSetSizeCanvas.TabIndex = 20;
            this.buttonSetSizeCanvas.Text = "Ok";
            this.buttonSetSizeCanvas.UseVisualStyleBackColor = true;
            this.buttonSetSizeCanvas.Click += new System.EventHandler(this.buttonSetSizeCanvas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hight";
            // 
            // txtCanvasHight
            // 
            this.txtCanvasHight.Location = new System.Drawing.Point(285, 35);
            this.txtCanvasHight.Name = "txtCanvasHight";
            this.txtCanvasHight.Size = new System.Drawing.Size(53, 26);
            this.txtCanvasHight.TabIndex = 17;
            this.txtCanvasHight.Text = "300";
            // 
            // txtCanvasWidth
            // 
            this.txtCanvasWidth.Location = new System.Drawing.Point(127, 35);
            this.txtCanvasWidth.Name = "txtCanvasWidth";
            this.txtCanvasWidth.Size = new System.Drawing.Size(53, 26);
            this.txtCanvasWidth.TabIndex = 16;
            this.txtCanvasWidth.Text = "500";
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(75, 100);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(225, 32);
            this.btnChangeBackColor.TabIndex = 15;
            this.btnChangeBackColor.Text = "Change back color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(306, 100);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxColor.TabIndex = 21;
            this.pictureBoxColor.TabStop = false;
            // 
            // FormCreateNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 234);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.buttonSetSizeCanvas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCanvasHight);
            this.Controls.Add(this.txtCanvasWidth);
            this.Controls.Add(this.btnChangeBackColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateNewFile";
            this.Text = "Create new file";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetSizeCanvas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCanvasHight;
        private System.Windows.Forms.TextBox txtCanvasWidth;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.ColorDialog colorDialogBackground;
        private System.Windows.Forms.PictureBox pictureBoxColor;
    }
}