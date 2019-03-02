using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class ClienteEmbarazada : Cliente

    {
        private static string gestacion;
        public ClienteEmbarazada(string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {
           
        }
        static ClienteEmbarazada() => gestacion = "Embarazada hasta case";

        public string TipodePrioridadEmbarazada { get; set; }
    }
}
