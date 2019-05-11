using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_coin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double best, degree, x1, x2, x3, x4, x5, x6, x7;


        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            textBox1.Text = "38"; //Курсор
            textBox2.Text = "35"; //Видеокарта
            textBox3.Text = "26"; //Стойка видеокарт
            textBox4.Text = "20"; //Суперкомпьютер
            textBox5.Text = "18"; //Сервер ВКонтакте
            textBox6.Text = "17"; //Квантовый компьютер
            textBox7.Text = "7";  //Датацентр
        }

        private void buttons_white()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
        }
        private void checkTheBest()
        {
            best = double.MaxValue;

            if (best > x1 / 1)
            {
                buttons_white();
                best = x1;
                button1.BackColor = Color.Green;
            }
            if (best > x2 / 3)
            {
                buttons_white();
                best = x2 / 3;
                button2.BackColor = Color.Green;
            }
            if (best > x3 / 10)
            {
                buttons_white();
                best = x3 / 10;
                button3.BackColor = Color.Green;
            }
            if (best > x4 / 30)
            {
                buttons_white();
                best = x4 / 30;
                button4.BackColor = Color.Green;
            }
            if (best > x5 / 100)
            {
                buttons_white();
                best = x5 / 100;
                button5.BackColor = Color.Green;
            }
            if (best > x6 / 500)
            {
                buttons_white();
                best = x6 / 500;
                button6.BackColor = Color.Green;
            }
            if (best > x7 / 1000)
            {
                buttons_white();
                best = x7 / 1000;
                button7.BackColor = Color.Green;
            }
        }


        private void Start_Click(object sender, EventArgs e)
        {
            degree = Convert.ToDouble(textBox1.Text);
            x1 = Math.Round((670.972 * Math.Pow(1.3, degree - 38)),3);
            degree = Convert.ToDouble(textBox2.Text);
            x2 = Math.Round((978.462 * Math.Pow(1.3, degree - 35)),3);
            degree = Convert.ToDouble(textBox3.Text);
            x3 = Math.Round((918.101 * Math.Pow(1.3, degree - 26)),3);
            degree = Convert.ToDouble(textBox4.Text);
            x4 = Math.Round((1900.572 * Math.Pow(1.3, degree - 20)),3);
            degree = Convert.ToDouble(textBox5.Text);
            x5 = Math.Round((5622.832 * Math.Pow(1.3, degree - 18)),3);
            degree = Convert.ToDouble(textBox6.Text);
            x6 = Math.Round((17300.855 * Math.Pow(1.3, degree - 17)),3);
            degree = Convert.ToDouble(textBox7.Text);
            x7 = Math.Round((31374.259 * Math.Pow(1.3, degree - 7)),3);
            degree = 0;
            button1.Text = $"Купить за {x1}";
            button2.Text = $"Купить за {x2}";
            button3.Text = $"Купить за {x3}";
            button4.Text = $"Купить за {x4}";
            button5.Text = $"Купить за {x5}";
            button6.Text = $"Купить за {x6}";
            button7.Text = $"Купить за {x7}";
            Start.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            Width = 287;
            Height = 470;
            checkTheBest();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Math.Round((x1 * 1.3), 3);
            button1.Text = $"Купить за {x1}";
            checkTheBest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x2 = Math.Round((x2 * 1.3), 3);
            button2.Text = $"Купить за {x2}";
            checkTheBest();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x3 = Math.Round((x3 * 1.3), 3);
            button3.Text = $"Купить за {x3}";
            checkTheBest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x4 = Math.Round((x4 * 1.3), 3);
            button4.Text = $"Купить за {x4}";
            checkTheBest();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            x5 = Math.Round((x5 * 1.3), 3);
            button5.Text = $"Купить за {x5}";
            checkTheBest();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x6 = Math.Round((x6 * 1.3), 3);
            button6.Text = $"Купить за {x6}";
            checkTheBest();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x7 = Math.Round((x7 * 1.3), 3);
            button7.Text = $"Купить за {x7}";
            checkTheBest();
        }

    }
}
