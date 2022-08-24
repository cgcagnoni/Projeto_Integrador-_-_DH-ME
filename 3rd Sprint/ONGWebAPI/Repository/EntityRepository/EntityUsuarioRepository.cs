using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;
using ONGWebAPI.Services;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class EntityUsuarioRepository : IUsuarioRepository
    {
        //injeção de depndencia
        private ONGContextFactory DbONGFactory;

        public EntityUsuarioRepository(ONGContextFactory DbONGFactory)
        {
            this.DbONGFactory = DbONGFactory;
        }

        public void AdicionaNovoUsuario(Usuario usuario)
        {
            using (var DbONG = DbONGFactory.create())
            {
                DbONG.Entry(usuario).State = EntityState.Added;
                DbONG.SaveChanges();
            }

        }

        public void ApagarUsuarioPelaId(int Id)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var usuario = DbONG.Usuarios.Find(Id);
                DbONG.Entry(usuario).State = EntityState.Deleted;
                DbONG.SaveChanges();
            }
            //DbONG.ChangeTracker.Clear();
        }

        public void AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        {
            using (var DbONG = DbONGFactory.create())
            {
                Usuario.Id = Id;
                DbONG.Entry(Usuario).State = EntityState.Modified;
                DbONG.Entry(Usuario).Property(e => e.Username).IsModified = false;
                DbONG.Entry(Usuario).Property(e => e.Password).IsModified = false;
                DbONG.Entry(Usuario).Property(e => e.Role).IsModified = false;
                DbONG.SaveChanges();
            }
        }

        public Usuario ExibirPelaID(int Id)
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Usuarios?.Find(Id);
        }

        public List<Usuario> ListarTodos()
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Usuarios?.ToList();
        }
        public bool VerificarUsuario(int Id)
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Usuarios.Any(Coluna => Coluna.Id == Id);
        }

        public Usuario Login(string username, string hashPassword)
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Usuarios.FirstOrDefault(x => x.Username == username && x.Password == hashPassword);
        }


    }
}
