using ONGWebAPI.Models;

namespace ONGWebAPI.Repository
{
    public interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();
        Usuario ExibirPelaID(int Id);       
        void ApagarUsuarioPelaId(int Id);
        void AtualizarInformacoesPelaId(int Id, Usuario Usuario);
        bool VerificarUsuario(int Id);
        void AdicionaNovoUsuario(Usuario Usuario);
        Usuario Login(string username, string hashPassword);

    }
}
