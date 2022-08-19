using ONGWebAPI.Models;

namespace ONGWebAPI.Repository
{
    public interface IInteresseAdocao
    {
        void PostInteresseAdocao(InteresseAdocao interesseAdocao);
        List<InteresseAdocao> ListarInteressados();
    }
}
