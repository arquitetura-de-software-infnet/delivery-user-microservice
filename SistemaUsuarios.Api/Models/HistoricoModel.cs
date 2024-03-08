namespace SistemaUsuarios.Api.Models
{
    public class HistoricoModel
    {
        public Guid IdHistorico { get; set; }
        public DateTime DataHora { get; set; }
        public string Operacao { get; set; }
    }
}
