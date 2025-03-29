using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form3 : Form
    {
        private ShowForm _showForm;
        public Form3(ShowForm showForm)
        {
            InitializeComponent();
            _showForm = showForm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _showForm();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;
            string input3 = textBox3.Text;
            string id = input1.ToString();
            string phone = input2.ToString();
            string fullName = input3.ToString();
            bool previl;
            if(radioButton1.Checked == true)
            {
                previl = true;
            }
            else
            {
                previl= false;
            }

            try
            {
                Customer cs = new Customer(id, phone, fullName, previl);
                List<Customer> customers = DataProcessing.ReadJsonFromFile<Customer>();
                if (customers.Find(x => x.Code == cs.Code) != default)
                {
                    MessageBox.Show("Такой Пользователь уже существует уже существует");
                }
                else
                {
                    customers.Add(cs);
                    DataProcessing.WriteToFile(customers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //else
            //{
            //    MessageBox.Show("Ошибка: Проверьте введенные данные.");
            //}
        }
    }
}
