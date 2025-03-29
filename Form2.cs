using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public delegate void ShowForm();
namespace lab2
{
    public partial class Form2 : Form
    {
        private ShowForm _showForm;
        public Form2(ShowForm showForm)
        {
            InitializeComponent();
            _showForm = showForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
    

            string article = input1.ToString();
            string name = input2.ToString();
            double price;
            try
            {
                if (double.TryParse(input3, out price))
                {
                    Item i = new Item(article, name, price);
                    
                    List<Item> items = DataProcessing.ReadJsonFromFile<Item>();
                    if (items.Find(x => x.Article == i.Article) != default)
                    {
                        MessageBox.Show("Такой предмет уже существует");
                    }
                    else
                    {
                        items.Add(i);
                        DataProcessing.WriteToFile(items);
                    }

                }
                else
                {
                    MessageBox.Show("Ошибка: Проверьте введенные данные.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
