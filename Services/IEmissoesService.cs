using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmissoesService
    {
        public List<Emissoes> GetAll();
        public Emissoes Get();
    }
}