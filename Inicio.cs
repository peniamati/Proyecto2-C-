namespace Proyecto2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {   // menu de seleccion
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.Items.Add("1. Dar de alta un Tesla y SpaceX.");
            comboBox1.Items.Add("2. Eliminar un Tesla y SpaceX.");
            comboBox1.Items.Add("3. Mostrar el Tesla mas viejo.");
            comboBox1.Items.Add("4. Escaneo de un vehículo.");
            comboBox1.Items.Add("5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.");

        }
        
        // boton seleccionar
        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = comboBox1.SelectedItem.ToString();
            switch (gettext)
            {
                case "1. Dar de alta un Tesla y SpaceX.":
                    new Alta().Show();
                    break;
                case "2. Eliminar un Tesla y SpaceX.":
                    new Eliminar().Show();
                    break;
                case "3. Mostrar el Tesla mas viejo.":
                    try
                    {
                        // Muestra la lista de mas viejos, si esta tiene valores
                        if (Program.vehiculos.Count > 0)
                        {    // comprueba si es un telsa y es mayor a cero. 
                            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
                            if (hayTesla > 0)
                            {
                                new MasViejo().Show();
                            }
                            else
                            {   // excepcion por lista bacia
                                MessageBox.Show("No hay teslas en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {   // excepcion por lista bacia de Program.vehiculos
                            throw new Exception("Lista vacia");
                        }   
                    }
                    catch
                    {   // mensaje de lista Program.vehiculos vacia
                        MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    } 
                    break;
                case "4. Escaneo de un vehículo.":
                    
                    new Escaneo().Show();
                    break;
                case "5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.":
                    new Mostrar().Show();
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}