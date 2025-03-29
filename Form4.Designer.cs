namespace lab2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(437, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 71);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Срочность доставки";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(8, 43);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(159, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Обычная доставка";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(8, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(158, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Экспресс доставка";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 366);
            button1.Name = "button1";
            button1.Size = new Size(148, 47);
            button1.TabIndex = 9;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(481, 366);
            button2.Name = "button2";
            button2.Size = new Size(151, 47);
            button2.TabIndex = 10;
            button2.Text = "Создать заказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(106, 20);
            label1.TabIndex = 11;
            label1.Text = "Номер заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 87);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 12;
            label2.Text = "Дата поступления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 87);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 13;
            label3.Text = "Адрес доставки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 14;
            label4.Text = "Заказчик";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(169, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 166);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 16;
            label5.Text = "Товар";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(326, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            textBox3.Text = "0";
            textBox3.Click += textBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 166);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 18;
            label6.Text = "Кол-во";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 425);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
    }
}