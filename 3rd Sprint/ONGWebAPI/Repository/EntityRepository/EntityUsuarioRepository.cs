using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class EntityUsuarioRepository : IUsuarioRepository
    {
        //injeção de depndencia
        private ONGContext DbONG;

        public EntityUsuarioRepository(ONGContext DbONG)
        {
            this.DbONG = DbONG;
        }

        public void AdicionaNovoUsuario(Usuario usuario)
        {
            DbONG.ChangeTracker.Clear();
            DbONG.Entry(usuario).State = EntityState.Added;
            DbONG.SaveChanges();
        }

        public void ApagarUsuarioPelaId(int Id)
        {            
            DbONG.ChangeTracker.Clear();
            var usuario = DbONG.Usuarios.Find(Id);
            DbONG.Entry(usuario).State = EntityState.Deleted;
            DbONG.SaveChanges();
        }

        public void AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        {
            DbONG.ChangeTracker.Clear();
            Usuario.Id = Id;
            DbONG.Entry(Usuario).State = EntityState.Modified;
            DbONG.Entry(Usuario).Property(e => e.Username).IsModified = false;
            DbONG.Entry(Usuario).Property(e => e.Password).IsModified = false;
            DbONG.Entry(Usuario).Property(e => e.Role).IsModified = false;
            DbONG.SaveChanges();
        }

        public Usuario ExibirPelaID(int Id)
        {
            return DbONG.Usuarios?.Find(Id);
        }

        public List<Usuario> ListarTodos()
        {
            return DbONG.Usuarios?.ToList();
        }
        public bool VerificarUsuario(int Id)
        {
            return DbONG.Usuarios.Any(Coluna => Coluna.Id == Id);
        }

        public Usuario Login(string username, string hashPassword)
        {
            return DbONG.Usuarios.FirstOrDefault(x => x.Username == username && x.Password == hashPassword);
        }


    }
}
