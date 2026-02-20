using streaming.models;

public class Filme : Conteudo
{
    public string Diretor { get; set; }

    public override string Reproduzir()
    {
        return $"Reproduzindo - Filme: {Titulo} | Ano de lançamento: {AnoLancamento} | Classificação: {ClassificacaoIndicativa}| Diretor: {Diretor}";
    }
}
