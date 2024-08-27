namespace DEMOPROY1.VIews
{
    partial class TUTORESYTUTORADOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dEMOPROYDataSet7 = new DEMOPROY1.DEMOPROYDataSet7();
            this.vISTATUTORESYPOSTULANTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_TUTORES_Y_POSTULANTESTableAdapter = new DEMOPROY1.DEMOPROYDataSet7TableAdapters.VISTA_TUTORES_Y_POSTULANTESTableAdapter();
            this.nombreTutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoTutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePostulanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPostulanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTATUTORESYPOSTULANTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTutorDataGridViewTextBoxColumn,
            this.apellidoTutorDataGridViewTextBoxColumn,
            this.nombrePostulanteDataGridViewTextBoxColumn,
            this.apellidoPostulanteDataGridViewTextBoxColumn,
            this.tituloProyectoDataGridViewTextBoxColumn,
            this.gestionDataGridViewTextBoxColumn,
            this.semestreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vISTATUTORESYPOSTULANTESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUTORES Y TOTURADOS, SEMETRE Y GESTION";
            // 
            // dEMOPROYDataSet7
            // 
            this.dEMOPROYDataSet7.DataSetName = "DEMOPROYDataSet7";
            this.dEMOPROYDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTATUTORESYPOSTULANTESBindingSource
            // 
            this.vISTATUTORESYPOSTULANTESBindingSource.DataMember = "VISTA_TUTORES_Y_POSTULANTES";
            this.vISTATUTORESYPOSTULANTESBindingSource.DataSource = this.dEMOPROYDataSet7;
            // 
            // vISTA_TUTORES_Y_POSTULANTESTableAdapter
            // 
            this.vISTA_TUTORES_Y_POSTULANTESTableAdapter.ClearBeforeFill = true;
            // 
            // nombreTutorDataGridViewTextBoxColumn
            // 
            this.nombreTutorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Tutor";
            this.nombreTutorDataGridViewTextBoxColumn.HeaderText = "Nombre_Tutor";
            this.nombreTutorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreTutorDataGridViewTextBoxColumn.Name = "nombreTutorDataGridViewTextBoxColumn";
            this.nombreTutorDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoTutorDataGridViewTextBoxColumn
            // 
            this.apellidoTutorDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Tutor";
            this.apellidoTutorDataGridViewTextBoxColumn.HeaderText = "Apellido_Tutor";
            this.apellidoTutorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoTutorDataGridViewTextBoxColumn.Name = "apellidoTutorDataGridViewTextBoxColumn";
            this.apellidoTutorDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombrePostulanteDataGridViewTextBoxColumn
            // 
            this.nombrePostulanteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Postulante";
            this.nombrePostulanteDataGridViewTextBoxColumn.HeaderText = "Nombre_Postulante";
            this.nombrePostulanteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombrePostulanteDataGridViewTextBoxColumn.Name = "nombrePostulanteDataGridViewTextBoxColumn";
            this.nombrePostulanteDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoPostulanteDataGridViewTextBoxColumn
            // 
            this.apellidoPostulanteDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Postulante";
            this.apellidoPostulanteDataGridViewTextBoxColumn.HeaderText = "Apellido_Postulante";
            this.apellidoPostulanteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoPostulanteDataGridViewTextBoxColumn.Name = "apellidoPostulanteDataGridViewTextBoxColumn";
            this.apellidoPostulanteDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloProyectoDataGridViewTextBoxColumn
            // 
            this.tituloProyectoDataGridViewTextBoxColumn.DataPropertyName = "Titulo_Proyecto";
            this.tituloProyectoDataGridViewTextBoxColumn.HeaderText = "Titulo_Proyecto";
            this.tituloProyectoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloProyectoDataGridViewTextBoxColumn.Name = "tituloProyectoDataGridViewTextBoxColumn";
            this.tituloProyectoDataGridViewTextBoxColumn.Width = 150;
            // 
            // gestionDataGridViewTextBoxColumn
            // 
            this.gestionDataGridViewTextBoxColumn.DataPropertyName = "Gestion";
            this.gestionDataGridViewTextBoxColumn.HeaderText = "Gestion";
            this.gestionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gestionDataGridViewTextBoxColumn.Name = "gestionDataGridViewTextBoxColumn";
            this.gestionDataGridViewTextBoxColumn.Width = 150;
            // 
            // semestreDataGridViewTextBoxColumn
            // 
            this.semestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre";
            this.semestreDataGridViewTextBoxColumn.HeaderText = "Semestre";
            this.semestreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.semestreDataGridViewTextBoxColumn.Name = "semestreDataGridViewTextBoxColumn";
            this.semestreDataGridViewTextBoxColumn.Width = 150;
            // 
            // TUTORESYTUTORADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TUTORESYTUTORADOS";
            this.Text = "TUTORESYTUTORADOS";
            this.Load += new System.EventHandler(this.TUTORESYTUTORADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTATUTORESYPOSTULANTESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DEMOPROYDataSet7 dEMOPROYDataSet7;
        private System.Windows.Forms.BindingSource vISTATUTORESYPOSTULANTESBindingSource;
        private DEMOPROYDataSet7TableAdapters.VISTA_TUTORES_Y_POSTULANTESTableAdapter vISTA_TUTORES_Y_POSTULANTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoTutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePostulanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPostulanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreDataGridViewTextBoxColumn;
    }
}