using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLp3.ViewModels;

namespace Avaliacao3BimLp3.Controllers;

public class HomeController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>{
        new LojaViewModel(1, "Tênis Brasil", "Piso 3", "Aqui você encontra os tênis", false, "tenis@email.com"),
        new LojaViewModel(2, "Lembranças Já", "Piso 5", "Venha comprar sua lembrança", true, "lemb@email.com"),
    };

    public IActionResult Index() => View(lojas);

    public IActionResult Privacy() => View();
}
