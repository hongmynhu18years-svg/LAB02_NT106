using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        // Sự kiện nút READ FILE
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FileName = "input3.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    rtxInputFile.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện nút SAVE FILE
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxInputFile.Text))
            {
                MessageBox.Show("Vui lòng đọc file hoặc nhập nội dung biểu thức trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string[] lines = rtxInputFile.Lines;
                List<string> results = new List<string>();

                foreach (var line in lines)
                {
                    string trimmedLine = line.Trim();
                    if (string.IsNullOrEmpty(trimmedLine)) continue;

                    try
                    {
                        double kq = EvaluateExpression(trimmedLine);
                        string formattedResult = (kq % 1 == 0) ? kq.ToString("0") : kq.ToString();
                        results.Add($"{trimmedLine} = {formattedResult}");
                    }
                    catch
                    {
                        results.Add($"{trimmedLine} = Lỗi biểu thức");
                    }
                }

                string outputContent = string.Join(Environment.NewLine, results);
                rtxOutputFile.Text = outputContent;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "output3.txt";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, outputContent);
                    MessageBox.Show("Đã lưu kết quả thành công vào file output3.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý và ghi file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Thuật toán tính toán biểu thức (Shunting-yard Algorithm)
        private double EvaluateExpression(string expression)
        {
            var tokens = Tokenize(expression);
            var rpn = InfixToPostfix(tokens);
            return EvaluatePostfix(rpn);
        }

        private List<string> Tokenize(string expr)
        {
            var tokens = new List<string>();
            string number = "";
            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    if (!char.IsWhiteSpace(c))
                    {
                        tokens.Add(c.ToString());
                    }
                }
            }
            if (number != "")
            {
                tokens.Add(number);
            }
            return tokens;
        }

        private int GetPrecedence(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }

        private List<string> InfixToPostfix(List<string> tokens)
        {
            var output = new List<string>();
            var stack = new Stack<string>();

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        output.Add(stack.Pop());
                    }
                    if (stack.Count > 0 && stack.Peek() == "(")
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0 && GetPrecedence(stack.Peek()) >= GetPrecedence(token))
                    {
                        output.Add(stack.Pop());
                    }
                    stack.Push(token);
                }
            }

            while (stack.Count > 0)
            {
                output.Add(stack.Pop());
            }

            return output;
        }

        private double EvaluatePostfix(List<string> rpn)
        {
            var stack = new Stack<double>();

            foreach (var token in rpn)
            {
                if (double.TryParse(token, out double val))
                {
                    stack.Push(val);
                }
                else
                {
                    if (stack.Count < 2) throw new Exception("Biểu thức không hợp lệ");
                    double b = stack.Pop();
                    double a = stack.Pop();
                    double res = 0;
                    switch (token)
                    {
                        case "+": res = a + b; break;
                        case "-": res = a - b; break;
                        case "*": res = a * b; break;
                        case "/":
                            if (b == 0) throw new DivideByZeroException();
                            res = a / b;
                            break;
                        default: throw new Exception("Toán tử không hợp lệ");
                    }
                    stack.Push(res);
                }
            }

            if (stack.Count != 1) throw new Exception("Biểu thức không hợp lệ");
            return stack.Pop();
        }
    }
}