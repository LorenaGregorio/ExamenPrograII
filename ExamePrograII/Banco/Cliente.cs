using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class Cliente
    {

        private string tipoCliente;
        private string fechadeCita;
        private string tipodeTransaccion;

        public Cliente(string tipoCliente, string fechadeCita, string tipodeTransaccion)
        {
            tipoCliente = tipoCliente;
            fechadeCita = fechadeCita;
            tipodeTransaccion = tipodeTransaccion;
        }

        //public string TipodeCliente { get; set; }

        //public string FechadeCita { get; set; }

        //public string TipodeTransaccion { get; set; }

    }



}
