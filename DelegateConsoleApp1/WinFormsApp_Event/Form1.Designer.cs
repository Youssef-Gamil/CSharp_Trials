﻿namespace WinFormsApp_Event
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myButton1 = new MyButton();
            myButton2 = new MyButton();
            SuspendLayout();
            // 
            // myButton1
            // 
            myButton1.Location = new Point(107, 99);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(75, 23);
            myButton1.TabIndex = 0;
            myButton1.Text = "myButton1";
            myButton1.UseVisualStyleBackColor = true;
            // 
            // myButton2
            // 
            myButton2.Location = new Point(107, 128);
            myButton2.Name = "myButton2";
            myButton2.Size = new Size(75, 23);
            myButton2.TabIndex = 1;
            myButton2.Text = "myButton2";
            myButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 245);
            Controls.Add(myButton2);
            Controls.Add(myButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MyButton myButton1;
        private MyButton myButton2;
    }
}