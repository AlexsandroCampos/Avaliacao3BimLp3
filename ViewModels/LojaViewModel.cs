namespace Avaliacao3BimLp3.ViewModels;

public class LojaViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Piso { get; set; }
    public string Descricao { get; set; }
    public bool Kiosque { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int id, string nome, string piso, string descricao, bool kiosque, string email)
    {
        Id = id;
        Nome = nome;
        Piso = piso;
        Descricao = descricao;
        Kiosque = kiosque;
        Email = email;
    }
}