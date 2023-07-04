namespace simpleCalculator
{
    partial class mainWindow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonEqual = new Button();
            buttonComa = new Button();
            button0 = new Button();
            buttonClear = new Button();
            buttonAddSub = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonMultiply = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonDivine = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonBackspace = new Button();
            buttonKungFu = new Button();
            buttonRightParenthesis = new Button();
            buttonLeftParenthesis = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(354, 425);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Font = new Font("Futura Md BT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(3, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(348, 79);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(buttonEqual, 3, 4);
            tableLayoutPanel2.Controls.Add(buttonComa, 2, 4);
            tableLayoutPanel2.Controls.Add(button0, 1, 4);
            tableLayoutPanel2.Controls.Add(buttonClear, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonAddSub, 3, 3);
            tableLayoutPanel2.Controls.Add(button3, 2, 3);
            tableLayoutPanel2.Controls.Add(button2, 1, 3);
            tableLayoutPanel2.Controls.Add(button1, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonMultiply, 3, 2);
            tableLayoutPanel2.Controls.Add(button6, 2, 2);
            tableLayoutPanel2.Controls.Add(button5, 1, 2);
            tableLayoutPanel2.Controls.Add(button4, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonDivine, 3, 1);
            tableLayoutPanel2.Controls.Add(button9, 2, 1);
            tableLayoutPanel2.Controls.Add(button8, 1, 1);
            tableLayoutPanel2.Controls.Add(button7, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonBackspace, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonKungFu, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonRightParenthesis, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonLeftParenthesis, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 88);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(348, 334);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonEqual
            // 
            buttonEqual.Dock = DockStyle.Fill;
            buttonEqual.Location = new Point(264, 267);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(81, 64);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonComa
            // 
            buttonComa.Dock = DockStyle.Fill;
            buttonComa.Location = new Point(177, 267);
            buttonComa.Name = "buttonComa";
            buttonComa.Size = new Size(81, 64);
            buttonComa.TabIndex = 18;
            buttonComa.Text = ",";
            buttonComa.UseVisualStyleBackColor = true;
            buttonComa.Click += buttonComa_Click;
            // 
            // button0
            // 
            button0.Dock = DockStyle.Fill;
            button0.Location = new Point(90, 267);
            button0.Name = "button0";
            button0.Size = new Size(81, 64);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Location = new Point(3, 267);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(81, 64);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAddSub
            // 
            buttonAddSub.Dock = DockStyle.Fill;
            buttonAddSub.Location = new Point(264, 201);
            buttonAddSub.Name = "buttonAddSub";
            buttonAddSub.Size = new Size(81, 60);
            buttonAddSub.TabIndex = 15;
            buttonAddSub.Text = "+/-";
            buttonAddSub.UseVisualStyleBackColor = true;
            buttonAddSub.Click += buttonAddSub_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(177, 201);
            button3.Name = "button3";
            button3.Size = new Size(81, 60);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(90, 201);
            button2.Name = "button2";
            button2.Size = new Size(81, 60);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 201);
            button1.Name = "button1";
            button1.Size = new Size(81, 60);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.Location = new Point(264, 135);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(81, 60);
            buttonMultiply.TabIndex = 11;
            buttonMultiply.Text = "X";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(177, 135);
            button6.Name = "button6";
            button6.Size = new Size(81, 60);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(90, 135);
            button5.Name = "button5";
            button5.Size = new Size(81, 60);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 135);
            button4.Name = "button4";
            button4.Size = new Size(81, 60);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonDivine
            // 
            buttonDivine.Dock = DockStyle.Fill;
            buttonDivine.Location = new Point(264, 69);
            buttonDivine.Name = "buttonDivine";
            buttonDivine.Size = new Size(81, 60);
            buttonDivine.TabIndex = 7;
            buttonDivine.Text = "÷";
            buttonDivine.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(177, 69);
            button9.Name = "button9";
            button9.Size = new Size(81, 60);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(90, 69);
            button8.Name = "button8";
            button8.Size = new Size(81, 60);
            button8.TabIndex = 5;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(3, 69);
            button7.Name = "button7";
            button7.Size = new Size(81, 60);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Dock = DockStyle.Fill;
            buttonBackspace.Location = new Point(264, 3);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(81, 60);
            buttonBackspace.TabIndex = 3;
            buttonBackspace.Text = "⌫";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonKungFu
            // 
            buttonKungFu.Dock = DockStyle.Fill;
            buttonKungFu.Location = new Point(177, 3);
            buttonKungFu.Name = "buttonKungFu";
            buttonKungFu.Size = new Size(81, 60);
            buttonKungFu.TabIndex = 2;
            buttonKungFu.Text = "KungFu";
            buttonKungFu.UseVisualStyleBackColor = true;
            buttonKungFu.Click += buttonKungFu_Click;
            // 
            // buttonRightParenthesis
            // 
            buttonRightParenthesis.Dock = DockStyle.Fill;
            buttonRightParenthesis.Location = new Point(90, 3);
            buttonRightParenthesis.Name = "buttonRightParenthesis";
            buttonRightParenthesis.Size = new Size(81, 60);
            buttonRightParenthesis.TabIndex = 1;
            buttonRightParenthesis.Text = ")";
            buttonRightParenthesis.UseVisualStyleBackColor = true;
            buttonRightParenthesis.Click += buttonRightParenthesis_Click;
            // 
            // buttonLeftParenthesis
            // 
            buttonLeftParenthesis.Dock = DockStyle.Fill;
            buttonLeftParenthesis.Location = new Point(3, 3);
            buttonLeftParenthesis.Name = "buttonLeftParenthesis";
            buttonLeftParenthesis.Size = new Size(81, 60);
            buttonLeftParenthesis.TabIndex = 0;
            buttonLeftParenthesis.Text = "(";
            buttonLeftParenthesis.UseVisualStyleBackColor = true;
            buttonLeftParenthesis.Click += buttonLeftParenthesis_Click;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 449);
            Controls.Add(tableLayoutPanel1);
            Name = "mainWindow";
            Text = "MatCalc";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonLeftParenthesis;
        private Button buttonEqual;
        private Button buttonComa;
        private Button button0;
        private Button buttonClear;
        private Button buttonAddSub;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonMultiply;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonDivine;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonBackspace;
        private Button buttonKungFu;
        private Button buttonRightParenthesis;
    }
}