using MaterialSkin.Controls;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace MyNotes
{
    public partial class Form1 : MaterialForm
    {
        private BindingList<Note> Notes;
        private Panel lastExpandedPanel;
        public Form1()
        {
            InitializeComponent();
            Notes = new BindingList<Note>();
        }
        private void CreateNotePanel(Note note)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Click += Panel_Click;
            panel.MouseLeave += Panel_MouseLeave;
            panel.BackColor = Color.Yellow;
            panel.Tag = note;

            Label title = new Label();
            title.Text = note.Title;
            title.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            title.AutoSize = true;
            title.Click += Panel_Click;
            title.MouseLeave += Panel_MouseLeave;
            panel.Controls.Add(title);
            title.Location = new Point((ClientSize.Width - title.Width) / 2, 10);

            panel.Size = new Size(ClientSize.Width, title.Height + 20);
            title.MaximumSize = new Size(panel.Width, 0);

            Label description = new Label();
            description.Text = note.Description;
            description.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            description.AutoSize = true;
            description.Location = new Point(10, title.Height + 30);
            description.MaximumSize = new Size(panel.Width - 20, 0);
            description.Visible = false;

            panel.Controls.Add(description);
            panel2.Controls.Add(panel);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel clickedPanel)
            {
                panel = clickedPanel;
            }
            else if (sender is Label clickedLabel && clickedLabel.Parent is Panel parentPanel)
            {
                panel = parentPanel;
            }
            if (panel != null)
            {

                foreach (Control control in panel.Controls)
                {
                    if (control is Label description && control != panel.Controls[0])
                    {
                        description.Visible = !description.Visible;

                        if (description.Visible)
                        {
                            panel.BackColor = Color.FromArgb(45, 160, 252);
                            panel.Size = new Size(ClientSize.Width, panel.Controls[0].Height + description.Height + 30);
                            if (lastExpandedPanel != null)
                            {
                                lastExpandedPanel.BackColor = Color.Yellow;
                            }
                            lastExpandedPanel = panel;
                        }
                        else
                        {
                            panel.BackColor = Color.Yellow;
                            panel.Size = new Size(ClientSize.Width, panel.Controls[0].Height + 20);
                            if (lastExpandedPanel == panel)
                            {
                                lastExpandedPanel = null;
                            }
                        }
                        break;
                    }
                }
            }
        }    
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel clickedPanel)
            {
                panel = clickedPanel;
            }
            else if (sender is Label clickedLabel && clickedLabel.Parent is Panel parentPanel)
            {
                panel = parentPanel;
            }
            if (panel != null)
            {
                if (panel.BackColor == Color.FromArgb(45, 160, 252) || panel.BackColor == Color.FromArgb(45, 62, 252))
                {
                    panel.BackColor = Color.FromArgb(45, 160, 252);
                    return;
                }
                panel.BackColor = Color.Transparent;
            }
        }
        private void addNoteButton_Click(object sender, EventArgs e)
        {
            Form2 addNoteForm = new Form2();
            addNoteForm.Size = this.Size;
            addNoteForm.StartPosition = FormStartPosition.CenterParent;
            addNoteForm.Formm2 += AddNoteForm_AddNote;
            addNoteForm.ShowDialog();
        }
        private void AddNoteForm_AddNote(Note obj)
        {
            Notes.Add(obj);
            CreateNotePanel(obj);
        }
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if (lastExpandedPanel != null)
            {
                Note note = lastExpandedPanel.Tag as Note;
                if (note != null)
                {
                    Notes.Remove(note);
                }
                panel2.Controls.Remove(lastExpandedPanel);
                lastExpandedPanel.Dispose();
                lastExpandedPanel = null;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
    public class Note
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public override string ToString()
        {
            return Title;
        }
    }
}
