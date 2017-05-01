using InMemoryCache.Models;
using System.Collections.Generic;

namespace InMemoryCache.Data
{
    public interface ILivrosRepository
    {
        IEnumerable<Livro> ObterLivros();
    }
}
