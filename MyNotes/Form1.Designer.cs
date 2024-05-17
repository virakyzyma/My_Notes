namespace MyNotes
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
            panel2 = new Panel();
            addNoteButton = new Button();
            deleteNoteButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(addNoteButton);
            panel2.Controls.Add(deleteNoteButton);
            panel2.Location = new Point(2, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 380);
            panel2.TabIndex = 4;
            // 
            // addNoteButton
            // 
            addNoteButton.BackgroundImage = Properties.Resources.vector_add_icon;
            addNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            addNoteButton.Cursor = Cursors.Hand;
            addNoteButton.Location = new Point(10, 3);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(50, 50);
            addNoteButton.TabIndex = 0;
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.BackgroundImage = Properties.Resources.delete_icon;
            deleteNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteNoteButton.Cursor = Cursors.Hand;
            deleteNoteButton.Location = new Point(621, 3);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Size = new Size(50, 50);
            deleteNoteButton.TabIndex = 1;
            deleteNoteButton.UseVisualStyleBackColor = false;
            deleteNoteButton.Click += deleteNoteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(685, 445);
            Controls.Add(panel2);
            MinimumSize = new Size(500, 400);
            Name = "Form1";
            Text = "MY NOTES";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button deleteNoteButton;
        private Button addNoteButton;
    }
}
