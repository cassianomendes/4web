namespace FourWeb.ExternalServices.Correios
{
    public class CorreiosResult
    {
        public int Codigo { get; set; }
        public decimal Valor { get; set; }
        public int PrazoEntrega { get; set; }
        public decimal ValorMaoPropria { get; set; }
        public decimal ValorAvisoRecebimento { get; set; }
        public decimal ValorValorDeclarado { get; set; }
        public char EntregaDomiciliar { get; set; }
        public char EntregaSabado { get; set; }
        public bool Erro { get; set; }
        public string MsgErro { get; set; }
        public decimal ValorSemAdicionais { get; set; }
        public string obsFim { get; set; }
    }
}
