using microservfinanceiro.Financeiro.Enumerables;

namespace microservfinanceiro.Controller
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class BolsasController : ControllerBase
    {
        private IBolsasService _service;

        public BolsasController(IBolsasService service){
            this._service = service;
        }
    }
}
