
namespace laba1_oop
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCircle = new System.Windows.Forms.Button();
            this.btEllipse = new System.Windows.Forms.Button();
            this.btTriangle = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.btRectangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btLine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btCircle);
            this.panel1.Controls.Add(this.btEllipse);
            this.panel1.Controls.Add(this.btTriangle);
            this.panel1.Controls.Add(this.btSquare);
            this.panel1.Controls.Add(this.btRectangle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btColor);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 123);
            this.panel1.TabIndex = 0;
            // 
            // btCircle
            // 
            this.btCircle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btCircle.Location = new System.Drawing.Point(218, 61);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(104, 38);
            this.btCircle.TabIndex = 11;
            this.btCircle.Text = "Circle";
            this.btCircle.UseVisualStyleBackColor = false;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // btEllipse
            // 
            this.btEllipse.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btEllipse.Location = new System.Drawing.Point(218, 12);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(104, 38);
            this.btEllipse.TabIndex = 10;
            this.btEllipse.Text = "Ellipse";
            this.btEllipse.UseVisualStyleBackColor = false;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // btTriangle
            // 
            this.btTriangle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btTriangle.Location = new System.Drawing.Point(119, 12);
            this.btTriangle.Name = "btTriangle";
            this.btTriangle.Size = new System.Drawing.Size(93, 38);
            this.btTriangle.TabIndex = 9;
            this.btTriangle.Text = "Triangle";
            this.btTriangle.UseVisualStyleBackColor = false;
            this.btTriangle.Click += new System.EventHandler(this.btInheretedTriangle_Click);
            // 
            // btSquare
            // 
            this.btSquare.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btSquare.Location = new System.Drawing.Point(119, 61);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(93, 38);
            this.btSquare.TabIndex = 8;
            this.btSquare.Text = "Square";
            this.btSquare.UseVisualStyleBackColor = false;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btRectangle
            // 
            this.btRectangle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btRectangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRectangle.Location = new System.Drawing.Point(12, 61);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(101, 38);
            this.btRectangle.TabIndex = 7;
            this.btRectangle.Text = "Rectangle";
            this.btRectangle.UseVisualStyleBackColor = false;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(398, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // btColor
            // 
            this.btColor.BackColor = System.Drawing.Color.DarkCyan;
            this.btColor.Location = new System.Drawing.Point(391, 33);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(63, 57);
            this.btColor.TabIndex = 4;
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.trackBar1.Location = new System.Drawing.Point(492, 32);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(86, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pen size";
            // 
            // btLine
            // 
            this.btLine.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btLine.Location = new System.Drawing.Point(12, 12);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(101, 38);
            this.btLine.TabIndex = 0;
            this.btLine.Text = "Line";
            this.btLine.UseVisualStyleBackColor = false;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 632);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btEllipse;
        private System.Windows.Forms.Button btCircle;
    }
}

