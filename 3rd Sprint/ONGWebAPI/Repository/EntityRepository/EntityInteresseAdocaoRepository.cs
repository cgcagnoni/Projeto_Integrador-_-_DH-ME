using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;
using ONGWebAPI.Services;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class EntityInteresseAdocaoRepository : IInteresseAdocao
    {
        private ONGContextFactory DbONGFactory;
        public EntityInteresseAdocaoRepository(ONGContextFactory DbONGFactory)
        {
            this.DbONGFactory = DbONGFactory;
        }

        public List<InteresseAdocao> ListarInteressados()
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.InteresseAdocao.ToList();
        }       

        public List<InteresseAdocao> ListarInteressadosPorUsuario(int id)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.InteresseAdocao.Where(t => t.Animal.Usuario.Id == id);

                return animal.ToList();
            }
        }

        public void PostInteresseAdocao(InteresseAdocao interesseAdocao)
        {
            using (var DbONG = DbONGFactory.create())
            {                
                DbONG.Entry(interesseAdocao).State = EntityState.Added;
                DbONG.SaveChanges();
                DbONG.Entry(interesseAdocao).Reference(x => x.Animal).Load();
            }
        }
    }
}
