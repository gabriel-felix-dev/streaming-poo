using streaming.models;

public class Usuario : Conteudo
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public string PodeReproduzir(Conteudo conteudo)
    {
        if (conteudo.ClassificacaoIndicativa > Idade)
            return $"O usuário não pode reproduzir o conteudo \"{conteudo.Titulo}\"";

        return conteudo.Reproduzir();
    }
}
