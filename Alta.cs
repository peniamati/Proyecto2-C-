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
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
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
            boton_alta.Show();
            boton_limpiar.Show();
            anio.Show();
            color.Show();
            textBox1.Show();
            textBox3.Show();
            string gettext = selector_tipo.SelectedItem.ToString();
            if (gettext == "SpaceX")
            {
                kilometraje_horas.Text = "Horas de vuelo";
                duenio_empresa.Text = "Empresa";
                textBox2.PlaceholderText = "Ingrese horas de vuelo";
                textBox4.PlaceholderText = "Ingrese empresa";
                kilometraje_horas.Show();
                duenio_empresa.Show();
                textBox2.Show();
                textBox4.Show();
            }
            else if (gettext == "Tesla")
            {
                kilometraje_horas.Text = "Kilometraje actual";
                duenio_empresa.Text = "Dueño";
                textBox2.PlaceholderText = "Ingrese kilometraje actual";
                textBox4.PlaceholderText = "Ingrese dueño";
                kilometraje_horas.Show();
                duenio_empresa.Show();
                textBox2.Show();
                textBox4.Show();
            }
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            tipo_vehiculo.Show();
            anio.Hide();
            kilometraje_horas.Hide();
            color.Hide();
            duenio_empresa.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            boton_alta.Hide();
            boton_limpiar.Hide();
            modelo.Hide();
            selector_modelo.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedItem.ToString() == Tesla)
            //{
            //    Tesla tesla = new Tesla()
            //}
            //teslas.append(tesla);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelo.Show();
            selector_modelo.Show();
            
            
            string gettext = selector_tipo.SelectedItem.ToString();

            if (gettext == "SpaceX")
            {
                if (selector_modelo.Items.Contains("Starship") == false)
                {
                    selector_modelo.Items.Add("Starship");
                    selector_modelo.Items.Add("Falcon 9");
                    selector_modelo.Items.Remove("Modelo X");
                    selector_modelo.Items.Remove("Modelo S");
                    selector_modelo.Items.Remove("Cybertruck");
                }
            }
            else if (gettext == "Tesla")
            {
                if (selector_modelo.Items.Contains("Modelo X") == false)
                {
                    selector_modelo.Items.Add("Modelo X");
                    selector_modelo.Items.Add("Modelo S");
                    selector_modelo.Items.Add("Cybertruck");
                    selector_modelo.Items.Remove("Starship");
                    selector_modelo.Items.Remove("Falcon 9");
                }   
            }
        }
    }
}
