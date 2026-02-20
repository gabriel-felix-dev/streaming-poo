using streaming.models;

Usuario usuario = new Usuario
{
    Nome = "joao",
    Idade = 15,
};

Filme filme1 = new Filme
{
    Titulo = "Exorcista",
    AnoLancamento = 1970,
    ClassificacaoIndicativa = 18,
    Diretor = "Miau"
};

Musica musica1 = new Musica
{
    Titulo = "Powerslave",
    Artista = "Iron Maiden",
    AnoLancamento = 1984,
    ClassificacaoIndicativa = 16,
};

Console.WriteLine(usuario.PodeReproduzir(musica1));
Console.WriteLine(musica1.Reproduzir());
