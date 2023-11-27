using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace notesApp0._2
{
    public partial class NotesForm : Form
    {
        private readonly MainForm _mainForm;
        public NotesForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Save link on ex MainForm
            
        }
        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string newEntry = textBoxEntry.Text.Trim(); // Get text from TextBox

            if (!string.IsNullOrEmpty(newEntry))
            {
                _mainForm.AddNewNotes(newEntry); // Add entry in listbox in MainForm
            }
            
        }
    }
}
