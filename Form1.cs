using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IRing<int> ring = new GenericsRing<int>(5);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // по индексу элемент
        {
            int tmp = Int32.Parse(textBox2.Text);
            richTextBox1.Text += "Элемент по индекcу " + tmp + ": " + ring.Get(tmp) + "\n";
        }

        private void button4_Click(object sender, EventArgs e) // кол-во элементов
        {
            richTextBox1.Text += "Количество элементов: " + ring.Count() + "\n";
        }

        private void button3_Click(object sender, EventArgs e) // добавление нового
        {
            int tmp = Int32.Parse(textBox1.Text);
            ring.Push(tmp);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e) // текущий элемент
        {
            richTextBox1.Text += "Элемент из текущей позиции: " + ring.Head() + "\n";
        }
    }
}
