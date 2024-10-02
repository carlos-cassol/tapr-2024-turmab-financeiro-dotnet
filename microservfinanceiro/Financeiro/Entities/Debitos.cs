using microservfinanceiro.Financeiro.Enumerables;

namespace microservfinanceiro.Financeiro.Entities
{
    public class Debitos
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string TipoPagamento { get; set; }
        public decimal? Juros { get; set; }
        public decimal Mensalidade { get; set; }
        public StatusPagamentoEnum StatusPagamento { get; set; }

        public Debitos() { }

        public Debitos(Guid id, decimal valor, DateTime dataVencimento, string tipoPagamento, decimal? juros, decimal mensalidade, StatusPagamentoEnum statusPagamento)
        {
            Id = id;
            Valor = valor;
            DataVencimento = dataVencimento;
            TipoPagamento = tipoPagamento;
            Juros = juros ?? 0;
            Mensalidade = mensalidade;
            StatusPagamento = statusPagamento;
        }
    }
}
