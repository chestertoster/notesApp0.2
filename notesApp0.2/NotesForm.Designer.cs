namespace notesApp0._2
{
    partial class NotesForm
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
            textBoxEntry = new TextBox();
            SuspendLayout();
            // 
            // textBoxEntry
            // 
            textBoxEntry.Location = new Point(0, 1);
            textBoxEntry.Multiline = true;
            textBoxEntry.Name = "textBoxEntry";
            textBoxEntry.Size = new Size(556, 376);
            textBoxEntry.TabIndex = 0;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 374);
            Controls.Add(textBoxEntry);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NotesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotesForm";
            FormClosed += NotesForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEntry;
    }
}