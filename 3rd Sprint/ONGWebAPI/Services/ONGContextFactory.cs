using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Repository.EntityRepository;

namespace ONGWebAPI.Services
{
    public class ONGContextFactory
    {

        private bool usarBancoEmMemoria;

        public ONGContextFactory(bool usarBancoEmMemoria)
        {
            this.usarBancoEmMemoria = usarBancoEmMemoria;
        }

        public ONGContext create()
        {
            
            return new ONGContext(this.usarBancoEmMemoria);
        }

    }
}
