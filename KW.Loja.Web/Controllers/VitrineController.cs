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
        public int ProdutosPorPagina = 5;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)

        {
            _repositorio = new ProdutosRepository();
            var produtos = _repositorio.Produtos
            .OrderBy(p => p.Descricao)
            .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);




            return View(produtos);
        }

    }
}