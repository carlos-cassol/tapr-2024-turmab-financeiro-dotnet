using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public interface IBolsasService
    {
        public List<Bolsas> GetAll();
        public Bolsas Get();
    }
}