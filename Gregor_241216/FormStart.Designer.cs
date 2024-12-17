namespace Gregor_241216
{
    partial class Startfenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startfenster));
            buttonKlickMich = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxZitat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonKlickMich
            // 
            buttonKlickMich.Location = new Point(413, 12);
            buttonKlickMich.Name = "buttonKlickMich";
            buttonKlickMich.Size = new Size(94, 29);
            buttonKlickMich.TabIndex = 0;
            buttonKlickMich.Text = "Klick mich!";
            buttonKlickMich.UseVisualStyleBackColor = true;
            buttonKlickMich.Click += ButtonKlickMich_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Wer bist Du?";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(111, 13);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(296, 27);
            textBoxName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBoxZitat
            // 
            textBoxZitat.BorderStyle = BorderStyle.FixedSingle;
            textBoxZitat.Location = new Point(12, 60);
            textBoxZitat.Multiline = true;
            textBoxZitat.Name = "textBoxZitat";
            textBoxZitat.ReadOnly = true;
            textBoxZitat.Size = new Size(495, 208);
            textBoxZitat.TabIndex = 4;
            // 
            // Startfenster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxZitat);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(buttonKlickMich);
            Name = "Startfenster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gregors Programm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKlickMich;
        private Label label1;
        private TextBox textBoxName;
        private PictureBox pictureBox1;
        private TextBox textBoxZitat;
    }
}
