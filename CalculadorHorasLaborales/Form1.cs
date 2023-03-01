using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorHorasLaborales
{
    public partial class iPrincipal : Form
    {
        public iPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TimeSpan horaInicial = new TimeSpan(dtpHoraInicial1.Value.Hour, dtpHoraInicial1.Value.Minute, 0);
            TimeSpan horaFinal = new TimeSpan(dtpHoraFinal1.Value.Hour, dtpHoraFinal1.Value.Minute, 0);

            if(int.TryParse(txtCantidadDias.Text, out int cant))
            {
                TimeSpan resultado = new TimeSpan();
                if (horaFinal.TotalMinutes < horaInicial.TotalMinutes)
                    resultado = horaInicial - horaFinal;
                else
                    resultado = horaFinal - horaInicial;
                int r = (int)resultado.TotalMinutes * cant;
                resultado = new TimeSpan(0, r, 0);
                lblResultado.Text = $"{(int)resultado.TotalHours}:{resultado.Minutes}";
            }
            else
            {
                MessageBox.Show("Introduzca una cantidad válida.");
                txtCantidadDias.Text = "1";
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpHoraInicial1.Text = "00:00";
            dtpHoraFinal1.Text = "00:00";
            txtCantidadDias.Text = "1";
            lblResultado.Text = "00:00";
        }
    }
}
