using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLp3.ViewModels;
using Avaliacao3BimLp3.Enums;

namespace Avaliacao3BimLp3.Controllers;

public class HomeController : Controller
{
    private static List<EstabelecimentoViewModel> estabelecimentos = new List<EstabelecimentoViewModel>{
        new EstabelecimentoViewModel(1, "Tênis Brasil", "Piso 3", "Aqui você encontra os tênis", LojaEnum.Loja, "tenis@email.com"),
        new EstabelecimentoViewModel(2, "Lembranças Já", "Piso 1", "Venha comprar sua lembrança", LojaEnum.Kiosque, "lemb@email.com"),
    };

    public IActionResult Index() => View(estabelecimentos);
    public IActionResult AdminIndex() => View(estabelecimentos);
    public IActionResult AdminShow(int id) => View(estabelecimentos.Find(l => l.Id == id));
    public IActionResult AdminDelete(int id)
    {
        var loja = estabelecimentos.Find(l => l.Id == id);

        if(loja  == null) {
            return RedirectToAction("AdminIndex");
        }

        estabelecimentos.Remove(loja);
        return RedirectToAction("AdminIndex");
    } 
    public IActionResult AdminCreate()
    {
        return View();

    }


    [HttpPost]
    public IActionResult AdminCreate(EstabelecimentoViewModel estabelecimentoViewModel) 
    {
        foreach (var estabelecimento in estabelecimentos)
        {
            if(estabelecimento.Nome.Equals(estabelecimentoViewModel.Nome)) 
            {
                ViewBag.MensagemErro = "Nome de loja já existente";
                return View("AdminCreate");
            }
        }

        if(estabelecimentos.Count > 0) 
        {
            estabelecimentoViewModel.Id =  estabelecimentos.Last().Id + 1;
        }
        
        else 
        {
            estabelecimentoViewModel.Id = 1;
        }
        
        estabelecimentos.Add(estabelecimentoViewModel);
        return RedirectToAction("AdminShow", new {id = estabelecimentoViewModel.Id});
    }
}
