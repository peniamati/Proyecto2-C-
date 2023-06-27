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
    /// <summary>
    /// Clase parcial que representa la ventana de alta de vehículos.
    /// </summary>
    public partial class Alta : Form
    {
        /// <summary>
        /// Constructor de la clase Alta.
        /// </summary>
        public Alta()
        {
            // Ventana centrada de alta vehiculo        
            InitializeComponent();
            this.CenterToScreen();

            // Agregar elementos al selector de tipo de vehículo
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Seleccionar.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar elementos relacionados con la selección del vehículo
            boton_alta.Show();
            boton_limpiar.Show();
            anio.Show();
            color.Show();
            textBox1.Show();
            textBox3.Show();

            // Obtener el valor seleccionado del ComboBox
            string gettext = selector_tipo.SelectedItem.ToString();

            // Mostrar etiquetas y campos de texto específicos según el tipo de vehículo seleccionado
            if (gettext == "SpaceX")
            {
                // Configuraciones para SpaceX
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
                // Configuraciones para Tesla
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

        /// <summary>
        /// Evento que se dispara al cargar la ventana de alta.
        /// </summary>
        private void Alta_Load(object sender, EventArgs e)
        {
            // Configuraciones de carga inicial de la ventana de alta
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


        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Limpiar.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        /// <summary>
        /// Evento que se dispara al seleccionar un elemento en el ComboBox "Modelo".
        /// </summary>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_seleccionar.Show();
        }

        /// <summary>
        /// Evento que se dispara al seleccionar un elemento en el ComboBox "Tipo de vehículo".
        /// </summary>
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

            // Obtener el valor seleccionado del ComboBox
            string gettext = selector_tipo.SelectedItem.ToString();

            // Mostrar modelos disponibles según el tipo de vehículo seleccionado
            if (gettext == "SpaceX")
            {
                // Configuraciones para SpaceX
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
                // Configuraciones para Tesla
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

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Alta.
        /// </summary>
        private void boton_alta_Click(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado del ComboBox
            string gettext = selector_tipo.SelectedItem.ToString();
          
            if (gettext == "Tesla")
            {
                try
                {
                    // Obtener los valores ingresados por el usuario
                    string anio = textBox1.Text;
                    string kilometraje = textBox2.Text;
                    string color = textBox3.Text;
                    string duenio = textBox4.Text;
                    string modelo = selector_modelo.SelectedItem.ToString();
                    int anioInt;
                    double kilometrajeDouble;

                    // Validar y convertir los valores a los tipos de datos correspondientes
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

                    // Validar campos obligatorios y lanzar excepciones si están vacíos
                    if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(duenio))
                    {
                        throw new Exception("Los campos no pueden quedar vacios");
                    }

                    // Validar restricciones adicionales según el modelo
                    if (modelo == "Modelo S" && anioInt < 2012){
                        throw new Exception("El año debe ser mayor o igual a 2012");
                    }
                    if (modelo == "Modelo X" && anioInt < 2015)
                    { throw new Exception("El año debe ser mayor o igual a 2015"); }

                    if (modelo == "Cybertruck" && anioInt < 2019)
                    { throw new Exception("El año debe ser mayor o igual a 2019"); }

                    // Crear objeto Tesla con los valores ingresados
                    Tesla tesla = new Tesla(anioInt, color, kilometrajeDouble, duenio, modelo);
                    
                    // Agrega a la lista vehiculos 
                    Program.vehiculos.Add(tesla);
                    DialogResult Resultado;
                    
                    // Confirmacion de alta
                    Resultado = MessageBox.Show("Tesla dado de alta con exito!. \nDesea agregar otro vehiculo?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    // Carga o cierre de la ventana alta
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
            // Depende del selector se instacia y cargan los respectivos valores
            else if (gettext == "SpaceX")
            {
                try
                {
                    // Obtener los valores ingresados por el usuario
                    string anio = textBox1.Text;
                    string horasDeVuelo = textBox2.Text;
                    string color = textBox3.Text;
                    string empresa = textBox4.Text;
                    string modelo = selector_modelo.SelectedItem.ToString();
                    int anioInt;
                    double horasDeVueloDouble;

                    // Validar y convertir los valores a los tipos de datos correspondientes
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

                    // Validar campos obligatorios y lanzar excepciones si están vacíos
                    if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(empresa))
                    {
                        throw new Exception("Los campos no pueden quedar vacios");
                    }
                    // Depende del año de creacion de Space X
                    if (anioInt < 2002)
                    {
                        throw new Exception("El año debe ser mayor o igual a 2002");
                    }
                    // Instancia de clase 
                    SpaceX spaceX = new SpaceX(anioInt, color, horasDeVueloDouble, empresa, modelo);
                    // Se agrega a lista vehiculos
                    Program.vehiculos.Add(spaceX);
                    DialogResult Resultado;

                    // Mensaje de confirmacion
                    Resultado = MessageBox.Show("SpaceX dado de alta con exito!. \nDesea agregar otro vehiculo?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    // En base a lo seleccionado se da una nueva alta o cierre de ventana
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
                // Mostrar mensaje de error en caso de excepción
                catch (Exception ex)
                {
                    // Mensaje de error 
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            textBox1.Select();
        }

    }
}
