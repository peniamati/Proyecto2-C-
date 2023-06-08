using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            comboBox1.Items.Add("Tesla");
            comboBox1.Items.Add("SpaceX");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = comboBox1.SelectedItem.ToString();
            if (gettext == "SpaceX")
            {
                label2.Text = "Horas de vuelo";
                label4.Text = "Empresa";
                label2.Show();
                label1.Show();
                label4.Show();
                label5.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
            }
            else if(gettext == "Tesla")
            {
                label2.Show();
                label1.Show();
                label4.Show();
                label5.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
            }
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Show();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
        }
    }
}
