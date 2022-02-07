namespace Cadastro.Series.Interface
{
  public interface IRepository<T>
  {
    List<T> Listar();
    T RetornarPorId(int Id);
    void Inserir(T entidade);
    void Excluir(int Id);
    void Atualizar(int Id, T entidade);
    int ProximoId();
  }
}