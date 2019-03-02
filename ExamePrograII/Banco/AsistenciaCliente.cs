using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamePrograII.Banco
{
    public class AsistenciaCliente : Cliente
    {
        private static string ServiciosCliente;

        public AsistenciaCliente (string tipodeCliente, string fechadeCita, string tipodeTransaccion) : base(tipodeCliente, fechadeCita, tipodeTransaccion)
        {
            
        }
        static AsistenciaCliente() => ServiciosCliente = "pagos"; 

        public string TipodeConsultadeCliente { get; set; }

    }
}
