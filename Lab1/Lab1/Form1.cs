using System.Windows.Forms;
using System;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из TextBox
            string name = textBox1.Text;
            string ageText = textBox2.Text;

            // Проверка на пустые поля
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(ageText))
            {
                // Преобразуем возраст в число
                if (int.TryParse(ageText, out int age))
                {
                    // Создаем объект класса Person
                    Person person = new Person
                    {
                        Name = name,
                        Age = age
                    };

                    // Отображаем данные объекта в Label3 и Label4
                    label3.Text = "Name: " + person.Name;
                    label4.Text = "Age: " + person.Age;
                }
                else
                {
                    // Если возраст не число
                    label3.Text = "Invalid age. Please enter a valid number.";
                    label4.Text = "";
                }
            }
            else
            {
                // Если одно из полей пустое
                label3.Text = "Please enter both name and age.";
                label4.Text = "";
            }
        }
    }
}
