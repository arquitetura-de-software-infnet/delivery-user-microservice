using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUsuarios.Data.Entities
{
    public class Historico
    {
        public Guid IdHistorico { get; set; }
        public Guid IdUsuario { get; set; }
        public string Operacao { get; set; }
        public DateTime DataHora { get; set; }
        public string Detalhes { get; set; }

        //relacionar com o Usuario
        //Historico TEM 1 Usuario
        public Usuario Usuario { get; set; }
    }
}
