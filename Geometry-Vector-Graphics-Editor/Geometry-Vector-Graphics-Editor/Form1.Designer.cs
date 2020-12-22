namespace graphics
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonRectangularTriangle = new System.Windows.Forms.Button();
            this.buttonIsoscalesTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
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
            this.trackBarPointsAmount = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClockwise = new System.Windows.Forms.CheckBox();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.groupBoxFigures = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointsAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxFigures.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1792, 10);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Очистить\r\n";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Location = new System.Drawing.Point(8, 37);
            this.buttonBrush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(132, 28);
            this.buttonBrush.TabIndex = 1;
            this.buttonBrush.Text = "Кисть";
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(6, 82);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(132, 28);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(8, 145);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(132, 28);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(6, 190);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(132, 28);
            this.buttonRectangle.TabIndex = 4;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(156, 43);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1728, 958);
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
            this.buttonRectangularTriangle.Location = new System.Drawing.Point(6, 254);
            this.buttonRectangularTriangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRectangularTriangle.Name = "buttonRectangularTriangle";
            this.buttonRectangularTriangle.Size = new System.Drawing.Size(132, 42);
            this.buttonRectangularTriangle.TabIndex = 7;
            this.buttonRectangularTriangle.Text = "Прямоугольный треугольник";
            this.buttonRectangularTriangle.UseVisualStyleBackColor = true;
            this.buttonRectangularTriangle.Click += new System.EventHandler(this.buttonRectangularTriangle_Click);
            // 
            // buttonIsoscalesTriangle
            // 
            this.buttonIsoscalesTriangle.Location = new System.Drawing.Point(6, 316);
            this.buttonIsoscalesTriangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIsoscalesTriangle.Name = "buttonIsoscalesTriangle";
            this.buttonIsoscalesTriangle.Size = new System.Drawing.Size(132, 43);
            this.buttonIsoscalesTriangle.TabIndex = 8;
            this.buttonIsoscalesTriangle.Text = "Равнобедренный треугольник";
            this.buttonIsoscalesTriangle.UseVisualStyleBackColor = true;
            this.buttonIsoscalesTriangle.Click += new System.EventHandler(this.buttonIsoscalesTriangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(13, 505);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(132, 28);
            this.buttonCircle.TabIndex = 9;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click_1);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(4, 453);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(132, 28);
            this.buttonEllipse.TabIndex = 10;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(11, 54);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(112, 35);
            this.buttonDraw.TabIndex = 17;
            this.buttonDraw.Text = "Рисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(454, 9);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 28);
            this.buttonMove.TabIndex = 18;
            this.buttonMove.Text = "Двигать";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRegularPolygon
            // 
            this.buttonRegularPolygon.Location = new System.Drawing.Point(11, 622);
            this.buttonRegularPolygon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegularPolygon.Name = "buttonRegularPolygon";
            this.buttonRegularPolygon.Size = new System.Drawing.Size(132, 46);
            this.buttonRegularPolygon.TabIndex = 19;
            this.buttonRegularPolygon.Text = "Правильный многоугольник";
            this.buttonRegularPolygon.UseVisualStyleBackColor = true;
            this.buttonRegularPolygon.Click += new System.EventHandler(this.buttonRegularPolygon_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(8, 82);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(124, 36);
            this.buttonColor.TabIndex = 20;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.LargeChange = 1;
            this.trackBarWidth.Location = new System.Drawing.Point(5, 39);
            this.trackBarWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(132, 56);
            this.trackBarWidth.TabIndex = 21;
            this.trackBarWidth.Value = 1;
            this.trackBarWidth.Scroll += new System.EventHandler(this.trackBarWidth_Scroll);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(518, 7);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(100, 28);
            this.buttonRotate.TabIndex = 18;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(840, 7);
            this.buttonScale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(148, 28);
            this.buttonScale.TabIndex = 18;
            this.buttonScale.Text = "Масштабировать";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(272, 8);
            this.buttonBackColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(35, 28);
            this.buttonBackColor.TabIndex = 22;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Цвет фона";
            // 
            // trackBarPointsAmount
            // 
            this.trackBarPointsAmount.Location = new System.Drawing.Point(7, 714);
            this.trackBarPointsAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarPointsAmount.Maximum = 15;
            this.trackBarPointsAmount.Minimum = 3;
            this.trackBarPointsAmount.Name = "trackBarPointsAmount";
            this.trackBarPointsAmount.Size = new System.Drawing.Size(137, 56);
            this.trackBarPointsAmount.TabIndex = 24;
            this.trackBarPointsAmount.Value = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 691);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Количество вершин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Controls.Add(this.trackBarWidth);
            this.groupBox1.Location = new System.Drawing.Point(14, 844);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(137, 134);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры карандаша";
            // 
            // checkBoxClockwise
            // 
            this.checkBoxClockwise.AutoSize = true;
            this.checkBoxClockwise.Checked = true;
            this.checkBoxClockwise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClockwise.Location = new System.Drawing.Point(624, 12);
            this.checkBoxClockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxClockwise.Name = "checkBoxClockwise";
            this.checkBoxClockwise.Size = new System.Drawing.Size(163, 21);
            this.checkBoxClockwise.TabIndex = 27;
            this.checkBoxClockwise.Text = "По часовой стрелке";
            this.checkBoxClockwise.UseVisualStyleBackColor = true;
            this.checkBoxClockwise.Click += new System.EventHandler(this.checkBoxClockwise_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Image = global::Geometry_Vector_Graphics_Editor.Properties.Resources._22;
            this.buttonSaveAs.Location = new System.Drawing.Point(1385, 7);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(57, 44);
            this.buttonSaveAs.TabIndex = 28;
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(1516, 8);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(136, 29);
            this.buttonUpload.TabIndex = 28;
            this.buttonUpload.Text = "Открыть...";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // groupBoxFigures
            // 
            this.groupBoxFigures.Controls.Add(this.buttonBrush);
            this.groupBoxFigures.Controls.Add(this.buttonLine);
            this.groupBoxFigures.Controls.Add(this.buttonSquare);
            this.groupBoxFigures.Controls.Add(this.buttonRectangle);
            this.groupBoxFigures.Controls.Add(this.buttonRectangularTriangle);
            this.groupBoxFigures.Controls.Add(this.buttonIsoscalesTriangle);
            this.groupBoxFigures.Controls.Add(this.buttonEllipse);
            this.groupBoxFigures.Location = new System.Drawing.Point(7, 97);
            this.groupBoxFigures.Name = "groupBoxFigures";
            this.groupBoxFigures.Size = new System.Drawing.Size(162, 706);
            this.groupBoxFigures.TabIndex = 29;
            this.groupBoxFigures.TabStop = false;
            this.groupBoxFigures.Text = "Фигуры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1917, 1064);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.checkBoxClockwise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.buttonRegularPolygon);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarPointsAmount);
            this.Controls.Add(this.groupBoxFigures);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Meduza editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointsAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFigures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonRectangularTriangle;
        private System.Windows.Forms.Button buttonIsoscalesTriangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEllipse;
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
        private System.Windows.Forms.TrackBar trackBarPointsAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxClockwise;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.GroupBox groupBoxFigures;
    }
}

