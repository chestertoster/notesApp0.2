namespace notesApp0._2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            nameApp = new Label();
            btn_add_notes = new Button();
            textBoxSearch = new TextBox();
            button1 = new Button();
            NotesListBox = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // nameApp
            // 
            nameApp.AutoSize = true;
            nameApp.BackColor = Color.Transparent;
            nameApp.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nameApp.ForeColor = Color.White;
            nameApp.Location = new Point(12, 9);
            nameApp.Name = "nameApp";
            nameApp.Size = new Size(83, 32);
            nameApp.TabIndex = 0;
            nameApp.Text = "Notes";
            // 
            // btn_add_notes
            // 
            btn_add_notes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_add_notes.AutoSize = true;
            btn_add_notes.BackColor = Color.Transparent;
            btn_add_notes.BackgroundImageLayout = ImageLayout.Center;
            btn_add_notes.FlatAppearance.BorderSize = 0;
            btn_add_notes.FlatStyle = FlatStyle.Flat;
            btn_add_notes.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_notes.ForeColor = Color.White;
            btn_add_notes.Location = new Point(379, 0);
            btn_add_notes.Name = "btn_add_notes";
            btn_add_notes.RightToLeft = RightToLeft.No;
            btn_add_notes.Size = new Size(46, 44);
            btn_add_notes.TabIndex = 2;
            btn_add_notes.Text = "+";
            btn_add_notes.UseCompatibleTextRendering = true;
            btn_add_notes.UseMnemonic = false;
            btn_add_notes.UseVisualStyleBackColor = true;
            btn_add_notes.Click += Btn_add_notes_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(17, 57);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(349, 23);
            textBoxSearch.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(379, 50);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(46, 41);
            button1.TabIndex = 4;
            button1.Text = "⇄";
            button1.UseCompatibleTextRendering = true;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            // 
            // NotesListBox
            // 
            NotesListBox.FormattingEnabled = true;
            NotesListBox.ItemHeight = 15;
            NotesListBox.Location = new Point(17, 101);
            NotesListBox.Name = "NotesListBox";
            NotesListBox.Size = new Size(394, 529);
            NotesListBox.TabIndex = 5;
            NotesListBox.MouseDoubleClick += NotesListBox_MouseDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImageLayout = ImageLayout.Center;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(331, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(46, 44);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "x";
            btnDelete.UseCompatibleTextRendering = true;
            btnDelete.UseMnemonic = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Black;
            ClientSize = new Size(423, 646);
            Controls.Add(btnDelete);
            Controls.Add(NotesListBox);
            Controls.Add(button1);
            Controls.Add(textBoxSearch);
            Controls.Add(btn_add_notes);
            Controls.Add(nameApp);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameApp;
        private Button btn_add_notes;
        private TextBox textBoxSearch;
        private Button button1;
        private ListBox NotesListBox;
        private Button btnDelete;
    }
}