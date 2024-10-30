using microservfinanceiro.Financeiro.Enumerables;

namespace microservfinanceiro.Financeiro.Entities
{
    public class Emissoes
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }

        public string VencimentoPagamento { get; set; }

        public string TipoPagamento { get; set; }

        public decimal Juros { get; set; }

        public TipoBolsasEnum Tipo { get; set; }

        public decimal Porcentagem { get; set; }

        public Emissoes () {}

        public Emissoes (Guid id, decimal valor, string vencimentopagamento, string tipopagamento, decimal juros, TipoBolsasEnum tipo, decimal porcentagem)
        {
            Id = id;
            Valor = valor;
            VencimentoPagamento = vencimentopagamento;
            TipoPagamento = tipopagamento;
            Juros = juros;
            Tipo = tipo;
            Porcentagem = porcentagem;
        }
    }
}