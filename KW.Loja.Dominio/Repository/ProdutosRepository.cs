using KW.Loja.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW.Loja.Dominio.Repository
{
    public class ProdutosRepository
    {
        private readonly KesDbContext _context = new KesDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

    }
}
