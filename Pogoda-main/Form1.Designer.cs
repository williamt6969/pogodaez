using PogodnaPogoda;
using Newtonsoft.Json;
namespace PogodnaPogoda
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            temperatureTextBox = new TextBox();
            temperatureLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(63, 179);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(653, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            //
            // button1
            //
            button1.BackColor = Color.DarkGoldenrod;
            button1.Cursor = Cursors.Help;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(63, 306);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(112, 23);
            button1.TabIndex = 1;
            button1.Text = "Temperatura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.Location = new Point(12, 124);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(150, 23);
            temperatureTextBox.TabIndex = 2;
            temperatureTextBox.TextChanged += temperatureTextBox_TextChanged;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.BackColor = Color.Transparent;
            temperatureLabel.ForeColor = Color.Crimson;
            temperatureLabel.Location = new Point(53, 106);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(73, 15);
            temperatureLabel.TabIndex = 3;
            temperatureLabel.Text = "Temperatura";
            temperatureLabel.Click += temperatureLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(365, 106);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Wilgotność";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.Cursor = Cursors.Help;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(310, 306);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(133, 23);
            button2.TabIndex = 6;
            button2.Text = "Wilgotność";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(227, 106);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "WMO";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGoldenrod;
            button3.Cursor = Cursors.Help;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(181, 306);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(123, 23);
            button3.TabIndex = 9;
            button3.Text = "WMO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(638, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(668, 106);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 11;
            label3.Text = "Prędkość wiatru";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGoldenrod;
            button4.Cursor = Cursors.Help;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(582, 306);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(134, 23);
            button4.TabIndex = 12;
            button4.Text = "Prędkość wiatru";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(480, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(512, 106);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 14;
            label4.Text = "Kierunek wiatru";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGoldenrod;
            button5.Cursor = Cursors.Help;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(449, 306);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(125, 23);
            button5.TabIndex = 15;
            button5.Text = "Kierunek wiatru";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(temperatureLabel);
            Controls.Add(temperatureTextBox);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox temperatureTextBox;
        private Label temperatureLabel;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private Button button4;
        private TextBox textBox4;
        private Label label4;
        private Button button5;
    }
}