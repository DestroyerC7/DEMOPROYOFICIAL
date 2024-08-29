using _26_08_2024.Controladores;
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
    public partial class DocenteForm : Form
    {
        public DocenteForm()
        {
            InitializeComponent();
            ActualizarListaDocentes();
        }
        private DocenteController controller = new DocenteController();

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListaDocentes();
        }
        private void ActualizarListaDocentes()
        {
            var docentes = controller.ObtenerDocentes();
            dtgDocentes.DataSource = null;
            dtgDocentes.DataSource = docentes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            var docente = new DocenteTitulo
            {
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Email = txtEmail.Text,
                //Id_Titulo = (int)comboBoxTitulo.SelectedValue
            };

            controller.AgregarDocente(docente);
            ActualizarListaDocentes();
            MessageBox.Show("Docente agregado exitosamente");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtgDocentes.SelectedRows.Count > 0)
            {
                var selectedRow = dtgDocentes.SelectedRows[0];
                var docente = (DocenteTitulo)selectedRow.DataBoundItem;

                docente.PrimerNombre = txtPrimerNombre.Text;
                docente.SegundoNombre = txtSegundoNombre.Text;
                docente.PrimerApellido = txtPrimerApellido.Text;
                docente.SegundoApellido = txtSegundoApellido.Text;
                docente.Email = txtEmail.Text;
                //docente.Id_Titulo = (int)comboBoxTitulo.SelectedValue;

                controller.ActualizarDocente(docente);
                ActualizarListaDocentes();
                MessageBox.Show("Docente actualizado exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona un docente para actualizar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgDocentes.SelectedRows.Count > 0)
            {
                var selectedRow = dtgDocentes.SelectedRows[0];
                var docente = (DocenteTitulo)selectedRow.DataBoundItem;

                controller.EliminarDocente(docente.Id_Docente);
                ActualizarListaDocentes();
                MessageBox.Show("Docente eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona un docente para eliminar");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            //comboBoxTitulo.SelectedIndex = -1;
        }

        private void DocenteForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controller.ObtenerTitulo();
            comboBox1.DisplayMember = "nivel_academico";
            comboBox1.ValueMember = "id_titulo";
        }
    }
}
