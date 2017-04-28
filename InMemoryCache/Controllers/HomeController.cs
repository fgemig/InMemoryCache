using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using InMemoryCache.Data;
using System.Collections.Generic;
using InMemoryCache.Models;

namespace InMemoryCache.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMemoryCache _memoryCache;
        private readonly ILivrosRepository _livrosRepository;

        public HomeController(IMemoryCache memoryCache, ILivrosRepository livrosRepository)
        {
            _livrosRepository = livrosRepository;
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {

            var data = _memoryCache.GetOrCreate<IEnumerable<Livro>>(
                "lista-livros", contexto =>
                {
                    contexto.SetAbsoluteExpiration(TimeSpan.FromSeconds(20));
                    contexto.SetPriority(CacheItemPriority.High);

                    return _livrosRepository.ObterLivros();
                });

            return View(data);

        }

    }
}
