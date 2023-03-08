using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco3
{
    internal class Registro
    {
        private int cuenta;
        private string primerNombre;
        private string apellidoPaterno;
        private decimal saldo;

        //el constructor sin parametros establece los miembros a losvalores predeterminados
        public Registro() : this (0, "", "", 0.0M)
        {

        }
        //el constructor sobrecargado
        public Registro(int valorCuenta,string valorPrimerNombre,string valorApellidoPaterno,decimal valorSaldo)
        {
            Cuenta = valorCuenta;
            PrimerNombre = valorPrimerNombre;
            ApellidoPaterno = valorApellidoPaterno;
            Saldo = valorSaldo;
        }

        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
    }
}
