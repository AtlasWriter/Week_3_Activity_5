namespace Week_3_Activity_5
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filechoose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveToFile = new System.Windows.Forms.Button();
            this.fullFileView = new System.Windows.Forms.TextBox();
            this.lowerCase = new System.Windows.Forms.TextBox();
            this.wordWithMostVowels = new System.Windows.Forms.TextBox();
            this.longestWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.saveToFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Evaluation - Please Select Your File:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.filechoose);
            this.groupBox1.Location = new System.Drawing.Point(66, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Selection";
            // 
            // filechoose
            // 
            this.filechoose.Location = new System.Drawing.Point(74, 41);
            this.filechoose.Name = "filechoose";
            this.filechoose.Size = new System.Drawing.Size(147, 43);
            this.filechoose.TabIndex = 3;
            this.filechoose.Text = "Choose file";
            this.filechoose.UseVisualStyleBackColor = true;
            this.filechoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveToFile);
            this.groupBox2.Controls.Add(this.fullFileView);
            this.groupBox2.Controls.Add(this.lowerCase);
            this.groupBox2.Controls.Add(this.wordWithMostVowels);
            this.groupBox2.Controls.Add(this.longestWord);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(397, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Evaluations:";
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(91, 260);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(147, 43);
            this.saveToFile.TabIndex = 4;
            this.saveToFile.Text = "Save to File";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fullFileView
            // 
            this.fullFileView.Location = new System.Drawing.Point(6, 51);
            this.fullFileView.Name = "fullFileView";
            this.fullFileView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fullFileView.Size = new System.Drawing.Size(305, 22);
            this.fullFileView.TabIndex = 4;
            this.fullFileView.WordWrap = false;
            // 
            // lowerCase
            // 
            this.lowerCase.Location = new System.Drawing.Point(6, 101);
            this.lowerCase.Name = "lowerCase";
            this.lowerCase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lowerCase.Size = new System.Drawing.Size(305, 22);
            this.lowerCase.TabIndex = 7;
            // 
            // wordWithMostVowels
            // 
            this.wordWithMostVowels.Location = new System.Drawing.Point(6, 209);
            this.wordWithMostVowels.Name = "wordWithMostVowels";
            this.wordWithMostVowels.Size = new System.Drawing.Size(305, 22);
            this.wordWithMostVowels.TabIndex = 10;
            // 
            // longestWord
            // 
            this.longestWord.Location = new System.Drawing.Point(6, 154);
            this.longestWord.Name = "longestWord";
            this.longestWord.Size = new System.Drawing.Size(305, 22);
            this.longestWord.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Longest Word:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Word witth most Vowels";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lower-Case:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full File View:";
            // 
            // userOpenFile
            // 
            this.userOpenFile.FileName = "saz98iAQ\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(737, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button filechoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog userOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wordWithMostVowels;
        private System.Windows.Forms.TextBox longestWord;
        private System.Windows.Forms.TextBox lowerCase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullFileView;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.SaveFileDialog saveToFileDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

