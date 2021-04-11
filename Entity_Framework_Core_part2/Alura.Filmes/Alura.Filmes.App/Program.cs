
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();
                foreach (var cliente in contexto.Clientes)
                {
                    Console.WriteLine(cliente);
                }
            }
        }
    }
}