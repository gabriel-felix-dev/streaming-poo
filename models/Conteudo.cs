namespace streaming.models;

public class Conteudo
{
    public string Titulo { get; set; }
    public int AnoLancamento { get; set; }
    public int ClassificacaoIndicativa { get; set; }

    public virtual string Reproduzir()
    {
        return $"Conteudo: {Titulo}";
    }

}
