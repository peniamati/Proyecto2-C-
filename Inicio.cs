namespace Proyecto2
{
    /// <summary>
    /// Menu inicial del programa.
    /// </summary>
    public partial class Inicio : Form
    {
        /// <summary>
        /// Constructor de la clase Inicio
        /// </summary>
        public Inicio()
        {   
            // Menu de seleccion
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.Items.Add("1. Dar de alta un Tesla y SpaceX.");
            comboBox1.Items.Add("2. Eliminar un Tesla y SpaceX.");
            comboBox1.Items.Add("3. Mostrar el Tesla mas viejo.");
            comboBox1.Items.Add("4. Escaneo de un vehículo.");
            comboBox1.Items.Add("5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.");
            button1.Hide();
        }

        /// <summary>
        /// Maneja el evento clic del botón "Seleccionar".
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = comboBox1.SelectedItem.ToString();
            switch (gettext)
            {
                case "1. Dar de alta un Tesla y SpaceX.":
                    new Alta().Show();
                    break;
                case "2. Eliminar un Tesla y SpaceX.":
                    try
                    {
                        // Abre la ventana Eliminar si hay vehiculos.
                        if (Program.vehiculos.Count > 0)
                        {
                            new Eliminar().Show();
                        }
                        else
                        {
                            throw new Exception("No hay vehículos en la lista");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
                case "3. Mostrar el Tesla mas viejo.":
                    try
                    {
                        // Muestra el Tesla mas viejo si hay teslas en la lista de vehiculos.
                        if (Program.vehiculos.Count > 0)
                        {
                            // Comprueba si hay algún Tesla y abre la ventana MasViejo.
                            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
                            if (hayTesla > 0)
                            {
                                new MasViejo().Show();
                            }
                            else
                            {   
                                // Excepcion por ausencia de teslas en la lista.
                                MessageBox.Show("No hay teslas en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {   
                            // Mensaje de lista vacia.
                            throw new Exception("No hay vehiculos en la lista");
                        }
                    }
                    catch (Exception ex)
                    {   // Mensaje de lista vacia
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
                case "4. Escaneo de un vehículo.":
                    try
                    {
                        // Abre la ventana de Escaneo si hay vehículos en la lista.
                        if (Program.vehiculos.Count > 0)
                        {
                            new Escaneo().Show();
                        }
                        else
                        {
                            throw new Exception("No hay vehículos en la lista.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
                case "5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.":
                    try
                    {
                        // Abre la ventana de Mostrar si hay vehículos en la lista.
                        if (Program.vehiculos.Count > 0)
                        {
                            new Mostrar().Show();
                        }
                        else
                        {
                            throw new Exception("No hay vehículos en la lista");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
            }


        }

        /// <summary>
        /// Maneja el evento de cambio de selección del ComboBox.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Show();
        }
    }
}