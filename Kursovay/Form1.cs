using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OR_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void AND_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void NOT_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void NAND_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void NOR_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void A_Buttom_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void B_Buttom_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void C_Buttom_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void D_Buttom_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void Left_Bracket_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void Rigth_Bracket_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void Generatic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            // MessageBox.Show("Yes", "NO", MessageBoxButtons.YesNo);
            //string str = textBox1.Text.ToString();
            //int[] mass = new int[4];
            // string toDisplay = string.Join(Environment.NewLine, mass);
            //MessageBox.Show(toDisplay);
            //Parser parser = new Parser(str);
            // bool u = parser.Parse(str);
            // parser.Graph.printAdjacencyMatrix(u);
            Form2 form2 = new Form2(textBox1.Text.ToString());
          
            form2.Show();
        }
        public void Solution()
        {

        }
        // возвращает введенное значение
        public string logString()
        {
            return textBox1.Text.ToString();
        }
    }
}
