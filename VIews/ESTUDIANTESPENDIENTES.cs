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
    public partial class ESTUDIANTESPENDIENTES : Form
    {
        public ESTUDIANTESPENDIENTES()
        {
            InitializeComponent();
        }

        private void ESTUDIANTESPENDIENTES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet9.Vista_Postulantes_Defensa_Externa_Pendiente' Puede moverla o quitarla según sea necesario.
            this.vista_Postulantes_Defensa_Externa_PendienteTableAdapter.Fill(this.dEMOPROYDataSet9.Vista_Postulantes_Defensa_Externa_Pendiente);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet8.Vista_Postulantes_Defensa_Interna_Pendiente' Puede moverla o quitarla según sea necesario.
            this.vista_Postulantes_Defensa_Interna_PendienteTableAdapter.Fill(this.dEMOPROYDataSet8.Vista_Postulantes_Defensa_Interna_Pendiente);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet5.VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNA' Puede moverla o quitarla según sea necesario.
            this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter.Fill(this.dEMOPROYDataSet5.VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNA);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet4.VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNA' Puede moverla o quitarla según sea necesario.
            this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter.Fill(this.dEMOPROYDataSet4.VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNA);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
