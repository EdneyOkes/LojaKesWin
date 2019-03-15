using KW.Loja.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KW.Loja.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepository _repositorio;

        // GET: Vitrine
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepository();
            var produtos = _repositorio.Produtos;


            return View();
        }
    }
}