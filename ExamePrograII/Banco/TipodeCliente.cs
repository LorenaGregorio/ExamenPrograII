using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class TipodeCliente : Cliente
    {
        private static string tipodecliente;
        public TipodeCliente(string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {

        }
        static TipodeCliente() => tipodecliente = "Premium";

        public bool ClienteconCuenta { get; set; }

        public string TipodeCuenta { get; set; }

        
    }
}
