using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class ClienteconNiños : Cliente
    {
     
        private static string estado ;

        public ClienteconNiños(string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {

        }

        static ClienteconNiños() => estado = "Con un niño";


        public string TipodePrioridad { get; set; }
    }
}
