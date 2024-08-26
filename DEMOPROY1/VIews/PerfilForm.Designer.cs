namespace DEMOPROY1.VIews
{
    partial class PerfilForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGestion = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.listPostulantes = new System.Windows.Forms.ListBox();
            this.dEMOPROYDataSet2 = new DEMOPROY1.DEMOPROYDataSet2();
            this.pERFILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERFILTableAdapter = new DEMOPROY1.DEMOPROYDataSet2TableAdapters.PERFILTableAdapter();
            this.idPerfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GESTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEMESTRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "POSTULANTE";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(69, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 49);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(228, 275);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 49);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(373, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 49);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(537, 275);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 49);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AutoGenerateColumns = false;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPerfilDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.gestionDataGridViewTextBoxColumn,
            this.semestreDataGridViewTextBoxColumn,
            this.codigoEstudianteDataGridViewTextBoxColumn});
            this.dgvPerfiles.DataSource = this.pERFILBindingSource;
            this.dgvPerfiles.Location = new System.Drawing.Point(373, 67);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.RowHeadersWidth = 62;
            this.dgvPerfiles.RowTemplate.Height = 28;
            this.dgvPerfiles.Size = new System.Drawing.Size(415, 181);
            this.dgvPerfiles.TabIndex = 9;
            this.dgvPerfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfiles_CellContentClick);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(147, 78);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 26);
            this.txtTitulo.TabIndex = 10;
            // 
            // txtGestion
            // 
            this.txtGestion.Location = new System.Drawing.Point(147, 115);
            this.txtGestion.Name = "txtGestion";
            this.txtGestion.Size = new System.Drawing.Size(100, 26);
            this.txtGestion.TabIndex = 11;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(147, 153);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(100, 26);
            this.txtSemestre.TabIndex = 12;
            // 
            // listPostulantes
            // 
            this.listPostulantes.FormattingEnabled = true;
            this.listPostulantes.ItemHeight = 20;
            this.listPostulantes.Location = new System.Drawing.Point(147, 196);
            this.listPostulantes.Name = "listPostulantes";
            this.listPostulantes.Size = new System.Drawing.Size(100, 24);
            this.listPostulantes.TabIndex = 13;
            // 
            // dEMOPROYDataSet2
            // 
            this.dEMOPROYDataSet2.DataSetName = "DEMOPROYDataSet2";
            this.dEMOPROYDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERFILBindingSource
            // 
            this.pERFILBindingSource.DataMember = "PERFIL";
            this.pERFILBindingSource.DataSource = this.dEMOPROYDataSet2;
            // 
            // pERFILTableAdapter
            // 
            this.pERFILTableAdapter.ClearBeforeFill = true;
            // 
            // idPerfilDataGridViewTextBoxColumn
            // 
            this.idPerfilDataGridViewTextBoxColumn.DataPropertyName = "Id_Perfil";
            this.idPerfilDataGridViewTextBoxColumn.HeaderText = "Id_Perfil";
            this.idPerfilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPerfilDataGridViewTextBoxColumn.Name = "idPerfilDataGridViewTextBoxColumn";
            this.idPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPerfilDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
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
            // codigoEstudianteDataGridViewTextBoxColumn
            // 
            this.codigoEstudianteDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Estudiante";
            this.codigoEstudianteDataGridViewTextBoxColumn.HeaderText = "Codigo_Estudiante";
            this.codigoEstudianteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoEstudianteDataGridViewTextBoxColumn.Name = "codigoEstudianteDataGridViewTextBoxColumn";
            this.codigoEstudianteDataGridViewTextBoxColumn.Width = 150;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(676, 286);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 14;
            // 
            // PerfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.listPostulantes);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtGestion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dgvPerfiles);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PerfilForm";
            this.Text = "PerfilFomr";
            this.Load += new System.EventHandler(this.PerfilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGestion;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.ListBox listPostulantes;
        private DEMOPROYDataSet2 dEMOPROYDataSet2;
        private System.Windows.Forms.BindingSource pERFILBindingSource;
        private DEMOPROYDataSet2TableAdapters.PERFILTableAdapter pERFILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}