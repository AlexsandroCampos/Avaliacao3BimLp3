namespace Avaliacao3BimLp3.ViewModels;
using Avaliacao3BimLp3.Enums;

public class LojaViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Piso { get; set; }
    public string Descricao { get; set; }
    public LojaEnum TipoDeEstabelecimento { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int id, string nome, string piso, string descricao, LojaEnum tipoDeEstabelecimento, string email)
    {
        Id = id;
        Nome = nome;
        Piso = piso;
        Descricao = descricao;
        TipoDeEstabelecimento = tipoDeEstabelecimento;
        Email = email;
    }
}