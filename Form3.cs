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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //TODO: МИШАААНЯЯ ДОБАВЬ ВОЗВРАТ на 1 форму
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
            ////TODO: проверка полей 
            Customer cs = new Customer(id,phone,fullName,previl);
            //TODO: in json



            //else
            //{
            //    MessageBox.Show("Ошибка: Проверьте введенные данные.");
            //}
        }
    }
}
