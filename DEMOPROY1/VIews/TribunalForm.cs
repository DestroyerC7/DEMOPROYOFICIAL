using DEMOPROY1.Controllers;
using DEMOPROY1.Models;
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
    public partial class TribunalForm : Form
    {
        public TribunalForm()
        {
            InitializeComponent();
            ActualizarListaTribunales();
        }

        private TribunalController controller = new TribunalController();

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListaTribunales();
            LlenarComboBoxTitulo();
        }
        
        private void LlenarComboBoxTitulo()
        {
        }

        private void ActualizarListaTribunales()
        {
            var tribunales = controller.ObtenerTribunales();
            dtgTribunales.DataSource = null;
            dtgTribunales.DataSource = tribunales;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            var tribunal = new Tribunal
            {
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Tipo = txtTipo.Text,
                Institucion = txtInstitucion.Text,
                Id_Titulo = (int)comboBox1.SelectedValue
                //Id_Titulo = int.Parse(txtId_Titulo.Text) // Asegúrate de tener un campo para Id_titulo
            };

            controller.AgregarTribunal(tribunal);
            ActualizarListaTribunales();
            MessageBox.Show("Tribunal agregado exitosamente");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtgTribunales.SelectedRows.Count > 0)
            {
                var selectedRow = dtgTribunales.SelectedRows[0];
                var tribunal = (TribunalTitulo)selectedRow.DataBoundItem;

                tribunal.PrimerNombre = txtPrimerNombre.Text;
                tribunal.SegundoNombre = txtSegundoNombre.Text;
                tribunal.PrimerApellido = txtPrimerApellido.Text;
                tribunal.SegundoApellido = txtSegundoApellido.Text;
                tribunal.Tipo = txtTipo.Text;
                tribunal.Institucion = txtInstitucion.Text;
                tribunal.Id_Titulo = (int)comboBox1.SelectedValue;
                //tribunal.Id_titulo = int.Parse(txtIdTitulo.Text);

                controller.ActualizarTribunal(tribunal);
                ActualizarListaTribunales();
                MessageBox.Show("Tribunal actualizado exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona un tribunal para actualizar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgTribunales.SelectedRows.Count > 0)
            {
                var selectedRow = dtgTribunales.SelectedRows[0];
                var tribunal = (TribunalTitulo)selectedRow.DataBoundItem;

                controller.EliminarTribunal(tribunal.Id_Tribunal);
                ActualizarListaTribunales();
                MessageBox.Show("Tribunal eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona un tribunal para eliminar");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtInstitucion.Text = string.Empty;
            //txtIdTitulo.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (comboBox1.SelectedItem != null)
            {
                TituloProfesional tituloSeleccionado = (TituloProfesional)comboBox1.SelectedItem;
                // Aquí puedes usar tituloSeleccionado para obtener más datos si es necesario.
                MessageBox.Show("Seleccionaste: " + tituloSeleccionado.Id_Titulo);
            }
        */}

        private void TribunalForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controller.ObtenerTitulo();
            comboBox1.DisplayMember = "nivel_academico";
            comboBox1.ValueMember = "id_titulo";
        }
    }
}
