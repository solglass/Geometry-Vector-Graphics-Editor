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
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.RectangularTriangleButton = new System.Windows.Forms.Button();
            this.IsoscelesTriangleButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(686, 6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Очистить\r\n";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Кисть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Линия";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(12, 87);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(99, 23);
            this.SquareButton.TabIndex = 3;
            this.SquareButton.Text = "Квадрат";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(12, 116);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(99, 23);
            this.RectangleButton.TabIndex = 4;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Треугольник";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(117, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 299);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // RectangularTriangleButton
            // 
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Прямоуг. Треуг.";
            this.button1.UseVisualStyleBackColor = true;
            this.RectangularTriangleButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RectangularTriangleButton.Location = new System.Drawing.Point(16, 214);
            this.RectangularTriangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.RectangularTriangleButton.Name = "RectangularTriangleButton";
            this.RectangularTriangleButton.Size = new System.Drawing.Size(132, 28);
            this.RectangularTriangleButton.TabIndex = 7;
            this.RectangularTriangleButton.Text = "Прямоуг. Треуг.";
            this.RectangularTriangleButton.UseVisualStyleBackColor = true;
            this.RectangularTriangleButton.Click += new System.EventHandler(this.RectangularTriangleButton_Click);
            // 
            // IsoscelesTriangleButton
            // 
            this.button7.Location = new System.Drawing.Point(12, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Равнобедр. Треуг.";
            this.button7.UseVisualStyleBackColor = true;
            this.IsoscelesTriangleButton.Location = new System.Drawing.Point(16, 250);
            this.IsoscelesTriangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.IsoscelesTriangleButton.Name = "IsoscelesTriangleButton";
            this.IsoscelesTriangleButton.Size = new System.Drawing.Size(132, 28);
            this.IsoscelesTriangleButton.TabIndex = 8;
            this.IsoscelesTriangleButton.Text = "Равнобедр. Треуг.";
            this.IsoscelesTriangleButton.UseVisualStyleBackColor = true;
            this.IsoscelesTriangleButton.Click += new System.EventHandler(this.IsoscelesTriangleButton_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(12, 232);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(99, 23);
            this.Circle.TabIndex = 9;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(12, 261);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(99, 23);
            this.Ellipse.TabIndex = 10;
            this.Ellipse.Text = "Эллипс";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(207, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 26);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(126, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Толщина";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(271, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Цвет";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(352, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(36, 26);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 290);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "N угольник";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 319);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 23);
            this.button11.TabIndex = 16;
            this.button11.Text = "Ломанная";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(605, 6);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 17;
            this.buttonDraw.Text = "Рисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(524, 6);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 18;
            this.buttonMove.Text = "Двигать";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.IsoscelesTriangleButton);
            this.Controls.Add(this.RectangularTriangleButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button RectangularTriangleButton;
        private System.Windows.Forms.Button IsoscelesTriangleButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonMove;
    }
}

