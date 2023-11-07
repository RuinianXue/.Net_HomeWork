using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AStyleCSharpCodeEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            flagOriginal = false;
            flagDirectory = false;
        }
        public bool flagOriginal;
        public bool flagDirectory;
        private void originalTextBox_TextChanged(object sender, EventArgs e)
        {
            flagOriginal = true;
        }
        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {
            flagDirectory = true;
        }
        private void FormatButton_Click(object sender, EventArgs e)
        {
            if (originalCodeTextBox.Text == string.Empty)
            {
                originalCodeTextBox.Text = OriginalCode(directoryTextbox.Text);
                //MessageBox.Show("aaaa!");
            }
            else if(directoryTextbox.Text == string.Empty)
            {

            }else
            {
                MessageBox.Show("No code input!");
                return;
            }
            string[] code = originalCodeTextBox.Lines;

            string[] formattedCode = ModifyLines(code);
            formattedCodeTextBox.Lines = formattedCode;
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            originalCodeTextBox.Text = null;
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            formattedCodeTextBox.Text = null;
            statisticsLabel.Text = null;
        }

        private string OriginalCode(string filePath)
        {
            try
            {
                // Read the contents of the file
                string code = File.ReadAllText(filePath);
                return code;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the file: " + ex.Message);
                return null;
            }
        }
        private string[] ModifyLines(string[] lines)
        {
            int originalLineCount = lines.Length;
            int originalWordCount = CountWords(lines);
            lines = RemoveEmptyLinesAndComments(lines);
            int newLineCount = lines.Length;
            int newWordCount = CountWords(lines);
            Dictionary<string, int> wordOccurrences = CountWordOccurrences(lines);
            statisticsLabel.Text = $"Original Line Count: {originalLineCount}\r\n" +
                         $"Original Word Count: {originalWordCount}\r\n" +
                         $"New Line Count: {newLineCount}\r\n" +
                         $"New Word Count: {newWordCount}\r\n";
            return lines;
        }
        private int CountWords(string[] lines)
        {
            int wordCount = 0;
            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
            return wordCount;
        }

        private string[] RemoveEmptyLinesAndComments(string[] lines)
        {
            List<string> filteredLines = new List<string>();
            bool insideComment = false;
            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (insideComment)
                {
                    // 如果在注释内部，检查是否遇到注释结尾
                    if (trimmedLine.EndsWith("*/"))
                    {
                        insideComment = false;
                    }
                }
                else
                {
                    // 如果不在注释内部，检查是否遇到注释开头
                    if (trimmedLine.StartsWith("/*"))
                    {
                        insideComment = true;
                    }
                    else if (!string.IsNullOrWhiteSpace(trimmedLine) && !trimmedLine.StartsWith("//"))
                    {
                        // 如果不是注释行，也不是空行，则添加到过滤后的行列表中
                        filteredLines.Add(line);
                    }
                }
            }
            /*
            int test = 0;*/

            return filteredLines.ToArray();
        }

        private Dictionary<string, int> CountWordOccurrences(string[] lines)
        {
            Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();
            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (wordOccurrences.ContainsKey(word))
                    {
                        wordOccurrences[word]++;
                    }
                    else
                    {
                        wordOccurrences[word] = 1;
                    }
                }
            }
            return wordOccurrences;
        }

        private void directoryTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string formattedText = formattedCodeTextBox.Text;
            Clipboard.SetText(formattedText);
            MessageBox.Show("Successfully copy to clipboard!");
        }
    }
}
