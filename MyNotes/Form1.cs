using Microsoft.VisualBasic;
using MaterialSkin.Controls;
using System.ComponentModel;


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
            Panel Panel_ = new Panel();
            Panel_.Dock = DockStyle.Top;
            Panel_.Click += Panel_Click;
            Panel_.BackColor = Color.Yellow;
            Panel_.MouseLeave += Panel_MouseLeave;
            Panel_.Tag = note;

            Label title = new Label();
            title.Text = note.Title;
            title.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            title.AutoSize = true;

            title.Click += Panel_Click;
            title.MouseLeave += Panel_MouseLeave;
            Panel_.Controls.Add(title);
            title.Location = new Point((ClientSize.Width - title.Width) / 2, 10);

            Panel_.Size = new Size(ClientSize.Width, title.Height + 20);
            title.MaximumSize = new Size(Panel_.Width, 0);


            Label description = new Label();
            description.Text = note.Description;
            description.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            description.AutoSize = true;
            description.Location = new Point(10, title.Height + 30);
            description.MaximumSize = new Size(Panel_.Width - 20, 0);
            description.Visible = false;
            Panel_.Controls.Add(description);
            panel2.Controls.Add(Panel_);
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel clickedPanel) { panel = clickedPanel; }
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
                            panel.Size = new Size(ClientSize.Width, panel.Controls[0].Height + description.Height + 30);
                            if (lastExpandedPanel != null) {
                                lastExpandedPanel.BackColor = Color.Yellow;
                            }
                            lastExpandedPanel = panel;
                        }
                        else
                        {
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
                if (panel.BackColor == Color.FromArgb(50, 133, 200) || panel.BackColor == Color.FromArgb(39, 52, 222))
                {
                    panel.BackColor = Color.FromArgb(39, 150, 223);
                    return;
                }
            }
        }
        private void AddNewNoteButton_Click(object sender, EventArgs e)
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
