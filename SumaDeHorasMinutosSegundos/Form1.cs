using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDeHorasMinutosSegundos
{
    public partial class FSumaHorasMinutosSegundos : Form
    {
        public FSumaHorasMinutosSegundos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int horas1 = Convert.ToInt32(tHoras1.Text);
            int minutos1 = Convert.ToInt32(tMinutos1.Text);
            int segundos1 = Convert.ToInt32(tSegundos1.Text);

            int horas2 = Convert.ToInt32(tHoras2.Text);
            int minutos2 = Convert.ToInt32(tMinutos2.Text);
            int segundos2 = Convert.ToInt32(tSegundos2.Text);


            int totalSegundos = (horas1 + horas2) * 3600 + (minutos1 + minutos2) * 60 + (segundos1 + segundos2);


            int horasTotales = totalSegundos / 3600;
            int minutosTotales = (totalSegundos % 3600) / 60;
            int segundosTotales = totalSegundos % 60;

            MessageBox.Show("El resultado son " + horasTotales + " Horas " + minutosTotales + " Minutos " + segundosTotales + " Segundos");

        }
    }
} 
