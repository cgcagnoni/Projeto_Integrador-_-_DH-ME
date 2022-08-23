using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class EntityInteresseAdocaoRepository : IInteresseAdocao
    {
        private ONGContext DbONG;

        public EntityInteresseAdocaoRepository(ONGContext dbONG)
        {
            DbONG = dbONG;
        }

        public List<InteresseAdocao> ListarInteressados()
        {
            return DbONG.InteresseAdocao.ToList();
        }       

        public List<InteresseAdocao> ListarInteressadosPorUsuario(int id)
        {
            var animal = DbONG.InteresseAdocao.Where(t => t.Animal.Usuario.Id == id);

            return animal.ToList();

        }

        public void PostInteresseAdocao(InteresseAdocao interesseAdocao)
        {

            DbONG.ChangeTracker.Clear();
            DbONG.Entry(interesseAdocao).State = EntityState.Added;
            DbONG.SaveChanges();
            //DbONG.Entry(interesseAdocao).Reference(x => x.Animal).Load();
        }
    }
}
