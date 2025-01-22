namespace ProjetoGemini.Dtos
{
    public class AgendaRequestDto
    {
        public string? DataInicio { get; set; }
        public string? DataFim { get; set; }
        public string? Descricao { get; set; }
        public List<TarefaRequestDto>? Tarefas { get; set; }

    }
}
