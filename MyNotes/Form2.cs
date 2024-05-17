using System;
using MaterialSkin.Controls;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace MyNotes
{
    public partial class Form2 : MaterialForm
    {
        public event Action<Note> Formm2;
        public Form2()
        {
            InitializeComponent();
            noteTitleTextBox.TextChanged += NoteTitleTextBox_TextChanged;
        }
        private void AddNoteForm_FormClosing(object sender, FormClosingEventArgs e) { }

        private void noteTitleLabel_Click(object sender, EventArgs e) { }

        private void NoteTitleTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noteTitleTextBox.Text)) {
                applyNoteButton.Enabled = false;
            }
            else
            {
                applyNoteButton.Enabled = true;
            }
        }       
        private void applyNoteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noteTitleTextBox.Text)) {
                applyNoteButton.Enabled = false;
                return;
            }
            Note note = new Note();
            note.Title = noteTitleTextBox.Text;
            note.Description = noteDescriptionTextBox.Text;
            Formm2?.Invoke(note); Close();
        }
        private void refreshNoteButton_Click(object sender, EventArgs e) {
            noteTitleTextBox.Text = string.Empty;
            noteDescriptionTextBox.Text = string.Empty;
        }
    }
}
