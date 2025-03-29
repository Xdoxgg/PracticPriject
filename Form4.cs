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
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                var ord = DataProcessing.ReadJsonFromFile<Customer>();
                var cust = ord.Select(ord => ord.FullName).ToList();
                comboBox1.DataSource = cust;
                var orders = DataProcessing.ReadJsonFromFile<Item>();
                var names = orders.Select(order => order.Name).ToList();
                comboBox2.DataSource = names;
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            try
            {
                //label8
                string labl8 = label8.Text;
                int quanity;
                string txtbox3 = textBox3.Text;
                int.TryParse(txtbox3, out quanity);
                if (textBox3 != null)
                {
                    ///TODO: код отображение текущий цены в зависимости от товара и кол-ва в label8
                    ///string 
                    ///labl8 = Item.UnitPrice * quanity;
                }
            }catch (Exception exc) { MessageBox.Show(exc.Message); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ///TODO: доделать переход на Form1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
