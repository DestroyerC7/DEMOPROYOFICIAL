using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOPROY1.VIews
{
    public partial class INDEX : Form
    {
        private PostulanteForm postulanteForm;
        private PerfilForm perfilForm;
        private ProyectoForm proyectoForm;
        private ESTUDIANTESPENDIENTES estudiantesPendientes;
        private REPORTEPROYECTOS proyectoSinActa;
        private TUTORESYTUTORADOS tutorytutorado;
        public INDEX()
        {
            InitializeComponent();
            postulanteForm = new PostulanteForm();
            perfilForm = new PerfilForm();
            proyectoForm = new ProyectoForm();
            estudiantesPendientes = new ESTUDIANTESPENDIENTES();
            proyectoSinActa = new REPORTEPROYECTOS();
            tutorytutorado = new TUTORESYTUTORADOS();
        }

        private void INDEX_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet3.VISTA_PROYECTOS_FALTANTES_ACTAS' Puede moverla o quitarla según sea necesario.
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter.Fill(this.dEMOPROYDataSet3.VISTA_PROYECTOS_FALTANTES_ACTAS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            postulanteForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perfilForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            proyectoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           proyectoSinActa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            estudiantesPendientes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tutorytutorado.Show();
        }
    }
}
