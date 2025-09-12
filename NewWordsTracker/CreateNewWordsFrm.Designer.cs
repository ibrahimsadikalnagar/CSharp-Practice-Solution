namespace NewWordsTracker
{
    partial class CreateNewWordsFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewWord = new System.Windows.Forms.TextBox();
            this.textBoxMeaning = new System.Windows.Forms.TextBox();
            this.listBoxNewWords = new System.Windows.Forms.ListBox();
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meaning";
            // 
            // textBoxNewWord
            // 
            this.textBoxNewWord.Location = new System.Drawing.Point(92, 91);
            this.textBoxNewWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNewWord.Name = "textBoxNewWord";
            this.textBoxNewWord.Size = new System.Drawing.Size(174, 24);
            this.textBoxNewWord.TabIndex = 3;
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.Location = new System.Drawing.Point(359, 91);
            this.textBoxMeaning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(211, 24);
            this.textBoxMeaning.TabIndex = 4;
            // 
            // listBoxNewWords
            // 
            this.listBoxNewWords.FormattingEnabled = true;
            this.listBoxNewWords.ItemHeight = 16;
            this.listBoxNewWords.Location = new System.Drawing.Point(295, 163);
            this.listBoxNewWords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxNewWords.Name = "listBoxNewWords";
            this.listBoxNewWords.Size = new System.Drawing.Size(275, 116);
            this.listBoxNewWords.TabIndex = 5;
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.Location = new System.Drawing.Point(22, 198);
            this.btnAddNewWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(74, 27);
            this.btnAddNewWord.TabIndex = 6;
            this.btnAddNewWord.Text = "Save";
            this.btnAddNewWord.UseVisualStyleBackColor = true;
            this.btnAddNewWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(22, 252);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(74, 27);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // CreateNewWordsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 303);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.btnAddNewWord);
            this.Controls.Add(this.listBoxNewWords);
            this.Controls.Add(this.textBoxMeaning);
            this.Controls.Add(this.textBoxNewWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateNewWordsFrm";
            this.Text = "New word form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewWord;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.ListBox listBoxNewWords;
        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.Button buttonClose;
    }
}

