namespace GuessingGame
{
    partial class GuessingGame
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
            this.Word = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GuessedWord = new System.Windows.Forms.TextBox();
            this.wrongGuesses = new System.Windows.Forms.RichTextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Word
            // 
            this.Word.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.ForeColor = System.Drawing.SystemColors.Control;
            this.Word.Location = new System.Drawing.Point(3, 18);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(312, 24);
            this.Word.TabIndex = 0;
            this.Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Word.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.Word);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(336, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 28);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(38, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wrong Guess";
            // 
            // GuessedWord
            // 
            this.GuessedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessedWord.Location = new System.Drawing.Point(51, 79);
            this.GuessedWord.Name = "GuessedWord";
            this.GuessedWord.Size = new System.Drawing.Size(230, 29);
            this.GuessedWord.TabIndex = 2;
            this.GuessedWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wrongGuesses
            // 
            this.wrongGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongGuesses.Location = new System.Drawing.Point(336, 45);
            this.wrongGuesses.Name = "wrongGuesses";
            this.wrongGuesses.Size = new System.Drawing.Size(193, 103);
            this.wrongGuesses.TabIndex = 3;
            this.wrongGuesses.Text = "";
            // 
            // GuessButton
            // 
            this.GuessButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GuessButton.Location = new System.Drawing.Point(87, 114);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(145, 34);
            this.GuessButton.TabIndex = 4;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 156);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.wrongGuesses);
            this.Controls.Add(this.GuessedWord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Word";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessedWord;
        private System.Windows.Forms.RichTextBox wrongGuesses;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label Word;
    }
}

