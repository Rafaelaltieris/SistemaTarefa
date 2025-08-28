using SistemaTarefa.Enums;

namespace SistemaTarefa.Model
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
