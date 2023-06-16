using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            boton_seleccionar.Hide();
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



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_seleccionar.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_seleccionar.Hide();
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

        private void boton_alta_Click(object sender, EventArgs e)
        {
            string gettext = selector_tipo.SelectedItem.ToString();
            if (gettext == "Tesla")
            {
                try
                {
                    int anio = Int32.Parse(textBox1.Text);
                    double kilometraje = Convert.ToDouble(textBox2.Text);
                    string color = textBox3.Text;
                    string duenio = textBox4.Text;
                    string modelo = selector_modelo.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(duenio))
                    {
                        throw new Exception("Error");
                    }
                    if (modelo == "Modelo S" && anio < 2013) {

                        throw new FormatException("Error");
                    }
                    if(modelo == "Modelo X" && anio < 2015)
                    { throw new FormatException("Error"); }

                    if (modelo == "Cybertruck" && anio < 2019)
                    { throw new FormatException("Error"); }

                    Tesla tesla = new Tesla(anio, color, kilometraje, duenio, modelo);
                    Program.vehiculos.Add(tesla);

                }
                catch (FormatException anio) // corregir tipo de excepcion(personalizada)
                {
                    MessageBox.Show($"El año debe ser mayor a {anio}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    // Display an error message.
                    MessageBox.Show("Debe ingresar un valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if (gettext == "SpaceX")
            {
                try
                {
                    int anio = Int32.Parse(textBox1.Text);
                    double horasDeVuelo = Convert.ToDouble(textBox2.Text);
                    string color = textBox3.Text;
                    string empresa = textBox4.Text;
                    string modelo = selector_modelo.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(empresa))
                    {
                        throw new Exception("Error");
                    }

                    if (anio < 2002){
                        throw new FormatException("Error");
                    }
                    
                    SpaceX spaceX = new SpaceX(anio, color, horasDeVuelo, empresa, modelo);
                    Program.vehiculos.Add(spaceX);
                }

                catch (FormatException){
                    MessageBox.Show("Debe ingresar un valor mayor a 2022.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch
                {
                    // Display an error message.
                    MessageBox.Show("Debe ingresar un valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Select();
        }

    }
}
