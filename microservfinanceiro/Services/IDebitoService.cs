using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public interface IDebitoService
    {
        public Task<List<Debitos>> GetAllAsync();
        public Task<Debitos> SaveAsync(Debitos debito);
    }
}