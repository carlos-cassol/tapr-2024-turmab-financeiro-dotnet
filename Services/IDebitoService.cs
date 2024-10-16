using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public interface IDebitoService
    {
        public List<Debito> GetAll();
        public Debito Get();
    }
}