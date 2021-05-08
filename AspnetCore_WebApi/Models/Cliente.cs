using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_WebApi.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string NomeMae { get; set;}
        public string NomePai { get; set; }
        public bool Filhos { get; set; }
        //public long QtFilhos { get; set; }

    }
}
