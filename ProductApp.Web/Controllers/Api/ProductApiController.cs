using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Business;
using ProductApp.Web.Models;
using AutoMapper;
using ProductApp.Entities;

namespace ProductApp.Web.Controllers.Api
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductApiController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: api/productapi
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        // GET: api/productapi/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetAll().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        // POST: api/productapi
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = _mapper.Map<Product>(productDto);
            _productService.Add(product);

            return CreatedAtAction(nameof(Get), new { id = product.Id }, productDto);
        }

        // DELETE: api/productapi/5
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _productService.GetAll().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.Delete(id);
            return NoContent();
        }
    }
}
