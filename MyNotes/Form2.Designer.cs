namespace MyNotes
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
            noteTitleLabel = new Label();
            noteTitleTextBox = new TextBox();
            noteDescriptionLabel = new Label();
            noteDescriptionTextBox = new TextBox();
            applyNoteButton = new Button();
            refreshNoteButton = new Button();
            SuspendLayout();
            // 
            // noteTitleLabel
            // 
            noteTitleLabel.AutoSize = true;
            noteTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            noteTitleLabel.Location = new Point(15, 108);
            noteTitleLabel.Name = "noteTitleLabel";
            noteTitleLabel.Size = new Size(65, 25);
            noteTitleLabel.TabIndex = 4;
            noteTitleLabel.Text = "NAME";
            noteTitleLabel.Click += noteTitleLabel_Click;
            // 
            // noteTitleTextBox
            // 
            noteTitleTextBox.BackColor = SystemColors.Menu;
            noteTitleTextBox.BorderStyle = BorderStyle.None;
            noteTitleTextBox.Location = new Point(86, 108);
            noteTitleTextBox.Multiline = true;
            noteTitleTextBox.Name = "noteTitleTextBox";
            noteTitleTextBox.Size = new Size(201, 55);
            noteTitleTextBox.TabIndex = 5;
            // 
            // noteDescriptionLabel
            // 
            noteDescriptionLabel.AutoSize = true;
            noteDescriptionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            noteDescriptionLabel.Location = new Point(15, 194);
            noteDescriptionLabel.Name = "noteDescriptionLabel";
            noteDescriptionLabel.Size = new Size(58, 30);
            noteDescriptionLabel.TabIndex = 4;
            noteDescriptionLabel.Text = "TEXT";
            // 
            // noteDescriptionTextBox
            // 
            noteDescriptionTextBox.BackColor = SystemColors.Menu;
            noteDescriptionTextBox.BorderStyle = BorderStyle.None;
            noteDescriptionTextBox.Location = new Point(86, 194);
            noteDescriptionTextBox.Multiline = true;
            noteDescriptionTextBox.Name = "noteDescriptionTextBox";
            noteDescriptionTextBox.Size = new Size(357, 203);
            noteDescriptionTextBox.TabIndex = 5;
            // 
            // applyNoteButton
            // 
            applyNoteButton.BackColor = SystemColors.InactiveBorder;
            applyNoteButton.BackgroundImage = Properties.Resources.vector_add_icon;
            applyNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            applyNoteButton.Cursor = Cursors.Hand;
            applyNoteButton.ForeColor = SystemColors.ControlText;
            applyNoteButton.Location = new Point(486, 90);
            applyNoteButton.Name = "applyNoteButton";
            applyNoteButton.Size = new Size(50, 50);
            applyNoteButton.TabIndex = 2;
            applyNoteButton.UseVisualStyleBackColor = false;
            applyNoteButton.Click += applyNoteButton_Click;
            // 
            // refreshNoteButton
            // 
            refreshNoteButton.BackgroundImage = Properties.Resources.delete_icon;
            refreshNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            refreshNoteButton.Location = new Point(551, 90);
            refreshNoteButton.Name = "refreshNoteButton";
            refreshNoteButton.Size = new Size(50, 50);
            refreshNoteButton.TabIndex = 3;
            refreshNoteButton.UseVisualStyleBackColor = false;
            refreshNoteButton.Click += refreshNoteButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(700, 450);
            Controls.Add(refreshNoteButton);
            Controls.Add(applyNoteButton);
            Controls.Add(noteDescriptionTextBox);
            Controls.Add(noteDescriptionLabel);
            Controls.Add(noteTitleTextBox);
            Controls.Add(noteTitleLabel);
            MaximizeBox = false;
            MinimumSize = new Size(500, 400);
            Name = "Form2";
            Padding = new Padding(3, 60, 3, 3);
            Text = "MY NOTES";
            FormClosing += AddNoteForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label noteTitleLabel;
        private TextBox noteTitleTextBox;
        private Label noteDescriptionLabel;
        private TextBox noteDescriptionTextBox;
        private Button applyNoteButton;
        private Button refreshNoteButton;
    }
}