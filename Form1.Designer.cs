namespace lab2;

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
        dataGridView1 = new DataGridView();
        textBox1 = new TextBox();
        label1 = new Label();
        button1 = new Button();
        menuStrip1 = new MenuStrip();
        toolStripMenuItem1 = new ToolStripMenuItem();
        AddItemToolStripMenuItem = new ToolStripMenuItem();
        AddCustomerToolStripMenuItem = new ToolStripMenuItem();
        button2 = new Button();
        button3 = new Button();
        groupBox1 = new GroupBox();
        comboBox1 = new ComboBox();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        menuStrip1.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(453, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(635, 533);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(32, 53);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(184, 27);
        textBox1.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(38, 30);
        label1.Name = "label1";
        label1.Size = new Size(164, 20);
        label1.TabIndex = 2;
        label1.Text = "Введите номер заказа";
        label1.Click += label1_Click;
        // 
        // button1
        // 
        button1.Location = new Point(69, 86);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 3;
        button1.Text = "Добавить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1100, 28);
        menuStrip1.TabIndex = 5;
        menuStrip1.Text = "menuStrip1";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { AddItemToolStripMenuItem, AddCustomerToolStripMenuItem });
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(200, 24);
        toolStripMenuItem1.Text = "Добавить элемент класса";
        toolStripMenuItem1.Click += toolStripMenuItem1_Click;
        // 
        // AddItemToolStripMenuItem
        // 
        AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
        AddItemToolStripMenuItem.Size = new Size(242, 26);
        AddItemToolStripMenuItem.Text = "Добавить товар";
        AddItemToolStripMenuItem.Click += AddItemToolStripMenuItem_Click;
        // 
        // AddCustomerToolStripMenuItem
        // 
        AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
        AddCustomerToolStripMenuItem.Size = new Size(242, 26);
        AddCustomerToolStripMenuItem.Text = "Добавить покупателя";
        AddCustomerToolStripMenuItem.Click += AddCustomerToolStripMenuItem_Click;
        // 
        // button2
        // 
        button2.Location = new Point(12, 479);
        button2.Name = "button2";
        button2.Size = new Size(148, 66);
        button2.TabIndex = 6;
        button2.Text = "Exit";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(295, 479);
        button3.Name = "button3";
        button3.Size = new Size(141, 66);
        button3.TabIndex = 7;
        button3.Text = "Add order";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox1);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(button1);
        groupBox1.Location = new Point(87, 89);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(250, 125);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Вывод заказов";
        // 
        // comboBox1
        // 
        comboBox1.Location = new Point(138, 312);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(151, 28);
        comboBox1.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(156, 289);
        label2.Name = "label2";
        label2.Size = new Size(108, 20);
        label2.TabIndex = 10;
        label2.Text = "Order numbers";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 557);
        Controls.Add(label2);
        Controls.Add(comboBox1);
        Controls.Add(groupBox1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(dataGridView1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Текущие заказы";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private TextBox textBox1;
    private Label label1;
    private Button button1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem AddItemToolStripMenuItem;
    private ToolStripMenuItem AddCustomerToolStripMenuItem;
    private Button button2;
    private Button button3;
    private GroupBox groupBox1;
    private ComboBox comboBox1;
    private Label label2;
}