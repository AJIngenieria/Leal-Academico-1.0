using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProduccion_Cliente_Financiera : Form
    {
        private DataTable dtDetalle;
        public frmProduccion_Cliente_Financiera()
        {
            InitializeComponent();
        }

        private void frmProduccion_Cliente_DatosFinancieros_Load(object sender, EventArgs e)
        {
            this.CrearTabla();
            this.AutoAjustar_Columnas();
        }

        private void AutoAjustar_Columnas()
        {
            DGResultado.Columns[0].Width = 83;
            DGResultado.Columns[1].Width = 221;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo ID", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultado.DataSource = this.dtDetalle;

            DataRow row = dtDetalle.NewRow();
            DataRow row2 = dtDetalle.NewRow();
            DataRow row3 = dtDetalle.NewRow();
            row["Codigo ID"] = "T00034591";
            row["Descripcion"] = "ALEXANDER JAVIER GUERRERO CUELLO";

            row2["Codigo ID"] = "T00012345";
            row2["Descripcion"] = "EDVINA DE JESUS CUELLO PANZZA";

            row3["Codigo ID"] = "T00054321";
            row3["Descripcion"] = "PEDRO SAMIR CUELLO ATENCIO";

            dtDetalle.Rows.Add(row);
            dtDetalle.Rows.Add(row2);
            dtDetalle.Rows.Add(row3);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

        }

        private void DGResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
