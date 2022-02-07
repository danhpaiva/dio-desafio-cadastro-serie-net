using Cadastro.Series.Interface;

namespace Cadastro.Series
{
  public class SerieRepository : IRepository<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    void IRepository<Serie>.Atualizar(int Id, Serie entidade)
    {
      listaSerie[Id] = entidade;
    }

    void IRepository<Serie>.Excluir(int Id)
    {
      listaSerie[Id].ExcluirSerie();
    }

    void IRepository<Serie>.Inserir(Serie entidade)
    {
      listaSerie.Add(entidade);
    }

    List<Serie> IRepository<Serie>.Listar()
    {
      return listaSerie;
    }

    int IRepository<Serie>.ProximoId()
    {
      return listaSerie.Count;
    }

    Serie IRepository<Serie>.RetornarPorId(int Id)
    {
      return listaSerie[Id];
    }
  }
}