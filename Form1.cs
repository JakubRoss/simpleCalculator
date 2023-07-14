using org.mariuszgromada.math.mxparser;
namespace simpleCalculator
{
    public partial class mainWindow : Form
    {
        private bool AddSubFlag = true;
        private string KungFu = "༼ つ ◕◡◕ ༽つ";
        private bool KungFuFlag = false;
        public mainWindow()
        {
            InitializeComponent();
            textBox.ReadOnly = true;
            textBox.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }
        private double calculations(string equation)
        {
            List<char> newEquation = new List<char>();
            foreach (var item in equation)
            {
                switch (item)
                {
                    case '÷':
                        newEquation.Add('/');
                        continue;
                    case 'x':
                        newEquation.Add('*');
                        continue;
                    case ',':
                        newEquation.Add('.');
                        continue;
                    default:
                        newEquation.Add(item);
                        continue;
                }
            }
            Expression expression = new Expression(string.Join("", newEquation));
            return expression.calculate();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
                var lastChar = textBox.Text.LastOrDefault();
            if (lastChar != 247 && lastChar != 120 && lastChar != default(char))
            {
                var result = calculations(textBox.Text);
                var resultTxt = result.ToString();
                textBox.Text = resultTxt;
            }
        }
        private void buttonBackspace_Click(object sender, EventArgs e)//
        {
            if (textBox.Text.Length > 0 && textBox.Text != KungFu)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            else if (textBox.Text.Contains(KungFu))
            {
                textBox.Text = string.Empty;
                KungFuFlag = false;
            }
            
        }
        private void buttonAddSub_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            var lastChar = textBox.Text.LastOrDefault();
            if (AddSubFlag && lastChar != default(char))
            {
                textBox.Text = lastChar == '-' ? textBox.Text
                    .Remove(textBox.Text.Length - 1, 1)
                    .Insert(textBox.Text.Length - 1, "+") : textBox.Text + "+";
                AddSubFlag = false;
            }
            else if (AddSubFlag == false && lastChar != default(char))
            {
                textBox.Text = lastChar == '+' ? textBox.Text
                    .Remove(textBox.Text.Length - 1, 1)
                    .Insert(textBox.Text.Length - 1, "-") : textBox.Text + "-";
                AddSubFlag = true;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)//
        {
            textBox.Text = string.Empty;
            KungFuFlag = false;
        }
        private void buttonKungFu_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text = KungFu;
            KungFuFlag = true;
        }

        #region chars
        private void button1_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "9";
        }
        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += ",";
        }
        private void buttonLeftParenthesis_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "(";
        }
        private void buttonRightParenthesis_Click(object sender, EventArgs e)
        {
            if (KungFuFlag || textBox.Text.Length <1)
                return;
            textBox.Text += ")";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "x";
        }
        private void buttonDivine_Click(object sender, EventArgs e)
        {
            if (KungFuFlag)
                return;
            textBox.Text += "÷";
        }
        #endregion
    }
}