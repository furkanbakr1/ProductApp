using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Business;
using ProductApp.Entities;
using ProductApp.Web.Models;

namespace ProductApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        public IActionResult Index(string searchTerm, int page = 1)
        {
            int pageSize = 5;

            var allProducts = _productService.GetAll();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                allProducts = allProducts
                    .Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()))
                    .ToList();
            }

            var pagedProducts = allProducts
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            var model = new ProductListViewModel
            {
                Products = _mapper.Map<List<ProductDto>>(pagedProducts),
                PageInfo = new PaginationInfo
                {
                    TotalItems = allProducts.Count,
                    ItemsPerPage = pageSize,
                    CurrentPage = page
                }
            };

            ViewBag.SearchTerm = searchTerm;

            return View(model);
        }



        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return View(productDto);
            }

            var product = _mapper.Map<Product>(productDto);
            _productService.Add(product);
            return RedirectToAction("Index");
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
