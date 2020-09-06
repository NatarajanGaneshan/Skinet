using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("API/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Products()
        {
            var Products = await _repo.GetProductsAsync();
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Product(int id)
        {
            var Product = await _repo.GetProductByIdAsync(id);
            return Ok(Product);
        }

    }
}