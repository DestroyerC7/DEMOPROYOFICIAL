using DEMOPROY1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEMOPROY1.Models;



namespace DEMOPROY1.VIews
{
    public partial class ProyectoForm : Form
    {
        private ProyectoController proyectoController;


        public ProyectoForm()
        {
            InitializeComponent();
            proyectoController = new ProyectoController();
            CargarDocentes();
            CargarDocentes1();
            CargarPostulantes();
            CargarProyectos();
            dgvProyectos.CellClick += dgvProyectos_CellClick;
        }
        private void CargarDocentes()
        {
            try
            {
                DataTable dtDocente = proyectoController.ObtenerDocente();
                cmbDocentes.DisplayMember = "PrimerNombre";
                cmbDocentes.ValueMember = "Id_Docente";
                cmbDocentes.DataSource = dtDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los docentes: " + ex.Message);
            }
        }

        private void CargarDocentes1()
        {
            try
            {
                DataTable dtDocente = proyectoController.ObtenerDocente1();
                listBoxTutores.DisplayMember = "PrimerNombre";
                listBoxTutores.ValueMember = "Id_Docente";
                listBoxTutores.DataSource = dtDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los docentes: " + ex.Message);
            }
        }

        private void CargarPostulantes()
        {
            try
            {
                DataTable dtPostulante = proyectoController.ObtenerPostulante();
                cmbPostulantes.DisplayMember = "PrimerNombre";
                cmbPostulantes.ValueMember = "Codigo_Estudiante";
                cmbPostulantes.DataSource = dtPostulante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los postulantes: " + ex.Message);
            }
        }

        private void CargarProyectos()
        {
            try
            {
                DataTable dtProyectos = proyectoController.ObtenerProyectos();
                dgvProyectos.DataSource = dtProyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message);
            }
        }

        private void limpiar()
        {
            txtTitulo.Clear();
            txtTipoTrabajo.Clear();
            txtUniversidad.Clear();
            txtGestion.Clear();
            txtCalificacion.Clear();
            cmbDocentes.SelectedIndex = -1;
            listBoxTutores.SelectedIndex = -1;
            cmbPostulantes.SelectedIndex = -1;
        }

            private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    // Obtén la fila seleccionada
                    DataGridViewRow row = dgvProyectos.Rows[e.RowIndex];

                    // Llena los campos de texto con los valores de las celdas seleccionadas
                    txtTitulo.Text = row.Cells["Titulo"].Value != null ? row.Cells["Titulo"].Value.ToString() : string.Empty;
                    txtTipoTrabajo.Text = row.Cells["TipoTrabajo"].Value != null ? row.Cells["TipoTrabajo"].Value.ToString() : string.Empty;
                    txtUniversidad.Text = row.Cells["Universidad"].Value != null ? row.Cells["Universidad"].Value.ToString() : string.Empty;
                    txtGestion.Text = row.Cells["Gestion"].Value != null ? row.Cells["Gestion"].Value.ToString() : string.Empty;
                    txtCalificacion.Text = row.Cells["Calificacion"].Value != null ? row.Cells["Calificacion"].Value.ToString() : string.Empty;

                    // Verifica y asigna el valor a los ComboBox y ListBox si no es nulo
                    if (row.Cells["ID_DocenteMDG2"].Value != DBNull.Value)
                    {
                        cmbDocentes.SelectedValue = Convert.ToInt32(row.Cells["ID_DocenteMDG2"].Value);
                    }
                    else
                    {
                        cmbDocentes.SelectedIndex = -1; // o algún valor por defecto
                    }

                    if (row.Cells["ID_Tutor"].Value != DBNull.Value)
                    {
                        listBoxTutores.SelectedValue = Convert.ToInt32(row.Cells["ID_Tutor"].Value);
                    }
                    else
                    {
                        listBoxTutores.SelectedIndex = -1; // o algún valor por defecto
                    }

                    if (row.Cells["ID_Postulante"].Value != DBNull.Value)
                    {
                        cmbPostulantes.SelectedValue = Convert.ToInt32(row.Cells["ID_Postulante"].Value);
                    }
                    else
                    {
                        cmbPostulantes.SelectedIndex = -1; // o algún valor por defecto
                    }
                }
            }



            private void ProyectoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet.PROYECTO' Puede moverla o quitarla según sea necesario.
            this.pROYECTOTableAdapter.Fill(this.dEMOPROYDataSet.PROYECTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCalificacion.Text, out int calificacion))
                {
                    MessageBox.Show("Calificación debe ser un número entero.");
                    return;
                }

                if (cmbDocentes.SelectedValue == null || !int.TryParse(cmbDocentes.SelectedValue.ToString(), out int idDocenteMDG2))
                {
                    MessageBox.Show("Selecciona un docente válido para MDG II.");
                    return;
                }

                if (cmbPostulantes.SelectedValue == null || !int.TryParse(cmbPostulantes.SelectedValue.ToString(), out int idPostulante))
                {
                    MessageBox.Show("Selecciona un postulante válido.");
                    return;
                }

                if (listBoxTutores.SelectedValue == null || !int.TryParse(listBoxTutores.SelectedValue.ToString(), out int idTutor))
                {
                    MessageBox.Show("Selecciona un tutor válido.");
                    return;
                }

                Proyecto proyecto = new Proyecto
                {
                    Titulo = txtTitulo.Text,
                    TipoTrabajo = txtTipoTrabajo.Text,
                    Universidad = txtUniversidad.Text,
                    Gestion = txtGestion.Text,
                    ACTAMDG1 = cmbActaMDG1.Checked,
                    ACTAMDG2 = cmbActaMDG2.Checked,
                    Calficacion = calificacion,
                    ID_DocenteMDG2 = idDocenteMDG2,
                    ID_Tutor = idTutor, // Verifica si este es el valor correcto para el tutor
                    ID_Postulante = idPostulante,
                };

                proyectoController.CrearProyecto(proyecto);
                MessageBox.Show("Proyecto registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el proyecto: " + ex.Message);
            }
        }
    

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una celda (no en el encabezado de la columna o fila)
         
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProyectos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un proyecto para editar.");
                    return;
                }

                if (!int.TryParse(txtCalificacion.Text, out int calificacion))
                {
                    MessageBox.Show("La calificación debe ser un número entero.");
                    return;
                }

                Proyecto proyecto = new Proyecto
                {
                    Id_Proyecto = Convert.ToInt32(dgvProyectos.SelectedCells[0].Value),
                    Titulo = txtTitulo.Text,
                    TipoTrabajo = txtTipoTrabajo.Text,
                    Universidad = txtUniversidad.Text,
                    Gestion = txtGestion.Text,
                    ACTAMDG1 = cmbActaMDG1.Checked,
                    ACTAMDG2 = cmbActaMDG2.Checked,
                    Calficacion = calificacion,
                    ID_DocenteMDG2 = (int)cmbDocentes.SelectedValue,
                    ID_Tutor = (int)listBoxTutores.SelectedValue,
                    ID_Postulante = (int)cmbPostulantes.SelectedValue
                };

                proyectoController.EditarProyecto(proyecto);
                MessageBox.Show("Proyecto editado exitosamente.");
                CargarProyectos();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el proyecto: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProyectos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un proyecto para eliminar.");
                    return;
                }

                int idProyecto = Convert.ToInt32(dgvProyectos.SelectedCells[0].Value);
                proyectoController.EliminarProyecto(idProyecto);
                MessageBox.Show("Proyecto eliminado correctamente.");
                CargarProyectos();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proyecto: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoEstudiante.Text))
                {
                    MessageBox.Show("Ingresa un código de estudiante para buscar.");
                    return;
                }

                if (!int.TryParse(txtCodigoEstudiante.Text, out int codigoEstudiante))
                {
                    MessageBox.Show("Ingresa un código de estudiante válido.");
                    return;
                }

                DataTable dtProyecto = proyectoController.BuscarProyectoPorCodigo(codigoEstudiante);
                dgvProyectos.DataSource = dtProyecto;

                if (dtProyecto.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún proyecto con ese código de estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el proyecto: " + ex.Message);
            }
        }

        private void dgvProyectos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    
    

