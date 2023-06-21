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
    public partial class EscaneoResultado : Form
    {
        public EscaneoResultado()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void EscaneoResultado_Load(object sender, EventArgs e)
        {
            escaneando.Text = "Escaneando vehiculo...";
            int contador = 0;
            List<int> serviceRealizados = new List<int>();
            int cinturones = 1000;
            int baterias = 2000;
            int propulsion = 1000;
            int navegacionKm = 2500;
            int navegacionHs = 500;
            int motor = 3000;

            if (Program.modeloEscaneo == "Tesla")
            {
                if (Program.kilometrajeEscaneo >= cinturones)
                {
                    contador = +1;
                    int cantidad = (int)(Program.kilometrajeEscaneo / cinturones);
                    contador = contador * cantidad;
                    serviceRealizados.Add(1);
                    if (Program.kilometrajeEscaneo >= baterias && Program.kilometrajeEscaneo < navegacionKm)
                    {
                        serviceRealizados.Add(2);
                    }
                    else if (Program.kilometrajeEscaneo >= navegacionKm && Program.kilometrajeEscaneo < motor)
                    {
                        serviceRealizados.Add(2);
                        serviceRealizados.Add(4);
                    }
                    else if (Program.kilometrajeEscaneo >= motor)
                    {
                        serviceRealizados.Add(2);
                        serviceRealizados.Add(4);
                        serviceRealizados.Add(5);
                        serviceRealizados.Add(6);
                    }
                }

            }
            else if (Program.modeloEscaneo == "SpaceX")
            {
                if (Program.kilometrajeEscaneo >= navegacionHs)
                {
                    contador = +1;
                    int cantidad = (int)(Program.kilometrajeEscaneo / navegacionHs);
                    contador = contador * cantidad;
                    serviceRealizados.Add(4);
                    if (Program.kilometrajeEscaneo >= propulsion)
                    {
                        serviceRealizados.Add(3);
                    }
                }

            }


            realizados.Text = $"Se realizaron {contador} services";
            test_realizados.Text = "Test realizados:";
            foreach (int item in serviceRealizados)
            {
                test_realizados.Text = test_realizados.Text + " (" + item.ToString() + "),";
            }
        }

        private void EscaneoResultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("Desea escanear otro vehiculo?", "escanear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Resultado == DialogResult.Yes)
            {
                new Escaneo().Show();
            }
        }
    }
}
