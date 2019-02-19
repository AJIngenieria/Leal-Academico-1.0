﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmExaminarProduccion_Bodega : Form
    {
        public frmExaminarProduccion_Bodega()
        {
            InitializeComponent();
        }

        private void frmExaminarProduccion_Bodega_Load(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fProduccion_Bodega.Buscar_Bodega(this.TBBuscar.Text);
                this.DGResultados.Columns[0].Visible = false;
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //    {
            //        frmProduccion_Bodegas_Ingreso form = frmProduccion_Bodegas_Ingreso.GetInstancia();
            //        string par1, par2, par3;
            //        par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["idbodega"].Value);
            //        par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Descripcion"].Value);
            //        par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["CodigoID"].Value);
            //        form.setBodega(par1, par2, par3);
            //        this.Hide();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    frmProduccion_Bodegas_Ingreso form = frmProduccion_Bodegas_Ingreso.GetInstancia();
                    string par1, par2, par3;
                    par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["idbodega"].Value);
                    par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Descripcion"].Value);
                    par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["CodigoID"].Value);
                    form.setBodega(par1, par2, par3);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}