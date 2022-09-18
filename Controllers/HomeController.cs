using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLp3.ViewModels;
using Avaliacao3BimLp3.Enums;

namespace Avaliacao3BimLp3.Controllers;

public class HomeController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>{
        new LojaViewModel(1, "Tênis Brasil", "piso 3", "Aqui você encontra os tênis", LojaEnum.Loja, "tenis@email.com"),
        new LojaViewModel(2, "Lembranças Já", "piso 1", "Venha comprar sua lembrança", LojaEnum.Kiosque, "lemb@email.com"),
    };

    public IActionResult Index() => View(lojas);

    public IActionResult Show(int id) => View(lojas.Find(l => l.Id == id));
}
