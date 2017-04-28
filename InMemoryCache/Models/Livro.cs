using System;

namespace InMemoryCache.Models
{
    public class Livro
    {
        public Guid Id { get; set; }

        public string Autor { get; set; }

        public string Titulo { get; set; }

        public int AnoPublicacao { get; set; }
    }
}
