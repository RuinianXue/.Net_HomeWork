namespace AStyleCSharpCodeEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryTextbox = new System.Windows.Forms.TextBox();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.formatButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formattedLabel = new System.Windows.Forms.Label();
            this.formattedCodeTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.originalLabel = new System.Windows.Forms.Label();
            this.originalCodeTextBox = new System.Windows.Forms.RichTextBox();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.directoryLabel);
            this.panel1.Controls.Add(this.directoryTextbox);
            this.panel1.Controls.Add(this.clearButton2);
            this.panel1.Controls.Add(this.clearButton1);
            this.panel1.Controls.Add(this.formatButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 163);
            this.panel1.TabIndex = 0;
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryLabel.Location = new System.Drawing.Point(42, 56);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(272, 28);
            this.directoryLabel.TabIndex = 4;
            this.directoryLabel.Text = "Your Directory Here:";
            // 
            // directoryTextbox
            // 
            this.directoryTextbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.directoryTextbox.Location = new System.Drawing.Point(348, 57);
            this.directoryTextbox.Name = "directoryTextbox";
            this.directoryTextbox.Size = new System.Drawing.Size(371, 31);
            this.directoryTextbox.TabIndex = 3;
            this.directoryTextbox.TextChanged += new System.EventHandler(this.directoryTextbox_TextChanged);
            // 
            // clearButton2
            // 
            this.clearButton2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton2.Location = new System.Drawing.Point(1040, 90);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(238, 44);
            this.clearButton2.TabIndex = 2;
            this.clearButton2.Text = "Clear Changed";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.ClearButton2_Click);
            // 
            // clearButton1
            // 
            this.clearButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton1.Location = new System.Drawing.Point(1040, 30);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(238, 44);
            this.clearButton1.TabIndex = 1;
            this.clearButton1.Text = "Clear Original";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // formatButton
            // 
            this.formatButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatButton.Location = new System.Drawing.Point(778, 56);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(136, 38);
            this.formatButton.TabIndex = 0;
            this.formatButton.Text = "Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.copyButton);
            this.panel2.Controls.Add(this.statisticsLabel);
            this.panel2.Controls.Add(this.formattedLabel);
            this.panel2.Controls.Add(this.formattedCodeTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1539, 469);
            this.panel2.TabIndex = 1;
            // 
            // formattedLabel
            // 
            this.formattedLabel.AutoSize = true;
            this.formattedLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedLabel.Location = new System.Drawing.Point(15, 17);
            this.formattedLabel.Name = "formattedLabel";
            this.formattedLabel.Size = new System.Drawing.Size(207, 28);
            this.formattedLabel.TabIndex = 1;
            this.formattedLabel.Text = "Formatted Code:";
            // 
            // formattedCodeTextBox
            // 
            this.formattedCodeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedCodeTextBox.Location = new System.Drawing.Point(61, 54);
            this.formattedCodeTextBox.Name = "formattedCodeTextBox";
            this.formattedCodeTextBox.Size = new System.Drawing.Size(1027, 307);
            this.formattedCodeTextBox.TabIndex = 0;
            this.formattedCodeTextBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.originalLabel);
            this.panel3.Controls.Add(this.originalCodeTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1539, 426);
            this.panel3.TabIndex = 2;
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(12, 14);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(194, 28);
            this.originalLabel.TabIndex = 1;
            this.originalLabel.Text = "Original Code:";
            // 
            // originalCodeTextBox
            // 
            this.originalCodeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalCodeTextBox.Location = new System.Drawing.Point(61, 52);
            this.originalCodeTextBox.Name = "originalCodeTextBox";
            this.originalCodeTextBox.Size = new System.Drawing.Size(1020, 306);
            this.originalCodeTextBox.TabIndex = 0;
            this.originalCodeTextBox.Text = "";
            this.originalCodeTextBox.TextChanged += new System.EventHandler(this.originalTextBox_TextChanged);
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsLabel.Location = new System.Drawing.Point(1159, 30);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(0, 28);
            this.statisticsLabel.TabIndex = 2;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(385, 391);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(319, 42);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy to Clickboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 1058);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox originalCodeTextBox;
        private System.Windows.Forms.Label formattedLabel;
        private System.Windows.Forms.RichTextBox formattedCodeTextBox;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryTextbox;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Button copyButton;
    }
}

