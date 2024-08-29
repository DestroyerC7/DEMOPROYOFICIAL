namespace DEMOPROY1.VIews
{
    partial class INDEX
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dEMOPROYDataSet3 = new DEMOPROY1.DEMOPROYDataSet3();
            this.vISTAPROYECTOSFALTANTESACTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter = new DEMOPROY1.DEMOPROYDataSet3TableAdapters.VISTA_PROYECTOS_FALTANTES_ACTASTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cABALLOSDataSet = new DEMOPROY1.CABALLOSDataSet();
            this.cABALLOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cABALLOSTableAdapter = new DEMOPROY1.CABALLOSDataSetTableAdapters.CABALLOSTableAdapter();
            this.idCaballoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPROYECTOSFALTANTESACTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE PROYECTOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGISTRO DE POSTULANTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 77);
            this.button2.TabIndex = 5;
            this.button2.Text = "REGISTRO DE PERFIL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 79);
            this.button3.TabIndex = 6;
            this.button3.Text = "REGISTRO DE PROYECTO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(779, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(443, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "REPORTE DE PROYECTOS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(779, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(443, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "REPORTE DE DEFENSAS INTERNAS Y EXTERNAS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(779, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(443, 32);
            this.button6.TabIndex = 9;
            this.button6.Text = "REPORTE DE TUTORES Y SUS TUTORADOS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dEMOPROYDataSet3
            // 
            this.dEMOPROYDataSet3.DataSetName = "DEMOPROYDataSet3";
            this.dEMOPROYDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTAPROYECTOSFALTANTESACTASBindingSource
            // 
            this.vISTAPROYECTOSFALTANTESACTASBindingSource.DataMember = "VISTA_PROYECTOS_FALTANTES_ACTAS";
            this.vISTAPROYECTOSFALTANTESACTASBindingSource.DataSource = this.dEMOPROYDataSet3;
            // 
            // vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter
            // 
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 421);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(201, 80);
            this.button7.TabIndex = 10;
            this.button7.Text = "REGISTRO DE DEFENSAS INTERNAS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 524);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(201, 79);
            this.button8.TabIndex = 11;
            this.button8.Text = "REGISTRO DE DEFENSA EXTERNA";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DEMOPROY1.Properties.Resources.UPDS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCaballoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cABALLOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(244, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(780, 330);
            this.dataGridView1.TabIndex = 13;
            // 
            // cABALLOSDataSet
            // 
            this.cABALLOSDataSet.DataSetName = "CABALLOSDataSet";
            this.cABALLOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cABALLOSBindingSource
            // 
            this.cABALLOSBindingSource.DataMember = "CABALLOS";
            this.cABALLOSBindingSource.DataSource = this.cABALLOSDataSet;
            // 
            // cABALLOSTableAdapter
            // 
            this.cABALLOSTableAdapter.ClearBeforeFill = true;
            // 
            // idCaballoDataGridViewTextBoxColumn
            // 
            this.idCaballoDataGridViewTextBoxColumn.DataPropertyName = "Id_Caballo";
            this.idCaballoDataGridViewTextBoxColumn.HeaderText = "Id_Caballo";
            this.idCaballoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCaballoDataGridViewTextBoxColumn.Name = "idCaballoDataGridViewTextBoxColumn";
            this.idCaballoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCaballoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 150;
            // 
            // INDEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "INDEX";
            this.Text = "INDEX";
            this.Load += new System.EventHandler(this.INDEX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPROYECTOSFALTANTESACTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private DEMOPROYDataSet3 dEMOPROYDataSet3;
        private System.Windows.Forms.BindingSource vISTAPROYECTOSFALTANTESACTASBindingSource;
        private DEMOPROYDataSet3TableAdapters.VISTA_PROYECTOS_FALTANTES_ACTASTableAdapter vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CABALLOSDataSet cABALLOSDataSet;
        private System.Windows.Forms.BindingSource cABALLOSBindingSource;
        private CABALLOSDataSetTableAdapters.CABALLOSTableAdapter cABALLOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaballoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}