using Sistema_de_Tarefas.Models;

namespace Sistema_de_Tarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(TarefaModel tarefa);
        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
