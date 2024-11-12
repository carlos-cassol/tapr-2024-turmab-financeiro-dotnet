using microservfinanceiro.Financeiro.Enumerables;

namespace microservfinanceiro.Financeiro.Entities
{
    public class Bolsas
    {
        public Guid Id { get; set; }
        public TipoBolsasEnum Tipo { get; set; }
        public decimal PorcentagemDesconto { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFimVigencia { get; set; }
        public DateTime DataAplicacao { get; set; }
        public bool Disponibilidade { get; set; }

        public Bolsas() { }

        public Bolsas(Guid id, TipoBolsasEnum tipo, decimal porcentagemDesconto, DateTime dataInicioVigencia, DateTime dataFimVigencia, DateTime dataAplicacao, bool disponibilidade)
        {
            Id = id;
            Tipo = tipo;
            PorcentagemDesconto = porcentagemDesconto;
            DataInicioVigencia = dataInicioVigencia;
            DataFimVigencia = dataFimVigencia;
            DataAplicacao = dataAplicacao;
            Disponibilidade = disponibilidade;
        }
        
    }
}
