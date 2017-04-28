using InMemoryCache.Models;
using System;
using System.Collections.Generic;

namespace InMemoryCache.Data
{
    public class LivrosRepository : ILivrosRepository
    {
        public IEnumerable<Livro> ObterLivros()
        {
            var livros = new List<Livro>
            {
                new Livro{ Id = Guid.NewGuid(), Autor = "Eric Evans", Titulo = "Domain-Driven-Design", AnoPublicacao = 2003},
                new Livro{ Id = Guid.NewGuid(), Autor = "Robert Cecil Martin (Uncle Bob)", Titulo = "Clean Code" , AnoPublicacao = 2008},
            };
            return livros;
        }
    }

    public interface ILivrosRepository
    {
        IEnumerable<Livro> ObterLivros();
    }
}
