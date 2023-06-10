namespace Proyecto2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
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
                    new MasViejo().Show();
                    break;
                case "4. Escaneo de un vehículo.":
                    new Escaneo().Show();
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