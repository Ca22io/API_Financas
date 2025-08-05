namespace API_Financas.Dto.Transacao
{
    public class TransacaoPutDto
    {
        public required int IdTransacao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

    }
}