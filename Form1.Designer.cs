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
            btnEquals = new Button();
            btnComa = new Button();
            btnZero = new Button();
            btnClear = new Button();
            btnAddsubtract = new Button();
            btnTree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnDivide = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
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
            tableLayoutPanel1.Size = new Size(354, 400);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(3, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(348, 74);
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
            tableLayoutPanel2.Controls.Add(btnEquals, 3, 3);
            tableLayoutPanel2.Controls.Add(btnComa, 2, 3);
            tableLayoutPanel2.Controls.Add(btnZero, 1, 3);
            tableLayoutPanel2.Controls.Add(btnClear, 0, 3);
            tableLayoutPanel2.Controls.Add(btnAddsubtract, 3, 2);
            tableLayoutPanel2.Controls.Add(btnTree, 2, 2);
            tableLayoutPanel2.Controls.Add(btnTwo, 1, 2);
            tableLayoutPanel2.Controls.Add(btnOne, 0, 2);
            tableLayoutPanel2.Controls.Add(btnDivide, 3, 1);
            tableLayoutPanel2.Controls.Add(btnSix, 2, 1);
            tableLayoutPanel2.Controls.Add(btnFive, 1, 1);
            tableLayoutPanel2.Controls.Add(btnFour, 0, 1);
            tableLayoutPanel2.Controls.Add(btnMultiply, 3, 0);
            tableLayoutPanel2.Controls.Add(btnNine, 2, 0);
            tableLayoutPanel2.Controls.Add(btnEight, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSeven, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(348, 314);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnEquals
            // 
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Location = new Point(264, 237);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(81, 74);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += button16_Click;
            // 
            // btnComa
            // 
            btnComa.Dock = DockStyle.Fill;
            btnComa.Location = new Point(177, 237);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(81, 74);
            btnComa.TabIndex = 14;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = true;
            btnComa.Click += btnComa_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Location = new Point(90, 237);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(81, 74);
            btnZero.TabIndex = 13;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += button14_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(3, 237);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 74);
            btnClear.TabIndex = 12;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddsubtract
            // 
            btnAddsubtract.Dock = DockStyle.Fill;
            btnAddsubtract.Location = new Point(264, 159);
            btnAddsubtract.Name = "btnAddsubtract";
            btnAddsubtract.Size = new Size(81, 72);
            btnAddsubtract.TabIndex = 11;
            btnAddsubtract.Text = "+ / -";
            btnAddsubtract.UseVisualStyleBackColor = true;
            btnAddsubtract.Click += btnAddsubtract_Click;
            // 
            // btnTree
            // 
            btnTree.Dock = DockStyle.Fill;
            btnTree.Location = new Point(177, 159);
            btnTree.Name = "btnTree";
            btnTree.Size = new Size(81, 72);
            btnTree.TabIndex = 10;
            btnTree.Text = "3";
            btnTree.UseVisualStyleBackColor = true;
            btnTree.Click += btnTree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Location = new Point(90, 159);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(81, 72);
            btnTwo.TabIndex = 9;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Location = new Point(3, 159);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(81, 72);
            btnOne.TabIndex = 8;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Location = new Point(264, 81);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(81, 72);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Location = new Point(177, 81);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(81, 72);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Location = new Point(90, 81);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(81, 72);
            btnFive.TabIndex = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Location = new Point(3, 81);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(81, 72);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Location = new Point(264, 3);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(81, 72);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Location = new Point(177, 3);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(81, 72);
            btnNine.TabIndex = 2;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Location = new Point(90, 3);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(81, 72);
            btnEight.TabIndex = 1;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Location = new Point(3, 3);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(81, 72);
            btnSeven.TabIndex = 0;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 424);
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
        private Button btnEquals;
        private Button btnComa;
        private Button btnZero;
        private Button btnClear;
        private Button btnAddsubtract;
        private Button btnTree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnDivide;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
    }
}