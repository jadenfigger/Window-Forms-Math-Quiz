
namespace Times_Math_Quiz
{
    partial class form1
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
            this.A = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.textCorrect = new System.Windows.Forms.TextBox();
            this.textWrong = new System.Windows.Forms.TextBox();
            this.QuestionTrackerText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.DodgerBlue;
            this.A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A.Location = new System.Drawing.Point(7, 300);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(720, 200);
            this.A.TabIndex = 0;
            this.A.Text = "button1";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.Answer_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.DodgerBlue;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(7, 506);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(720, 200);
            this.C.TabIndex = 1;
            this.C.Text = "button1";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.Answer_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.DodgerBlue;
            this.D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D.Location = new System.Drawing.Point(733, 506);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(720, 200);
            this.D.TabIndex = 3;
            this.D.Text = "button2";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.Answer_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.DodgerBlue;
            this.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B.Location = new System.Drawing.Point(733, 300);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(720, 200);
            this.B.TabIndex = 2;
            this.B.Text = "button1";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.Answer_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.Color.LightGray;
            this.QuestionTextBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionTextBox.Location = new System.Drawing.Point(287, 27);
            this.QuestionTextBox.MinimumSize = new System.Drawing.Size(777, 30);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(900, 250);
            this.QuestionTextBox.TabIndex = 4;
            this.QuestionTextBox.Text = "What is the square root of 144 times the square root of 256?";
            this.QuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCorrect
            // 
            this.textCorrect.BackColor = System.Drawing.Color.LightGray;
            this.textCorrect.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCorrect.Location = new System.Drawing.Point(13, 27);
            this.textCorrect.Name = "textCorrect";
            this.textCorrect.Size = new System.Drawing.Size(209, 63);
            this.textCorrect.TabIndex = 5;
            this.textCorrect.Text = "Correct:  0";
            // 
            // textWrong
            // 
            this.textWrong.BackColor = System.Drawing.Color.LightGray;
            this.textWrong.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWrong.Location = new System.Drawing.Point(13, 96);
            this.textWrong.Name = "textWrong";
            this.textWrong.Size = new System.Drawing.Size(209, 63);
            this.textWrong.TabIndex = 6;
            this.textWrong.Text = "Wrong:  0";
            // 
            // QuestionTrackerText
            // 
            this.QuestionTrackerText.BackColor = System.Drawing.Color.LightGray;
            this.QuestionTrackerText.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionTrackerText.Location = new System.Drawing.Point(1193, 27);
            this.QuestionTrackerText.Name = "QuestionTrackerText";
            this.QuestionTrackerText.Size = new System.Drawing.Size(260, 58);
            this.QuestionTrackerText.TabIndex = 7;
            this.QuestionTrackerText.Text = "Question:  0/9";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1465, 711);
            this.Controls.Add(this.QuestionTrackerText);
            this.Controls.Add(this.textWrong);
            this.Controls.Add(this.textCorrect);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.D);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.A);
            this.Name = "form1";
            this.Text = "Timed Math Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button AnswerD;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.TextBox textCorrect;
        private System.Windows.Forms.TextBox textWrong;
        private System.Windows.Forms.TextBox QuestionTrackerText;
    }
}

