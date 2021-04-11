using Alura.ListaLeitura.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.Ordenacao
{
    public static class LivroOrdemExtensions
    {
        public static IQueryable<Livro> AplicaOrdenacao(this IQueryable<Livro> query, LivroOrdem ordem)
        {
            if ((ordem != null)&&(!string.IsNullOrEmpty(ordem.OrdenarPor)))
            {
                query = query.OrderBy(ordem.OrdenarPor);
            }
            return query;
        }
    }

    public class LivroOrdem
    {
        public string OrdenarPor { get; set; }
    }
}
