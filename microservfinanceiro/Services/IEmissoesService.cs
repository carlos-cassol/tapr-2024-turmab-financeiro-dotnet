using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public interface IEmissoesService
    {
        public Task<List<Emissoes>> GetAllAsync();
        public Task<Emissoes> SaveAsync(Emissoes emissao);
    }
}