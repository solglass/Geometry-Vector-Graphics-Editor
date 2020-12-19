﻿namespace graphics
{
    partial class Form1
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonRectangularTriangle = new System.Windows.Forms.Button();
            this.buttonIsoscalesTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonPoligon = new System.Windows.Forms.Button();
            this.buttonZigzag = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonRegularPolygon = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.buttonFilling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(956, 7);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Очистить\r\n";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonBrush
            // 
            this.buttonBrush.Location = new System.Drawing.Point(12, 43);
            this.buttonBrush.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(132, 28);
            this.buttonBrush.TabIndex = 1;
            this.buttonBrush.Text = "Кисть";
            this.buttonBrush.UseVisualStyleBackColor = true;
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(12, 79);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(132, 28);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(12, 126);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(132, 28);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(12, 162);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(132, 28);
            this.buttonRectangle.TabIndex = 4;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(12, 207);
            this.buttonTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(132, 28);
            this.buttonTriangle.TabIndex = 5;
            this.buttonTriangle.Text = "Треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(156, 43);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(899, 632);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // buttonRectangularTriangle
            // 
            this.buttonRectangularTriangle.Location = new System.Drawing.Point(12, 243);
            this.buttonRectangularTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRectangularTriangle.Name = "buttonRectangularTriangle";
            this.buttonRectangularTriangle.Size = new System.Drawing.Size(132, 42);
            this.buttonRectangularTriangle.TabIndex = 7;
            this.buttonRectangularTriangle.Text = "Прямоугольный треугольник";
            this.buttonRectangularTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonIsoscalesTriangle
            // 
            this.buttonIsoscalesTriangle.Location = new System.Drawing.Point(12, 293);
            this.buttonIsoscalesTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIsoscalesTriangle.Name = "buttonIsoscalesTriangle";
            this.buttonIsoscalesTriangle.Size = new System.Drawing.Size(132, 43);
            this.buttonIsoscalesTriangle.TabIndex = 8;
            this.buttonIsoscalesTriangle.Text = "Равнобедренный треугольник";
            this.buttonIsoscalesTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(12, 362);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(132, 28);
            this.buttonCircle.TabIndex = 9;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(12, 398);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(132, 28);
            this.buttonEllipse.TabIndex = 10;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            // 
            // buttonPoligon
            // 
            this.buttonPoligon.Location = new System.Drawing.Point(12, 485);
            this.buttonPoligon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPoligon.Name = "buttonPoligon";
            this.buttonPoligon.Size = new System.Drawing.Size(132, 28);
            this.buttonPoligon.TabIndex = 15;
            this.buttonPoligon.Text = "Многоугольник";
            this.buttonPoligon.UseVisualStyleBackColor = true;
            // 
            // buttonZigzag
            // 
            this.buttonZigzag.Location = new System.Drawing.Point(12, 449);
            this.buttonZigzag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZigzag.Name = "buttonZigzag";
            this.buttonZigzag.Size = new System.Drawing.Size(132, 28);
            this.buttonZigzag.TabIndex = 16;
            this.buttonZigzag.Text = "Ломанная";
            this.buttonZigzag.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(276, 7);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 28);
            this.buttonDraw.TabIndex = 17;
            this.buttonDraw.Text = "Рисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(490, 7);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 28);
            this.buttonMove.TabIndex = 18;
            this.buttonMove.Text = "Двигать";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // buttonRegularPolygon
            // 
            this.buttonRegularPolygon.Location = new System.Drawing.Point(12, 519);
            this.buttonRegularPolygon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegularPolygon.Name = "buttonRegularPolygon";
            this.buttonRegularPolygon.Size = new System.Drawing.Size(132, 46);
            this.buttonRegularPolygon.TabIndex = 19;
            this.buttonRegularPolygon.Text = "Правильный многоугольник";
            this.buttonRegularPolygon.UseVisualStyleBackColor = true;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(12, 638);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(132, 36);
            this.buttonColor.TabIndex = 20;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.LargeChange = 1;
            this.trackBarWidth.Location = new System.Drawing.Point(11, 578);
            this.trackBarWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(132, 56);
            this.trackBarWidth.TabIndex = 21;
            this.trackBarWidth.Value = 1;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(596, 7);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(100, 28);
            this.buttonRotate.TabIndex = 18;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(703, 7);
            this.buttonScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(148, 28);
            this.buttonScale.TabIndex = 18;
            this.buttonScale.Text = "Масштабировать";
            this.buttonScale.UseVisualStyleBackColor = true;
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(195, 7);
            this.buttonBackColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(34, 28);
            this.buttonBackColor.TabIndex = 22;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Цвет фона";
            // 
            // buttonFilling
            // 
            this.buttonFilling.Location = new System.Drawing.Point(383, 7);
            this.buttonFilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFilling.Name = "buttonFilling";
            this.buttonFilling.Size = new System.Drawing.Size(100, 28);
            this.buttonFilling.TabIndex = 17;
            this.buttonFilling.Text = "Залить";
            this.buttonFilling.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.trackBarWidth);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonRegularPolygon);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonFilling);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonZigzag);
            this.Controls.Add(this.buttonPoligon);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonIsoscalesTriangle);
            this.Controls.Add(this.buttonRectangularTriangle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonBrush);
            this.Controls.Add(this.buttonClear);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonRectangularTriangle;
        private System.Windows.Forms.Button buttonIsoscalesTriangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonPoligon;
        private System.Windows.Forms.Button buttonZigzag;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonRegularPolygon;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button buttonFilling;
    }
}

