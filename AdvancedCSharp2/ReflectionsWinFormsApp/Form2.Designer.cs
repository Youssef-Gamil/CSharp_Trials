namespace ReflectionsWinFormsApp
{
    partial class Form2
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
            btn_get = new Button();
            txt_FileName = new TextBox();
            rtxt_output = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btn_get
            // 
            btn_get.Location = new Point(403, 33);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(112, 23);
            btn_get.TabIndex = 0;
            btn_get.Text = "Get";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // txt_FileName
            // 
            txt_FileName.Location = new Point(59, 33);
            txt_FileName.Name = "txt_FileName";
            txt_FileName.Size = new Size(318, 23);
            txt_FileName.TabIndex = 1;
            // 
            // rtxt_output
            // 
            rtxt_output.Location = new Point(59, 62);
            rtxt_output.Name = "rtxt_output";
            rtxt_output.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            rtxt_output.Size = new Size(456, 87);
            rtxt_output.TabIndex = 2;
            rtxt_output.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 205);
            Controls.Add(rtxt_output);
            Controls.Add(txt_FileName);
            Controls.Add(btn_get);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_get;
        private TextBox txt_FileName;
        private RichTextBox rtxt_output;
        private OpenFileDialog openFileDialog1;
    }
}