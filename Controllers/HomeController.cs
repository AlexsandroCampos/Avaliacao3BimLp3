using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLp3.ViewModels;
using Avaliacao3BimLp3.Enums;

namespace Avaliacao3BimLp3.Controllers;

public class HomeController : Controller
{
    private static List<EstabelecimentoViewModel> estabelecimentos = new List<EstabelecimentoViewModel>{
        new EstabelecimentoViewModel(1, "Tênis Brasil", "piso 3", "Aqui você encontra os tênis", LojaEnum.Loja, "tenis@email.com"),
        new EstabelecimentoViewModel(2, "Lembranças Já", "piso 1", "Venha comprar sua lembrança", LojaEnum.Kiosque, "lemb@email.com"),
    };

    public IActionResult Index() => View(estabelecimentos);
    public IActionResult IndexAdmin() => View(estabelecimentos);
    public IActionResult Show(int id) => View(estabelecimentos.Find(l => l.Id == id));
    public IActionResult Delete(int id)
    {
        var loja = estabelecimentos.Find(l => l.Id == id);
        if(loja  == null) {
            return RedirectToAction("IndexAdmin");
        }
        estabelecimentos.Remove(loja);
        return RedirectToAction("IndexAdmin");
    } 
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(EstabelecimentoViewModel estabelecimentoViewModel) 
    {
        foreach (var estabelecimento in estabelecimentos)
        {
            if(estabelecimento.Nome.Equals(estabelecimentoViewModel.Nome)) {
            ViewBag.MensagemErro = "Nome de loja já existente";
            return View();
        }
        }
        
        estabelecimentoViewModel.Id = estabelecimentos.Last().Id + 1;
        
        estabelecimentos.Add(estabelecimentoViewModel);
        return RedirectToAction("Show", new {id = estabelecimentoViewModel.Id});
    }
}
