using org.mariuszgromada.math.mxparser;
namespace simpleCalculator
{
    public partial class mainWindow : Form
    {
        private bool AddSubFlag = true;
        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e) //btnEquals
        {
            var result = calculations(textBox.Text);
            var resultTxt = result.ToString();
            textBox.Text = resultTxt;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btnAddsubtract_Click(object sender, EventArgs e)
        {

            var lastChar = textBox.Text.LastOrDefault();
            if(AddSubFlag && lastChar != default(char))
            {
                textBox.Text = lastChar == '-' ? textBox.Text
                    .Remove(textBox.Text.Length - 1, 1)
                    .Insert(textBox.Text.Length - 1, "+") : textBox.Text + "+";
                AddSubFlag = false;
            }
            else if(AddSubFlag == false && lastChar != default(char))
            {
                textBox.Text = lastChar == '+' ? textBox.Text
                    .Remove(textBox.Text.Length - 1, 1)
                    .Insert(textBox.Text.Length - 1,"-") : textBox.Text + "-";
                AddSubFlag = true;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "÷";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "x";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private double calculations(string equation)
        {
            Expression expression = new Expression(equation);
            return expression.calculate();
        }
    }
}