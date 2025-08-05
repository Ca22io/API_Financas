namespace API_Financas.Dto.Transacao
{
    public class TransacaoDto
    {
        public required string Descricao { get; set; }

        public required decimal Valor { get; set; }

        public DateOnly Data { get; set; }

        public required int IdTipo { get; set; }

        public required int IdCategoria { get; set; }
    }
}