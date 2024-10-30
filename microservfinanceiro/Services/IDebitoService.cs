using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public interface IDebitoService
    {
        public List<Debitos> GetAll();
        public Debitos Get();
        Task<object?> GetAllAsync();
        Task<object?> SaveAsync(Debitos aluno);
    }
}