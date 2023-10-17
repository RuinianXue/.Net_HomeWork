namespace QuestionAndScore
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NewProblem = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.YourNameHere = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewProblem
            // 
            this.NewProblem.Location = new System.Drawing.Point(54, 27);
            this.NewProblem.Name = "NewProblem";
            this.NewProblem.Size = new System.Drawing.Size(161, 52);
            this.NewProblem.TabIndex = 0;
            this.NewProblem.Text = "New Problem";
            this.NewProblem.UseVisualStyleBackColor = true;
            this.NewProblem.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(296, 44);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(62, 18);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "label1";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(251, 118);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(319, 28);
            this.answerTextBox.TabIndex = 2;
            // 
            // YourNameHere
            // 
            this.YourNameHere.AutoSize = true;
            this.YourNameHere.Location = new System.Drawing.Point(51, 128);
            this.YourNameHere.Name = "YourNameHere";
            this.YourNameHere.Size = new System.Drawing.Size(161, 18);
            this.YourNameHere.TabIndex = 3;
            this.YourNameHere.Text = "Your Answer Here:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(628, 118);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(119, 38);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(296, 204);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 18);
            this.feedbackLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.YourNameHere);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.NewProblem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewProblem;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label YourNameHere;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label feedbackLabel;
    }
}

