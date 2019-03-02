using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class ClienteTerceraEdad : Cliente
    {
        private static string cucho;
        public ClienteTerceraEdad(string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {

        }
        static ClienteTerceraEdad() => cucho = "Persona mayor de 60 años";

        public string TipodePrioridadClienteTercera { get; set; }
    }
}
