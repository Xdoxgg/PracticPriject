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
            label7.Visible = false;
            label8.Visible = false;
            try
            {
                var ord = DataProcessing.ReadJsonFromFile<Customer>();
                var cust = ord.Select(ord => ord.FullName).ToList();
                comboBox1.DataSource = cust;
                var orders = DataProcessing.ReadJsonFromFile<Item>();
                var names = orders.Select(order => order.Name).ToList();///TODO: МИШАНЯ проверь добавление пользователей и товаров в 2 comboBox
                comboBox2.DataSource = names;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            


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

        private void button2_Click(object sender, EventArgs e)
        {
            if(label7.Visible == false)
            {
                MessageBox.Show("Сперва рассчитайте итоговую стоимость");
            }
            if(textBox1 ==null ||textBox2==null)
            {
                MessageBox.Show("Не введены данные");
            }
            try
            {
                string txtbx1 = textBox1.Text;
                int num;
                int.TryParse(txtbx1, out num);
                DateTime dateTimePickerValue = dateTimePicker1.Value;
                string adres = textBox2.Text;
                bool expressStatus = radioButton1.Checked;
            } catch (Exception exc) { MessageBox.Show(exc.Message); }
            ///TODO: преобразование в класс ordere и запись в json


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quanity;
            string txtbox3 = textBox3.Text;
            int.TryParse(txtbox3, out quanity);
            if (quanity <= 0)
            {
                MessageBox.Show("Выберите товар и введите кол-во товаров");
            }
            else
            {
                label7.Visible = true;
                label8.Visible = true;
            }
            

            try
            {
                //label8
                string labl8 = label8.Text;
               
                if (textBox3 != null)
                {
                    ///TODO: код отображение текущий цены в зависимости от товара и кол-ва в label8
                    ///string 
                    ///labl8 = Item.UnitPrice * quanity;
                    ///Можно при рассчете цены создать экзмепляр класса OrderLine в крысу
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
