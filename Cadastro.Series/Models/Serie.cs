namespace Cadastro.Series
{
  public class Serie : EntidadeBase
  {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }

    public Serie(int Id, Genero Genero, string Titulo, string Descricao, int Ano)
    {
      this.Id = Id;
      this.Genero = Genero;
      this.Titulo = Titulo;
      this.Descricao = Descricao;
      this.Ano = Ano;
    }

    public override string ToString()
    {
      string retorno = string.Empty;
      retorno += "Gênero: + " + this.Genero + Environment.NewLine;
      retorno += "Titulo: + " + this.Titulo + Environment.NewLine;
      retorno += "Descricao: + " + this.Descricao + Environment.NewLine;
      retorno += "Ano: + " + this.Ano;
      return retorno;
    }
  }
}