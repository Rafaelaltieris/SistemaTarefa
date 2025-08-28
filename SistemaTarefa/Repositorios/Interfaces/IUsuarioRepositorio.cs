using SistemaTarefa.Model;

namespace SistemaTarefa.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        //Será responsável por fazer a comunicação com o banco de dados e com a tabela de Usuários
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);

    }
}
