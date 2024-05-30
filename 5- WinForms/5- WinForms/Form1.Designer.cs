namespace _5__WinForms
{
    partial class Form1
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
            if(disposing && (components != null))
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
            num1 = new TextBox();
            button1 = new Button();
            num2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            Button7 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AccessibleName = "texto";
            num1.BackColor = Color.Snow;
            num1.Location = new Point(305, 66);
            num1.Name = "num1";
            num1.Size = new Size(240, 23);
            num1.TabIndex = 0;
            num1.TextAlign = HorizontalAlignment.Center;
            num1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(178, 25);
            button1.Name = "button1";
            button1.Size = new Size(149, 49);
            button1.TabIndex = 1;
            button1.Text = "Suma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // num2
            // 
            num2.AccessibleName = "texto";
            num2.BackColor = Color.Snow;
            num2.Location = new Point(305, 114);
            num2.Name = "num2";
            num2.Size = new Size(240, 23);
            num2.TabIndex = 2;
            num2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(490, 25);
            button2.Name = "button2";
            button2.Size = new Size(149, 49);
            button2.TabIndex = 3;
            button2.Text = "Suma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Número  1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 122);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Número 2";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 100);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 100);
            panel2.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleTurquoise;
            button6.Location = new Point(572, 25);
            button6.Name = "button6";
            button6.Size = new Size(149, 49);
            button6.TabIndex = 5;
            button6.Text = "División";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleTurquoise;
            button5.Location = new Point(396, 25);
            button5.Name = "button5";
            button5.Size = new Size(149, 49);
            button5.TabIndex = 4;
            button5.Text = "Multiplicación";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Location = new Point(55, 25);
            button3.Name = "button3";
            button3.Size = new Size(149, 49);
            button3.TabIndex = 1;
            button3.Text = "Suma";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.Location = new Point(221, 25);
            button4.Name = "button4";
            button4.Size = new Size(149, 49);
            button4.TabIndex = 3;
            button4.Text = "Resta";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aquamarine;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(num2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(num1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Cursor = Cursors.Cross;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(759, 529);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(Button7);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 527);
            panel4.TabIndex = 7;
            // 
            // Button7
            // 
            Button7.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button7.Location = new Point(54, 293);
            Button7.Name = "Button7";
            Button7.Size = new Size(121, 33);
            Button7.TabIndex = 6;
            Button7.Text = "Abrir otro form";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(759, 529);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox num1;
        private Button button1;
        private TextBox num2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private Panel panel3;
        private Button button6;
        private Button button5;
        private Button Button7;
        private Panel panel4;
    }
}
