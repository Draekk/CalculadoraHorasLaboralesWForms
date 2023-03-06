using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorHorasLaborales
{
    public partial class iPrincipal : Form
    {
        int HorasPorDia { get; set; }

        public iPrincipal()
        {
            InitializeComponent();
            pnlConfig.Visible = false;
            ReinicioConfig();
        }

        private void ReinicioConfig()
        {
            HorasPorDia = 8;
            txtHorasPorDia.Text = HorasPorDia.ToString("00");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Obtener valor de la interfaz en variables tipo TimeSpan
            TimeSpan horaInicial = new TimeSpan(dtpHoraInicial1.Value.Hour, dtpHoraInicial1.Value.Minute, 0);
            TimeSpan horaFinal = new TimeSpan(dtpHoraFinal1.Value.Hour, dtpHoraFinal1.Value.Minute, 0);

            //Validar si el valor obtenido de la interfaz(dias) se puede convertir a int
            try
            {
                int cantidadDias = int.Parse(txtCantidadDias.Text);
                TimeSpan resultadoTS = new TimeSpan();
                if (horaFinal.TotalMinutes < horaInicial.TotalMinutes)
                    resultadoTS = horaInicial - horaFinal;
                else
                    resultadoTS = horaFinal - horaInicial;

                int resultadoInt = (int)resultadoTS.TotalMinutes * cantidadDias;
                
                resultadoTS = new TimeSpan(0, resultadoInt, 0);

                int horasExtras = 0;
                TimeSpan totalHorasExtras;
                TimeSpan totalHorasLaborales;
                if (resultadoTS.TotalHours > (HorasPorDia * cantidadDias))
                {
                    horasExtras = (int)resultadoTS.TotalHours - (HorasPorDia * cantidadDias);
                    totalHorasExtras = new TimeSpan(horasExtras, 0, 0);
                    totalHorasLaborales = new TimeSpan(((int)resultadoTS.TotalHours - horasExtras), resultadoTS.Minutes, 0);
                    lblHorasLaborales.Text = $"{((int)totalHorasLaborales.TotalHours).ToString("00")}:{resultadoTS.Minutes.ToString("00")}";
                    lblHorasExtras.Text = $"{((int)totalHorasExtras.TotalHours).ToString("00")}:{totalHorasExtras.Minutes.ToString("00")}";
                    lblResultado.Text = $"{((int)resultadoTS.TotalHours).ToString("00")}:{resultadoTS.Minutes.ToString("00")}";
                }
                else
                {
                    lblHorasLaborales.Text = $"{((int)resultadoTS.TotalHours).ToString("00")}:{resultadoTS.Minutes.ToString("00")}";
                    lblHorasExtras.Text = "00:00";
                    lblResultado.Text = $"{((int)resultadoTS.TotalHours).ToString("00")}:{resultadoTS.Minutes.ToString("00")}";

                }


            }
            catch(Exception)
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
            lblHorasLaborales.Text = "00:00";
            lblHorasExtras.Text = "00:00";
            lblResultado.Text = "00:00";
        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Enabled = false;
            pnlConfig.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlConfig.Visible = false;
            pnlPrincipal.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                HorasPorDia = int.Parse(txtHorasPorDia.Text);

                pnlConfig.Visible = false;
                pnlPrincipal.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduzca valores numéricos.\n" + ex.Message);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            ReinicioConfig();
        }
    }
}
