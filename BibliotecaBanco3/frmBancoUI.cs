using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaBanco3
{
    public partial class frmBancoUI : Form
    {
        protected int CuentaTextBox = 4;

        public enum IndicesTexBos
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO
        }
        public frmBancoUI()
        {
            InitializeComponent();
        }

        public void LimpiarControlesTexBox()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control niControl = Controls[i];
                if (niControl is TextBox) 
                {
                    niControl.Text = "";
                }
            }
        }
        public void EstablecerValoresControlesTexBox(string[] valores)
        {
            //determina si el arreglo string tiene la longitud correcta
            if(valores.Length != CuentaTextBox)
            {
                //lansa excepcion si no tiene la longitud correcta
                throw (new ArgumentException("Debe haber" + (CuentaTextBox + 1) + "Objetos string en el arreglo"));
            }
            else
            {
                txtCuenta.Text = valores[(int)IndicesTexBos.CUENTA];
                txtPrimerNombre.Text = valores[(int)IndicesTexBos.NOMBRE];
                txtApellidoPaterno.Text = valores[(int)IndicesTexBos.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTexBos.SALDO];
            }
        }
        public string[] ObtenerValoresControlesTextBox()
        {
            string[] valores = new string[CuentaTextBox];

            valores[(int)IndicesTexBos.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTexBos.NOMBRE] = txtPrimerNombre.Text;
            valores[(int)IndicesTexBos.APELLIDO] = txtApellidoPaterno.Text;
            valores[(int)IndicesTexBos.SALDO] = txtSaldo.Text;
            return valores;
        }
        private void frmBancoUI_Load(object sender, EventArgs e)
        {

        }
    }
}
