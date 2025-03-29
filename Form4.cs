using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form4 : Form
    {
        private ShowForm _showForm;
        private ShowForm _ud;
        List<OrderLine> _orderLines = new List<OrderLine>();
        List<Item> _items = DataProcessing.ReadJsonFromFile<Item>();

        public Form4(ShowForm showForm, ShowForm update )
        {
            InitializeComponent();
            _showForm += showForm;
            _showForm += update;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            try
            {
                var ord = DataProcessing.ReadJsonFromFile<Customer>();
                var cust = ord.Select(ord => ord.Code).ToList();
                comboBox1.DataSource = cust;
                var orders = DataProcessing.ReadJsonFromFile<Item>();
                var names = orders.Select(order => order.Article).ToList();
                comboBox2.DataSource = names;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _showForm();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox2 == null)
            {
                MessageBox.Show("Не введены данные");
            }

            try
            {
                List<Ordere> orderes = DataProcessing.ReadJsonFromFile<Ordere>();
                string txtbx1 = textBox1.Text;
                int num;
                int.TryParse(txtbx1, out num);
                DateTime dateTimePickerValue = dateTimePicker1.Value;
                string adres = textBox2.Text;
                bool expressStatus = radioButton1.Checked;
                List<Customer> customers = DataProcessing.ReadJsonFromFile<Customer>();
                Customer customer = customers.Where(x => x.Code == comboBox1.SelectedItem.ToString()).First();
                _orderLines.Add(new OrderLine(int.Parse(textBox3.Text),
                    _items.Where(x => x.Article == comboBox2.SelectedItem.ToString()).First()));
                Ordere ordere = new Ordere(num, dateTimePickerValue, adres, expressStatus, customer, _orderLines);
                if (orderes.Find(x => x.Number == ordere.Number) != default)
                {
                    MessageBox.Show("Такой заказ уже существует");
                }
                else
                {
                    orderes.Add(ordere);
                    DataProcessing.WriteToFile(orderes);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // private void button3_Click(object sender, EventArgs e)
        // {
        //     int quanity;
        //     string txtbox3 = textBox3.Text; //count
        //     int.TryParse(txtbox3, out quanity);
        //     if (quanity <= 0)
        //     {
        //         MessageBox.Show("Выберите товар и введите кол-во товаров");
        //     }
        //     else
        //     {
        //         _orderLines.Add(new OrderLine(quanity, _items.Where()));
        //     }
        //
        //
        //     try
        //     {
        //         //label8
        //         // string labl8 = label8.Text;
        //     }
        //     catch (Exception exc)
        //     {
        //         MessageBox.Show(exc.Message);
        //     }
        // }
    }
}