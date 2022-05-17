using CRUDWebAPI.Model;

namespace CRUDWebAPI.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> BuscaUsuarios();
        Task<Usuario> BuscaUsuario(int id);
        void AdicionaUsuario(Usuario usuario);
        void AtualizaUsuario(Usuario usuario);
        void DeletaUsusario(Usuario usuario);
        Task<bool> SaveChangesAsync();
    }
}