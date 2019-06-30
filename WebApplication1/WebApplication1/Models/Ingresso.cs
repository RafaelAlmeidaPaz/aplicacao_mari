using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Ingresso
    {

        public int Id { get; set; }
        public String NomeCliente { get; set; }
        public int NroDias { get; set; }
        public double ValorBasico { get; set; }
        DateTime DataInicial { get; set; }

    }
}
