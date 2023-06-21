namespace Proyecto2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.Items.Add("1. Dar de alta un Tesla y SpaceX.");
            comboBox1.Items.Add("2. Eliminar un Tesla y SpaceX.");
            comboBox1.Items.Add("3. Mostrar el Tesla mas viejo.");
            comboBox1.Items.Add("4. Escaneo de un vehículo.");
            comboBox1.Items.Add("5. Mostrar la cantidad de carga de baterías/combustible de todos los vechículos.");

        }

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
                        if (Program.vehiculos.Count > 0)
                        {
                            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
                            if (hayTesla > 0)
                            {
                                new MasViejo().Show();
                            }
                            else
                            {
                                MessageBox.Show("No hay teslas en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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