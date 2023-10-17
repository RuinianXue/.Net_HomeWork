namespace AccountInBank
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.withdrawBox = new System.Windows.Forms.TextBox();
            this.saveBox = new System.Windows.Forms.TextBox();
            this.withdrawConfirmButton = new System.Windows.Forms.Button();
            this.withdrawResultLabel = new System.Windows.Forms.Label();
            this.saveResultLabel = new System.Windows.Forms.Label();
            this.saveConfirmButton = new System.Windows.Forms.Button();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(432, 51);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 18);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(576, 41);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(177, 28);
            this.passwordTextBox.TabIndex = 3;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(174, 41);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(177, 28);
            this.accountTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(787, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 33);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(20, 51);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(80, 18);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Account:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.accountTypeComboBox);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.accountTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 100);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(563, 538);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(560, 100);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(550, 538);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Location = new System.Drawing.Point(38, 130);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(89, 18);
            this.withdrawLabel.TabIndex = 3;
            this.withdrawLabel.Text = "Withdraw:";
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(587, 130);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(53, 18);
            this.saveLabel.TabIndex = 4;
            this.saveLabel.Text = "Save:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(787, 51);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(91, 30);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // withdrawBox
            // 
            this.withdrawBox.Location = new System.Drawing.Point(190, 127);
            this.withdrawBox.Name = "withdrawBox";
            this.withdrawBox.Size = new System.Drawing.Size(100, 28);
            this.withdrawBox.TabIndex = 5;
            // 
            // saveBox
            // 
            this.saveBox.Location = new System.Drawing.Point(746, 127);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(100, 28);
            this.saveBox.TabIndex = 6;
            // 
            // withdrawConfirmButton
            // 
            this.withdrawConfirmButton.Location = new System.Drawing.Point(375, 125);
            this.withdrawConfirmButton.Name = "withdrawConfirmButton";
            this.withdrawConfirmButton.Size = new System.Drawing.Size(88, 30);
            this.withdrawConfirmButton.TabIndex = 7;
            this.withdrawConfirmButton.Text = "Confirm";
            this.withdrawConfirmButton.UseVisualStyleBackColor = true;
            this.withdrawConfirmButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // withdrawResultLabel
            // 
            this.withdrawResultLabel.AutoSize = true;
            this.withdrawResultLabel.Location = new System.Drawing.Point(56, 239);
            this.withdrawResultLabel.Name = "withdrawResultLabel";
            this.withdrawResultLabel.Size = new System.Drawing.Size(0, 18);
            this.withdrawResultLabel.TabIndex = 8;
            // 
            // saveResultLabel
            // 
            this.saveResultLabel.AutoSize = true;
            this.saveResultLabel.Location = new System.Drawing.Point(691, 239);
            this.saveResultLabel.Name = "saveResultLabel";
            this.saveResultLabel.Size = new System.Drawing.Size(0, 18);
            this.saveResultLabel.TabIndex = 9;
            // 
            // saveConfirmButton
            // 
            this.saveConfirmButton.Location = new System.Drawing.Point(921, 125);
            this.saveConfirmButton.Name = "saveConfirmButton";
            this.saveConfirmButton.Size = new System.Drawing.Size(88, 30);
            this.saveConfirmButton.TabIndex = 10;
            this.saveConfirmButton.Text = "Confirm";
            this.saveConfirmButton.UseVisualStyleBackColor = true;
            this.saveConfirmButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Deposit",
            "Credit",
            "Others"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(931, 41);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.accountTypeComboBox.TabIndex = 6;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(38, 19);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 18);
            this.loginLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 638);
            this.Controls.Add(this.saveConfirmButton);
            this.Controls.Add(this.saveResultLabel);
            this.Controls.Add(this.withdrawResultLabel);
            this.Controls.Add(this.withdrawConfirmButton);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.withdrawBox);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.withdrawLabel);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "31";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.TextBox withdrawBox;
        private System.Windows.Forms.TextBox saveBox;
        private System.Windows.Forms.Button withdrawConfirmButton;
        private System.Windows.Forms.Label withdrawResultLabel;
        private System.Windows.Forms.Label saveResultLabel;
        private System.Windows.Forms.Button saveConfirmButton;
        private System.Windows.Forms.Label loginLabel;
    }
}

