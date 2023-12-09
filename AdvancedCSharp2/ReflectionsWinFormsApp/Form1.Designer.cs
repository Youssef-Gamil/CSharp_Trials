namespace ReflectionsWinFormsApp
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
            txt_fileName = new TextBox();
            btn_browse = new Button();
            btn_create = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // txt_fileName
            // 
            txt_fileName.Location = new Point(22, 53);
            txt_fileName.Name = "txt_fileName";
            txt_fileName.Size = new Size(344, 23);
            txt_fileName.TabIndex = 0;
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(372, 53);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(99, 23);
            btn_browse.TabIndex = 1;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(22, 93);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(449, 23);
            btn_create.TabIndex = 2;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 170);
            Controls.Add(btn_create);
            Controls.Add(btn_browse);
            Controls.Add(txt_fileName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_fileName;
        private Button btn_browse;
        private Button btn_create;
        private OpenFileDialog openFileDialog1;
    }
}