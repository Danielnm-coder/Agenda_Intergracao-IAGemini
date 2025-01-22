namespace ProjetoGemini.Dtos
{
    public class TarefaRequestDto
    {
        public string? Nome { get; set; }
        public string? Urgencia { get; set; }
        public int TempoEmHoras { get; set; }
        public string? Complexidade { get; set; }

    }
}
