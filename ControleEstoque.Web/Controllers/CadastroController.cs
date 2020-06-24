
using System.Web.Mvc;
//27
namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        private const int _quantMaxLinhasPorPagina = 5;

        [Authorize]


        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }


        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }

    }
}