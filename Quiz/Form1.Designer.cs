namespace Quiz
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
            this.tbQuestions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuestionNo = new System.Windows.Forms.TextBox();
            this.tbAnswers = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbQuestions
            // 
            this.tbQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuestions.Location = new System.Drawing.Point(12, 32);
            this.tbQuestions.Name = "tbQuestions";
            this.tbQuestions.ReadOnly = true;
            this.tbQuestions.Size = new System.Drawing.Size(1425, 22);
            this.tbQuestions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // tbQuestionNo
            // 
            this.tbQuestionNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuestionNo.Location = new System.Drawing.Point(87, 6);
            this.tbQuestionNo.Name = "tbQuestionNo";
            this.tbQuestionNo.ReadOnly = true;
            this.tbQuestionNo.Size = new System.Drawing.Size(100, 22);
            this.tbQuestionNo.TabIndex = 2;
            // 
            // tbAnswers
            // 
            this.tbAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnswers.Location = new System.Drawing.Point(14, 65);
            this.tbAnswers.Multiline = true;
            this.tbAnswers.Name = "tbAnswers";
            this.tbAnswers.ReadOnly = true;
            this.tbAnswers.Size = new System.Drawing.Size(1425, 467);
            this.tbAnswers.TabIndex = 3;
            this.tbAnswers.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrev.Location = new System.Drawing.Point(593, 558);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "&Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(789, 559);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShow.Location = new System.Drawing.Point(692, 559);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(202, 6);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentFile.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 604);
            this.Controls.Add(this.lblCurrentFile);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tbAnswers);
            this.Controls.Add(this.tbQuestionNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuestions);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuestionNo;
        private System.Windows.Forms.TextBox tbAnswers;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblCurrentFile;
    }
}

