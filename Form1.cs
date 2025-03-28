namespace lab2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.Columns.Add("Number", "Номер");
        dataGridView1.Columns.Add("Client", "Клиент");
        dataGridView1.Columns.Add("Date", "Дата");
        dataGridView1.Columns.Add("Адрес", "Adress");
        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        checkBoxColumn.Name = "Urgency";
        checkBoxColumn.HeaderText = "Срочность";
        dataGridView1.Columns.Add(checkBoxColumn);
        //AddSampleData();
    }
    private void AddSampleData()
    {
        dataGridView1.Rows.Add(1, "Иванов Иван Иванович", "123-456-7890", true);
        dataGridView1.Rows.Add(2, "Петров Петр Петрович", "098-765-4321", false);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Пример обработки нажатия на ячейку
        if (e.ColumnIndex == 3) // Если нажата ячейка IsActive
        {
            //TODO: логика прелигированности
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int orderId;
        if (int.TryParse(textBox1.Text, out orderId))
        {
            LoadOrderData();
        }
        else
        {
            MessageBox.Show("Введите корректный номер заказа.");
        }
    }
    private void LoadOrderData()
    {
        //TODO: добавить загрузку данных из файла
        List<Ordere> orders = new List<Ordere>
        {
            new Ordere()
        };
        dataGridView1.DataSource = orders;
    }

    private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form2 f1 = new Form2();
        f1.ShowDialog();
    }

    private void добавToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form3 f = new Form3();
        f.ShowDialog();
    }
}