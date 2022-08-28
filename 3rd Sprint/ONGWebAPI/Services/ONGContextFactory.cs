using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Repository.EntityRepository;

namespace ONGWebAPI.Services
{
    public class ONGContextFactory
    {

        private bool usarBancoEmMemoria;
        private string connectionString;

        private bool executarMigrate = true;

        public ONGContextFactory(string connectionString, bool usarBancoEmMemoria)
        {
            this.usarBancoEmMemoria = usarBancoEmMemoria;
            this.connectionString = connectionString;
        }

        public ONGContext create()
        {
            var db = new ONGContext(this.connectionString, this.usarBancoEmMemoria);
            if (!usarBancoEmMemoria && executarMigrate)
            {
                this.executarMigrate = false;
                db.Database.Migrate();
            }
            return db;
        }

    }
}
