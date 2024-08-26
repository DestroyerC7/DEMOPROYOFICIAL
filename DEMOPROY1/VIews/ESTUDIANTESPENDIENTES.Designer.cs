namespace DEMOPROY1.VIews
{
    partial class ESTUDIANTESPENDIENTES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dEMOPROYDataSet4 = new DEMOPROY1.DEMOPROYDataSet4();
            this.vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter = new DEMOPROY1.DEMOPROYDataSet4TableAdapters.VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter();
            this.idProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEMOPROYDataSet5 = new DEMOPROY1.DEMOPROYDataSet5();
            this.vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter = new DEMOPROY1.DEMOPROYDataSet5TableAdapters.VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter();
            this.idProyectoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTrabajoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEstudianteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSTULANTES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FALTA DEFENSA INTERNA ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "POSTULANTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "FALTA DEFENSA EXTERNA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProyectoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.tipoTrabajoDataGridViewTextBoxColumn,
            this.gestionDataGridViewTextBoxColumn,
            this.primerNombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.codigoEstudianteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 219);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProyectoDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn1,
            this.tipoTrabajoDataGridViewTextBoxColumn1,
            this.gestionDataGridViewTextBoxColumn1,
            this.primerNombreDataGridViewTextBoxColumn1,
            this.primerApellidoDataGridViewTextBoxColumn1,
            this.codigoEstudianteDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(127, 402);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1113, 227);
            this.dataGridView2.TabIndex = 5;
            // 
            // dEMOPROYDataSet4
            // 
            this.dEMOPROYDataSet4.DataSetName = "DEMOPROYDataSet4";
            this.dEMOPROYDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource
            // 
            this.vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource.DataMember = "VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNA";
            this.vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource.DataSource = this.dEMOPROYDataSet4;
            // 
            // vISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter
            // 
            this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter.ClearBeforeFill = true;
            // 
            // idProyectoDataGridViewTextBoxColumn
            // 
            this.idProyectoDataGridViewTextBoxColumn.DataPropertyName = "Id_Proyecto";
            this.idProyectoDataGridViewTextBoxColumn.HeaderText = "Id_Proyecto";
            this.idProyectoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idProyectoDataGridViewTextBoxColumn.Name = "idProyectoDataGridViewTextBoxColumn";
            this.idProyectoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoTrabajoDataGridViewTextBoxColumn
            // 
            this.tipoTrabajoDataGridViewTextBoxColumn.DataPropertyName = "TipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn.HeaderText = "TipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoTrabajoDataGridViewTextBoxColumn.Name = "tipoTrabajoDataGridViewTextBoxColumn";
            this.tipoTrabajoDataGridViewTextBoxColumn.Width = 150;
            // 
            // gestionDataGridViewTextBoxColumn
            // 
            this.gestionDataGridViewTextBoxColumn.DataPropertyName = "Gestion";
            this.gestionDataGridViewTextBoxColumn.HeaderText = "Gestion";
            this.gestionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gestionDataGridViewTextBoxColumn.Name = "gestionDataGridViewTextBoxColumn";
            this.gestionDataGridViewTextBoxColumn.Width = 150;
            // 
            // primerNombreDataGridViewTextBoxColumn
            // 
            this.primerNombreDataGridViewTextBoxColumn.DataPropertyName = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.HeaderText = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.primerNombreDataGridViewTextBoxColumn.Name = "primerNombreDataGridViewTextBoxColumn";
            this.primerNombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoEstudianteDataGridViewTextBoxColumn
            // 
            this.codigoEstudianteDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Estudiante";
            this.codigoEstudianteDataGridViewTextBoxColumn.HeaderText = "Codigo_Estudiante";
            this.codigoEstudianteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoEstudianteDataGridViewTextBoxColumn.Name = "codigoEstudianteDataGridViewTextBoxColumn";
            this.codigoEstudianteDataGridViewTextBoxColumn.Width = 150;
            // 
            // dEMOPROYDataSet5
            // 
            this.dEMOPROYDataSet5.DataSetName = "DEMOPROYDataSet5";
            this.dEMOPROYDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource
            // 
            this.vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource.DataMember = "VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNA";
            this.vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource.DataSource = this.dEMOPROYDataSet5;
            // 
            // vISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter
            // 
            this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter.ClearBeforeFill = true;
            // 
            // idProyectoDataGridViewTextBoxColumn1
            // 
            this.idProyectoDataGridViewTextBoxColumn1.DataPropertyName = "Id_Proyecto";
            this.idProyectoDataGridViewTextBoxColumn1.HeaderText = "Id_Proyecto";
            this.idProyectoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idProyectoDataGridViewTextBoxColumn1.Name = "idProyectoDataGridViewTextBoxColumn1";
            this.idProyectoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            this.tituloDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tipoTrabajoDataGridViewTextBoxColumn1
            // 
            this.tipoTrabajoDataGridViewTextBoxColumn1.DataPropertyName = "TipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn1.HeaderText = "TipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tipoTrabajoDataGridViewTextBoxColumn1.Name = "tipoTrabajoDataGridViewTextBoxColumn1";
            this.tipoTrabajoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // gestionDataGridViewTextBoxColumn1
            // 
            this.gestionDataGridViewTextBoxColumn1.DataPropertyName = "Gestion";
            this.gestionDataGridViewTextBoxColumn1.HeaderText = "Gestion";
            this.gestionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.gestionDataGridViewTextBoxColumn1.Name = "gestionDataGridViewTextBoxColumn1";
            this.gestionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // primerNombreDataGridViewTextBoxColumn1
            // 
            this.primerNombreDataGridViewTextBoxColumn1.DataPropertyName = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn1.HeaderText = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.primerNombreDataGridViewTextBoxColumn1.Name = "primerNombreDataGridViewTextBoxColumn1";
            this.primerNombreDataGridViewTextBoxColumn1.Width = 150;
            // 
            // primerApellidoDataGridViewTextBoxColumn1
            // 
            this.primerApellidoDataGridViewTextBoxColumn1.DataPropertyName = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn1.HeaderText = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.primerApellidoDataGridViewTextBoxColumn1.Name = "primerApellidoDataGridViewTextBoxColumn1";
            this.primerApellidoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // codigoEstudianteDataGridViewTextBoxColumn1
            // 
            this.codigoEstudianteDataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Estudiante";
            this.codigoEstudianteDataGridViewTextBoxColumn1.HeaderText = "Codigo_Estudiante";
            this.codigoEstudianteDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.codigoEstudianteDataGridViewTextBoxColumn1.Name = "codigoEstudianteDataGridViewTextBoxColumn1";
            this.codigoEstudianteDataGridViewTextBoxColumn1.Width = 150;
            // 
            // ESTUDIANTESPENDIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 705);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ESTUDIANTESPENDIENTES";
            this.Text = "ESTUDIANTESPENDIENTES";
            this.Load += new System.EventHandler(this.ESTUDIANTESPENDIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DEMOPROYDataSet4 dEMOPROYDataSet4;
        private System.Windows.Forms.BindingSource vISTAESTUDIANTESFALTANDEFENSAINTERNABindingSource;
        private DEMOPROYDataSet4TableAdapters.VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter vISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstudianteDataGridViewTextBoxColumn;
        private DEMOPROYDataSet5 dEMOPROYDataSet5;
        private System.Windows.Forms.BindingSource vISTAESTUDIANTESFALTANDEFENSAEXTERNABindingSource;
        private DEMOPROYDataSet5TableAdapters.VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter vISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTrabajoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstudianteDataGridViewTextBoxColumn1;
    }
}