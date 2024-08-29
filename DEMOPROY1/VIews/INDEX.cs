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
        private DEFENSAINTERNA defensaInterna;
        private DEFENSAEXTERNA defensaExterna;
        public INDEX()
        {
            InitializeComponent();
            postulanteForm = new PostulanteForm();
            perfilForm = new PerfilForm();
            proyectoForm = new ProyectoForm();
            estudiantesPendientes = new ESTUDIANTESPENDIENTES();
            proyectoSinActa = new REPORTEPROYECTOS();
            tutorytutorado = new TUTORESYTUTORADOS();
            defensaInterna = new DEFENSAINTERNA();
            defensaExterna = new DEFENSAEXTERNA();

        }

        private void INDEX_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cABALLOSDataSet.CABALLOS' Puede moverla o quitarla según sea necesario.
            this.cABALLOSTableAdapter.Fill(this.cABALLOSDataSet.CABALLOS);
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

        private void button7_Click(object sender, EventArgs e)
        {
            defensaInterna = new DEFENSAINTERNA();
            defensaInterna.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            defensaExterna = new DEFENSAEXTERNA();
            defensaExterna.Show();
        }
    }
}
