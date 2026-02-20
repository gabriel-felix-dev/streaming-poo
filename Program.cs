using streaming.models;

Usuario usuario = new Usuario
{
    Nome = "joao",
    Idade = 19,
};

Filme filme1 = new Filme
{
    Titulo = "Exorcista",
    AnoLancamento = 1970,
    ClassificacaoIndicativa = 18,
    Diretor = "Miau",
};

Filme filme2 = new Filme
{
    Titulo = "Superman",
    AnoLancamento = 2024,
    ClassificacaoIndicativa = 18,
    Diretor = "Miau",
};

Musica musica1 = new Musica
{
    Titulo = "Powerslave",
    Artista = "Iron Maiden",
    AnoLancamento = 1984,
    ClassificacaoIndicativa = 16,
};

Musica musica2 = new Musica
{
    Titulo = "Hell on Earth",
    Artista = "Iron Maiden",
    AnoLancamento = 2021,
    ClassificacaoIndicativa = 16,
};

Playlist playlist1 = new Playlist
{
    Nome = "Favoritos",
    Conteudos = [],
};

playlist1.ArmazenarNaPlaylist(filme1);
playlist1.ArmazenarNaPlaylist(musica1);
playlist1.ArmazenarNaPlaylist(filme2);
playlist1.ArmazenarNaPlaylist(musica2);

playlist1.ImprimePlaylist();

Console.WriteLine("\nFilmes e músicas lançados depois de 2020: \n");
playlist1.ImprimeLancamentoRecente();

Console.WriteLine();

Console.WriteLine(usuario.PodeReproduzir(musica1));

Console.WriteLine();

Console.WriteLine(usuario.PodeReproduzir(filme1));
