using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> BuscarTodos();
        ContatoModel PesquisarporId(int id);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
