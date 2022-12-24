using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insertion_Sort_Task
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        public int num7;
        public int num8;
        public int num9;
        public int num10;
        public int num11;
        public int num12;
        public int num13;

        int[] sorting_array = new int[13];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            num3 = int.Parse(txt3.Text);
            num4 = int.Parse(txt4.Text);
            num5 = int.Parse(txt5.Text);
            num6 = int.Parse(txt6.Text);
            num7 = int.Parse(txt7.Text);
            num8 = int.Parse(txt8.Text);
            num9 = int.Parse(txt9.Text);
            num10 = int.Parse(txt10.Text);
            num11 = int.Parse(txt11.Text);
            num12 = int.Parse(txt12.Text);
            num13 = int.Parse(txt13.Text);

            sorting_array = new int[] { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13};

            PrintIntegerArray(InsertionSort(sorting_array));

            string sorted_array = string.Join(",", sorting_array);
            resultlbl.Text = sorted_array;

            Console.ReadLine();

            int[] InsertionSort(int[] sortingArray)
            {
                for (int i = 0; i < sortingArray.Length - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (sortingArray[j - 1] > sortingArray[j])
                        {
                            int key = sortingArray[j - 1];
                            sortingArray[j - 1] = sortingArray[j];
                            sortingArray[j] = key;
                        }
                    }

                }
                return sortingArray;
            }

            void PrintIntegerArray(int[] array)
            {
                foreach (int i in array)
                {
                    Console.Write(i.ToString() + "  ");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txt13.Text = "";

            sorting_array = new int[13];
            resultlbl.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
