using Microsoft.AspNetCore.Mvc;

namespace Calculadoras.Controllers;

public class Calculadora2Controller : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Resultado(double n1,  double n2, string operacao)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;

        if(operacao == "adicao")
        {            
            ViewBag.Resultado = n1 + n2;
        }
        else if(operacao == "subtracao")
        {
            ViewBag.Resultado = n1 - n2;
        }
        else if(operacao == "mult")
        {
            ViewBag.Resultado = n1 * n2;

        }else
        {
            ViewBag.Resultado = n1 / n2;
        }
        return View();
    }
}