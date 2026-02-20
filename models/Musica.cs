using System.Runtime.CompilerServices;
using streaming.models;

public class Musica : Conteudo
{
    public string Artista { get; set; }

    public override string Reproduzir()
    {
        return $"Reproduzindo - Música: {Titulo} | Ano de lançamento: {AnoLancamento} | Classificação: {ClassificacaoIndicativa}| Diretor: {Artista}";
    }
}
