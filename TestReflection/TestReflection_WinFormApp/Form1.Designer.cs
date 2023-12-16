namespace TestReflection_WinFormApp
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
            txt_FileName = new TextBox();
            btn_Browse = new Button();
            btn_Run = new Button();
            openFileDialog1 = new OpenFileDialog();
            list_Classes = new ListBox();
            list_functions = new ListBox();
            SuspendLayout();
            // 
            // txt_FileName
            // 
            txt_FileName.Location = new Point(23, 24);
            txt_FileName.Name = "txt_FileName";
            txt_FileName.Size = new Size(400, 23);
            txt_FileName.TabIndex = 0;
            // 
            // btn_Browse
            // 
            btn_Browse.Location = new Point(429, 24);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(103, 23);
            btn_Browse.TabIndex = 1;
            btn_Browse.Text = "Browse";
            btn_Browse.UseVisualStyleBackColor = true;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // btn_Run
            // 
            btn_Run.Location = new Point(429, 53);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(100, 330);
            btn_Run.TabIndex = 4;
            btn_Run.Text = "Run";
            btn_Run.UseVisualStyleBackColor = true;
            btn_Run.Click += btn_Run_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // list_Classes
            // 
            list_Classes.FormattingEnabled = true;
            list_Classes.ItemHeight = 15;
            list_Classes.Location = new Point(23, 53);
            list_Classes.Name = "list_Classes";
            list_Classes.Size = new Size(400, 94);
            list_Classes.TabIndex = 5;
            list_Classes.SelectedIndexChanged += list_Classes_SelectedIndexChanged;
            // 
            // list_functions
            // 
            list_functions.FormattingEnabled = true;
            list_functions.ItemHeight = 15;
            list_functions.Location = new Point(23, 153);
            list_functions.Name = "list_functions";
            list_functions.Size = new Size(400, 229);
            list_functions.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 395);
            Controls.Add(list_functions);
            Controls.Add(list_Classes);
            Controls.Add(btn_Run);
            Controls.Add(btn_Browse);
            Controls.Add(txt_FileName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_FileName;
        private Button btn_Browse;
        private Button btn_Run;
        private OpenFileDialog openFileDialog1;
        private ListBox list_Classes;
        private ListBox list_functions;
    }
}