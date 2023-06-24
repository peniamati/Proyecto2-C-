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
            // ventada centrada de alta vehiculo        
            InitializeComponent();
            this.CenterToScreen();
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
        }


        private void button1_Click(object sender, EventArgs e)
        {   // muestra de botones del evento seleccionar
            boton_alta.Show();
            boton_limpiar.Show();
            anio.Show();
            color.Show();
            textBox1.Show();
            textBox3.Show();
            string gettext = selector_tipo.SelectedItem.ToString();

            // muestra de etiquetas en base al selector combox de vehiculo
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
            // en base al selector se muestras las etiquetas para cada tipo de vehiculo
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
        {   // carga de los atributos de clases en base a lo ingresado por usuario
            string gettext = selector_tipo.SelectedItem.ToString();
            // depende del selector se instacia y cargan respectivos valores
            if (gettext == "Tesla")
            {
                try
                {
                    string anio = textBox1.Text;
                    string kilometraje = textBox2.Text;
                    string color = textBox3.Text;
                    string duenio = textBox4.Text;
                    string modelo = selector_modelo.SelectedItem.ToString();
                    int anioInt;
                    double kilometrajeDouble;
                    // controles de atributos y llamado de excepciones
                    try
                    {
                        anioInt = Int32.Parse(textBox1.Text);
                    }
                    catch
                    {
                        throw new Exception("Debe ingresar un valor entero de año");
                    }
                    try
                    {
                        kilometrajeDouble = Convert.ToDouble(textBox2.Text);
                    }
                    catch
                    {
                        throw new Exception("Debe ingresar un valor númerico para el kilometraje");
                    }

                    // controles de valores nulos y llamados a excepciones
                    if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(duenio))
                    {
                        throw new Exception("Los campos no pueden quedar vacios");
                    }
                    // el valor anio depende del modelo
                    if (modelo == "Modelo S" && anioInt < 2012){
                        throw new Exception("El año debe ser mayor o igual a 2012");
                    }
                    if (modelo == "Modelo X" && anioInt < 2015)
                    { throw new Exception("El año debe ser mayor o igual a 2015"); }

                    if (modelo == "Cybertruck" && anioInt < 2019)
                    { throw new Exception("El año debe ser mayor o igual a 2019"); }
                    
                   // instancia de la clase tesla
                    Tesla tesla = new Tesla(anioInt, color, kilometrajeDouble, duenio, modelo);
                    // agrega a la lista vehiculos 
                    Program.vehiculos.Add(tesla);
                    DialogResult Resultado;
                    // confircamion de alta
                    Resultado = MessageBox.Show("Tesla dado de alta con exito!. \nDesea agregar otro vehiculo?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    // carga o cierre de la ventana alta
                    if (Resultado == DialogResult.Yes)
                    {
                        this.Close();
                        new Alta().Show();
                    }
                    else
                    {
                        this.Close();
                    }

                }

                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            // depende del selector se instacia y cargan respectivos valores
            else if (gettext == "SpaceX")
            {
                try
                {
                    string anio = textBox1.Text;
                    string horasDeVuelo = textBox2.Text;
                    string color = textBox3.Text;
                    string empresa = textBox4.Text;
                    string modelo = selector_modelo.SelectedItem.ToString();
                    int anioInt;
                    double horasDeVueloDouble;
                    // controles de atributos y llamado de excepciones
                    try
                    {
                        anioInt = Int32.Parse(textBox1.Text);
                    }
                    catch
                    {
                        throw new Exception("Debe ingresar un valor entero de año");
                    }
                    try
                    {
                        horasDeVueloDouble = Convert.ToDouble(textBox2.Text);
                    }
                    catch
                    {
                        throw new Exception("Debe ingresar un valor númerico para las horas de vuelo");
                    }
                    // controles de valores nulos y llamados a excepciones
                    if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(empresa))
                    {
                        throw new Exception("Los campos no pueden quedar vacios");
                    }
                    // depende del anio de creacion de space x
                    if (anioInt < 2002)
                    {
                        throw new Exception("El año debe ser mayor o igual a 2002");
                    }
                    // instancia de clase 
                    SpaceX spaceX = new SpaceX(anioInt, color, horasDeVueloDouble, empresa, modelo);
                    // se agrega a lista vehiculos
                    Program.vehiculos.Add(spaceX);
                    DialogResult Resultado;

                    // mensaje de confirmacion
                    Resultado = MessageBox.Show("SpaceX dado de alta con exito!. \nDesea agregar otro vehiculo?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    // en base a lo seleccionado se da una nueva alta o cierre de ventana
                    if (Resultado == DialogResult.Yes)
                    {
                        this.Close();
                        new Alta().Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    // mensjade de error 
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            textBox1.Select();
        }

    }
}
