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
            this.buttonClear.Location = new System.Drawing.Point(717, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Очистить\r\n";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonBrush
            // 
            this.buttonBrush.Location = new System.Drawing.Point(9, 35);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(99, 23);
            this.buttonBrush.TabIndex = 1;
            this.buttonBrush.Text = "Кисть";
            this.buttonBrush.UseVisualStyleBackColor = true;
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(9, 64);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(99, 23);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(9, 102);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(99, 23);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(9, 131);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(99, 23);
            this.buttonRectangle.TabIndex = 4;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(9, 168);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(99, 23);
            this.buttonTriangle.TabIndex = 5;
            this.buttonTriangle.Text = "Треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(117, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(675, 514);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // buttonRectangularTriangle
            // 
            this.buttonRectangularTriangle.Location = new System.Drawing.Point(9, 198);
            this.buttonRectangularTriangle.Name = "buttonRectangularTriangle";
            this.buttonRectangularTriangle.Size = new System.Drawing.Size(99, 34);
            this.buttonRectangularTriangle.TabIndex = 7;
            this.buttonRectangularTriangle.Text = "Прямоугольный треугольник";
            this.buttonRectangularTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonIsoscalesTriangle
            // 
            this.buttonIsoscalesTriangle.Location = new System.Drawing.Point(9, 238);
            this.buttonIsoscalesTriangle.Name = "buttonIsoscalesTriangle";
            this.buttonIsoscalesTriangle.Size = new System.Drawing.Size(99, 35);
            this.buttonIsoscalesTriangle.TabIndex = 8;
            this.buttonIsoscalesTriangle.Text = "Равнобедренный треугольник";
            this.buttonIsoscalesTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(9, 294);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(99, 23);
            this.buttonCircle.TabIndex = 9;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(9, 324);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(99, 23);
            this.buttonEllipse.TabIndex = 10;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonPoligon
            // 
            this.buttonPoligon.Location = new System.Drawing.Point(0, 0);
            this.buttonPoligon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPoligon.Name = "buttonPoligon";
            this.buttonPoligon.Size = new System.Drawing.Size(50, 15);
            this.buttonPoligon.TabIndex = 24;
            // 
            // buttonZigzag
            // 
            this.buttonZigzag.Location = new System.Drawing.Point(9, 365);
            this.buttonZigzag.Name = "buttonZigzag";
            this.buttonZigzag.Size = new System.Drawing.Size(99, 23);
            this.buttonZigzag.TabIndex = 16;
            this.buttonZigzag.Text = "Ломанная";
            this.buttonZigzag.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(207, 6);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 17;
            this.buttonDraw.Text = "Рисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(367, 6);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 18;
            this.buttonMove.Text = "Двигать";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // buttonRegularPolygon
            // 
            this.buttonRegularPolygon.Location = new System.Drawing.Point(9, 422);
            this.buttonRegularPolygon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegularPolygon.Name = "buttonRegularPolygon";
            this.buttonRegularPolygon.Size = new System.Drawing.Size(99, 38);
            this.buttonRegularPolygon.TabIndex = 19;
            this.buttonRegularPolygon.Text = "Правильный многоугольник";
            this.buttonRegularPolygon.UseVisualStyleBackColor = true;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(9, 519);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(99, 29);
            this.buttonColor.TabIndex = 20;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.LargeChange = 1;
            this.trackBarWidth.Location = new System.Drawing.Point(13, 464);
            this.trackBarWidth.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(99, 45);
            this.trackBarWidth.TabIndex = 21;
            this.trackBarWidth.Value = 1;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(447, 6);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 18;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(527, 6);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(111, 23);
            this.buttonScale.TabIndex = 18;
            this.buttonScale.Text = "Масштабировать";
            this.buttonScale.UseVisualStyleBackColor = true;
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(146, 6);
            this.buttonBackColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(25, 23);
            this.buttonBackColor.TabIndex = 22;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Цвет фона";
            // 
            // buttonFilling
            // 
            this.buttonFilling.Location = new System.Drawing.Point(287, 6);
            this.buttonFilling.Name = "buttonFilling";
            this.buttonFilling.Size = new System.Drawing.Size(75, 23);
            this.buttonFilling.TabIndex = 17;
            this.buttonFilling.Text = "Залить";
            this.buttonFilling.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 565);
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

