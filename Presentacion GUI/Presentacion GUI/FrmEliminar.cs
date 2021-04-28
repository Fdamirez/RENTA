﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class FrmEliminar : Form
    {
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void TxtNumeroLiquidacion_Validating(object sender, CancelEventArgs e)
        {

            if (!validarID(TxtNumeroLiquidacion.Text, out string Mensaje))
            {
                errorProviderNumeroLiquidacion.SetError(TxtNumeroLiquidacion, Mensaje);
                e.Cancel = true;
            }

        }

        private bool validarID(string liquidacion, out string Mensaje)
        {
            bool var = Int32.TryParse(liquidacion, out int numero);

            if (string.IsNullOrEmpty(liquidacion))
            {
                Mensaje = "Llene el Campo";
                return false;
            }else if (!var)
            {
                Mensaje = "Campo solo permite numeros";
                return false;
            }

            Mensaje = "Todo Correcto";
            return true;

        }

        private void TxtNumeroLiquidacion_Validated(object sender, EventArgs e)
        {
            errorProviderNumeroLiquidacion.SetError(TxtNumeroLiquidacion,"");
        }

        private void TxtConfirmarLiquidacion_Validating(object sender, CancelEventArgs e)
        {
            if (!validarID(TxtNumeroLiquidacion.Text, TxtConfirmarLiquidacion.Text ,out string Mensaje))
            {
                errorProviderNumeroLiquidacion.SetError(TxtConfirmarLiquidacion, Mensaje);
                e.Cancel = true;
            }
        }

        private bool validarID(string text, string txtConfirmar, out string mensaje)
        {
            if (string.IsNullOrEmpty(txtConfirmar))
            {
                mensaje = "CONFIRME LIQUIDACION";
                return false;
            }else if (!text.Equals(txtConfirmar))
            {
                mensaje = " NO COINSIDE EL NUMERO DE LIQUIDACION";
                return false;
            }

            mensaje = "Todo Correcto";
            return true;
        }

        private void TxtConfirmarLiquidacion_Validated(object sender, EventArgs e)
        {
            errorProviderNumeroLiquidacion.SetError(TxtConfirmarLiquidacion, "");
        }
    }
}
