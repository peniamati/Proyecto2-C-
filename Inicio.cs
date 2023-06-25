namespace Proyecto2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {   // Menu de seleccion
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.Items.Add("1. Dar de alta un Tesla y SpaceX.");
            comboBox1.Items.Add("2. Eliminar un Tesla y SpaceX.");
            comboBox1.Items.Add("3. Mostrar el Tesla mas viejo.");
            comboBox1.Items.Add("4. Escaneo de un vehículo.");
            comboBox1.Items.Add("5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.");
            button1.Hide();
        }

        // Boton seleccionar
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
                        if (Program.vehiculos.Count > 0)
                        {
                            new Eliminar().Show();
                        }
                        else
                        {
                            throw new Exception("Lista vacia");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
                case "3. Mostrar el Tesla mas viejo.":
                    try
                    {
                        // Muestra la lista de mas viejos, si esta tiene valores
                        if (Program.vehiculos.Count > 0)
                        {    // Comprueba si es un Tesla y es mayor a cero. 
                            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
                            if (hayTesla > 0)
                            {
                                new MasViejo().Show();
                            }
                            else
                            {   // Excepcion por lista vacia
                                MessageBox.Show("No hay teslas en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {   // Excepcion por lista vacia de vehiculos
                            throw new Exception("Lista vacia");
                        }
                    }
                    catch
                    {   // Mensaje de lista vacia
                        MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
                case "4. Escaneo de un vehículo.":
                    try
                    {
                        if (Program.vehiculos.Count > 0)
                        {
                            new Escaneo().Show();
                        }
                        else
                        {
                            throw new Exception("Lista vacia");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
                case "5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.":
                    try
                    {
                        if (Program.vehiculos.Count > 0)
                        {
                            new Mostrar().Show();
                        }
                        else
                        {
                            throw new Exception("Lista vacia");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    break;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Show();
        }
    }
}