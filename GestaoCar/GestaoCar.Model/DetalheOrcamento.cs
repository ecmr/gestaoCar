namespace GestaoCar.Model
{
    public class DetalheOrcamento
    {
        public int OrdemServico { get; set; }
        public int CodigoCliente { get; set; }
        public string PecaExecutada { get; set; }
        public string NomePeca { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario{ get; set; }
        public decimal ValorTotal { get; set; }
    }
}
