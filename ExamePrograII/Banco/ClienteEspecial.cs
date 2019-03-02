using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class ClienteEspecial : Cliente
    {
        private static string DiscapacidadEspecial;
        public ClienteEspecial(string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {

        }
        static ClienteEspecial() => DiscapacidadEspecial = "Sordomudo";

       


        public string TipodePrioridadClienteEspecial { get; set; }
    }
}
