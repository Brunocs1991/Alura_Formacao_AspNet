using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Categoria
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<FilmeCategoria> Filmes { get; set; }

        public Categoria()
        {
            Filmes = new List<FilmeCategoria>();
        }

        public override string ToString()
        {
            return $"Categoria ({Id}): {Nome}";
        }
    }
}
