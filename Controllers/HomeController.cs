using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLp3.Models;
using Avaliacao3BimLp3.ViewModels;

namespace Avaliacao3BimLp3.Controllers;

public class HomeController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>{
        new LojaViewModel(1, "piso 3", "Tênis Brasil", "Aqui você encontra os tênis", false, "tenis@email.com"),
        new LojaViewModel(2, "piso 5", "Lembranças Já", "Venha comprar sua lembrança", true, "lemb@email.com"),
    };

    public IActionResult Index() => View();

    public IActionResult Privacy() => View();
}
