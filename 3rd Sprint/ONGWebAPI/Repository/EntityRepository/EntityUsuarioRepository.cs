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

        public void AdicionaNovoUsuario(Usuario Usuario)
        {
            DbONG.Usuarios?.Add(Usuario);
            DbONG.SaveChanges();
        }

        public void ApagarUsuarioPelaId(int Id)
        {
            var user = DbONG.Usuarios?.Find(Id);
            DbONG.Usuarios?.Remove(user);
            DbONG.SaveChanges();
        }

        public void AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        {
            // Procura se já existe um usuario com o id no cache local
            var local = DbONG.Set<Usuario>()
                .Local
                .FirstOrDefault(entry => entry.Id == Id);

            if (local != null)
            {
                // caso exista, remove do cache local para o entity coneguir atualizar
                DbONG.Entry(local).State = EntityState.Detached;
            }

            Usuario.Id = Id;
            DbONG.Update(Usuario);
            // DbONG.Entry(Usuario).State = EntityState.Modified;
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
    }
}
