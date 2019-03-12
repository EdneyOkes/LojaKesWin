using KW.Loja.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KW.Loja.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepository _repositorio;

        // GET: Produtos
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepository();
            var produtos = _repositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}