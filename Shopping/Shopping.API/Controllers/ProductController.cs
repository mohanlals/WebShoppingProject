using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductController : Controller

    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductContext _Context;
        public ProductController(ILogger<ProductController> logger, ProductContext productContext)
        {
            _logger = logger;
            _Context = productContext;

        }
        [HttpGet]
        public async Task< IEnumerable<Product> >Get()
        {
            //var rng = new Random();
            //return (Enumerable.Range(1, 5).Select(index => new Product { Name = "asd" })).ToArray();
            return await _Context.Products.Find(prop => true).ToListAsync();
        }
    }
}
