using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountInBank
{
    public partial class Form1 : Form
    {
        List<Account> accountList = new List<Account>();
        Account nowLoginAccount = null;
        Random random;
        public Form1()
        {
            InitializeComponent();
            accountTypeComboBox.SelectedIndex = 0; // 设置第一个选项为默认选项
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountTextBox.Text;
            string password = passwordTextBox.Text;
            bool isLoginSuccessful = false;
            foreach (Account acc in accountList)
            {
                if (acc.accountNumber == accountNumber && acc.password == password)
                {
                    isLoginSuccessful = true;
                    nowLoginAccount = acc;
                    break;
                }
            }

            if (isLoginSuccessful)
            {
                loginLabel.Text = "Login successful";
                loginLabel.ForeColor = Color.Green;
            }
            else
            {
                loginLabel.Text = "Incorrect account number or password";
                loginLabel.ForeColor = Color.Red;
                nowLoginAccount = null;
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // 获取输入的账号和密码
            string accountNumber = accountTextBox.Text;
            string password = passwordTextBox.Text;

            // 根据选择的账号类型创建相应的对象
            if (accountTypeComboBox.SelectedItem.ToString() == "Deposit")
            {
                Account account = new Account(accountNumber, password);
                accountList.Add(account);
            }
            else if (accountTypeComboBox.SelectedItem.ToString() == "Credit")
            {
                CreditAccount creditAccount = new CreditAccount(accountNumber, password);
                accountList.Add((creditAccount));
            }

        }
        // 存钱按钮的点击事件处理
        private void DepositButton_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(saveBox.Text); // 从金额文本框中获取存款金额
            int randomNumber = random.Next(100);

            if (randomNumber < 30)
            {
                // 30% 的概率出现假钱
                saveResultLabel.ForeColor = Color.Red;
                saveResultLabel.Text = "Fake money!";
                return;
            }
            // 执行存钱操作
            nowLoginAccount.Deposit(amount);
            // 触发 BigMoneyFetched 事件
            if (amount > 10000)
            {
                BigMoneyArgs args = new BigMoneyArgs(nowLoginAccount, amount);
                OnBigMoneyFetched(args);
                saveResultLabel.ForeColor = Color.Green;
                saveResultLabel.Text = "Big Money Fetched! \nSuccessfully Deposit!\n" + "Balance: " + nowLoginAccount.Balance.ToString();
            }
            else
            {
                saveResultLabel.ForeColor = Color.Green;
                saveResultLabel.Text = "Successfully Deposit!\n" + "Balance: " + nowLoginAccount.Balance.ToString();
            }


        }

        // 取钱按钮的点击事件处理
        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(withdrawBox.Text); // 从金额文本框中获取取款金额

            try
            {
                // 执行取钱操作
                nowLoginAccount.Withdraw(amount);
                withdrawResultLabel.ForeColor = Color.Green;
                withdrawResultLabel.Text = "Successfully Withdral!\n" + "Balance: " + nowLoginAccount.Balance.ToString();

            }
            catch (InsufficientFundsException ex)
            {
                // 处理余额不足的情况
                withdrawResultLabel.ForeColor = Color.Red;
                withdrawResultLabel.Text = "Insufficient funds!\n" + "Balance " + nowLoginAccount.Balance.ToString() + " is less than your request money!";
                MessageBox.Show(ex.Message);
            }
        }

        // BigMoneyFetched 事件的处理方法
        private void OnBigMoneyFetched(BigMoneyArgs e)
        {
            // 处理 BigMoneyFetched 事件的逻辑
            // ...
        }
    }
}
