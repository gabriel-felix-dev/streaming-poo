using System.Runtime.CompilerServices;
using streaming.models;

public class Musica : Conteudo
{
    public string Artista { get; set; }

    public override string Reproduzir()
    {
        return $"Reproduzindo: {Titulo} | Ano de lançamento: {AnoLancamento} | Classificação: {ClassificacaoIndicativa}| Diretor: {Artista}";
    }
}
