﻿namespace GraficPrimitive
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pixel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pixel
            // 
            this.Pixel.Location = new System.Drawing.Point(635, 12);
            this.Pixel.Name = "Pixel";
            this.Pixel.Size = new System.Drawing.Size(172, 31);
            this.Pixel.TabIndex = 1;
            this.Pixel.Text = "Горизонтальная линия";
            this.Pixel.UseVisualStyleBackColor = true;
            this.Pixel.Click += new System.EventHandler(this.HorizontalLineBtn);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вертикальная линия";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VerticalLineBtn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Правая диагональ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RightDiagonalBtn);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Левая диагональ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LeftDiagonalBtn);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Звёздное небо";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ZvNeboBtn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pixel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pixel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

