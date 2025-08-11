namespace API_Financas.Dto.Transacao
{
    public class TransacaoGetDto
    {
        public int IdTransacao { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateOnly? Data { get; set; }
        public string? NomeTipo { get; set; }
        public string? NomeCategoria { get; set; }
    }
}