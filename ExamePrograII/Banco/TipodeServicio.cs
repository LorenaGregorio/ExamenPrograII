using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class TipodeServicio : Cliente
    {
        private static string tipodeservicio;
        public TipodeServicio(string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {

        }
        static TipodeServicio() => tipodeservicio = "Pago de tarjeta de credito";
        public string NombredelServicioPrestado { get; set; }

        public string SecciondelServicio { get; set; }
    }
}
