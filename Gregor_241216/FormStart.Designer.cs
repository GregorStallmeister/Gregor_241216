namespace Gregor_241216
{
    partial class Starrtfenster
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
            buttonKlickMich = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonKlickMich
            // 
            buttonKlickMich.Location = new Point(345, 12);
            buttonKlickMich.Name = "buttonKlickMich";
            buttonKlickMich.Size = new Size(94, 29);
            buttonKlickMich.TabIndex = 0;
            buttonKlickMich.Text = "Klick mich!";
            buttonKlickMich.UseVisualStyleBackColor = true;
            buttonKlickMich.Click += buttonKlickMich_Click;
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
            textBoxName.Location = new Point(111, 13);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 27);
            textBoxName.TabIndex = 2;
            // 
            // Starrtfenster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(buttonKlickMich);
            Name = "Starrtfenster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gregors Programm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKlickMich;
        private Label label1;
        private TextBox textBoxName;
    }
}
