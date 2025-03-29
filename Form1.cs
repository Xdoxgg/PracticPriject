using System.Runtime.Serialization.Json;

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
        dataGridView1.Columns.Add("CreationDate", "Дата");
        dataGridView1.Columns.Add("Adress", "Адрес");
        dataGridView1.Columns.Add("Customer", "Клиент");
        dataGridView1.Columns.Add("OrderLines", "Пункты заказа");
        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        checkBoxColumn.Name = "IsExpressDelivery";
        checkBoxColumn.HeaderText = "Срочный";
        dataGridView1.Columns.Add(checkBoxColumn);
        dataGridView1.Columns[4].Width = 800;
        dataGridView1.Columns[3].Width = 800;
    }


    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int orderId;
        if (int.TryParse(textBox1.Text, out orderId))
        {
            try
            {
                LoadOrderData(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        else
        {
            MessageBox.Show("Введите корректный номер заказа.");
        }
    }

    private void LoadOrderData(int id)
    {
        try
        {
            var orders = DataProcessing.ReadJsonFromFile<Ordere>();
            var result = orders.Where(x => x.Number == id).First();
  
            string orderLinesStr = "";
            foreach (var VARIABLE in result.OrderLines)
            {
                orderLinesStr += VARIABLE + ";";
            }

            dataGridView1.Rows.Add(result.Number, result.CreationDate, result.Adress, result.Customer, orderLinesStr,
                result.IsExpressDelivery);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form2 f1 = new Form2();
        f1.ShowDialog();
    }

    private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form3 f = new Form3();
        f.ShowDialog();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form4 f4 = new Form4();
        f4.ShowDialog();
    }
}