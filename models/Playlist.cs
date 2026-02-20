using streaming.models;

public class Playlist
{
    public string Nome { get; set; }
    public List<Conteudo> Conteudos { get; set; }

    public void ArmazenarNaPlaylist(Conteudo conteudo)
    {
        Conteudos.Add(conteudo);
    }

    public string ImprimeNomePlaylis()
    {
        return $"Titulo da playlist - {Nome}";
    }

    public void ImprimePlaylist()
    {
        Console.WriteLine($"{ImprimeNomePlaylis()}: \n");

        foreach (Conteudo conteudo in Conteudos)
        {
            if (conteudo is Musica musica)
                Console.WriteLine($"{musica} - Titulo: {musica.Titulo} | Ano lançamento: {musica.AnoLancamento} | Classificação Indicativa: {musica.ClassificacaoIndicativa} | Artista: {musica.Artista}");

            if (conteudo is Filme filme)
                Console.WriteLine($"{filme} - Titulo: {filme.Titulo} | Ano lançamento: {filme.AnoLancamento} | Classificação Indicativa: {filme.ClassificacaoIndicativa} | Diretor: {filme.Diretor}");
        }
    }

    public void ImprimeLancamentoRecente()
    {
        foreach (Conteudo conteudo in Conteudos)
        {
            if (conteudo is Musica musica && conteudo.AnoLancamento > 2020)
                Console.WriteLine($"{musica} - Titulo: {musica.Titulo} | Ano lançamento: {musica.AnoLancamento} | Classificação Indicativa: {musica.ClassificacaoIndicativa} | Artista: {musica.Artista}");

            if (conteudo is Filme filme && conteudo.AnoLancamento > 2020)
                Console.WriteLine($"{filme} - Titulo: {filme.Titulo} | Ano lançamento: {filme.AnoLancamento} | Classificação Indicativa: {filme.ClassificacaoIndicativa} | Diretor: {filme.Diretor}");
        }
    }

}
