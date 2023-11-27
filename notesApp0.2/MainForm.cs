using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace notesApp0._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void AddNewNotes(string notesToAdd)
        {
            NotesListBox.Items.Add(notesToAdd);
        }
        public void EditNotes(string notesEdit)
        {
            NotesListBox.Items.Insert(0, notesEdit);
        }

        private void Btn_add_notes_Click(object sender, EventArgs e)
        {
            var NotesForm = new NotesForm(this); // pass an instance firstfrom in second form
            NotesForm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            NotesListBox.Items.RemoveAt(NotesListBox.SelectedIndex);
        }

        public void NotesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var NotesForm = new NotesForm(this); // pass an instance firstfrom in second form
            NotesForm.Show();
            
            // get index
            int index = this.NotesListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }

        }
    }
}