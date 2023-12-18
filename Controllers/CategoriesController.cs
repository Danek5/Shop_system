using Microsoft.AspNetCore.Mvc;
using Shop_system.Models;

namespace Shop_system.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            var category = CategoryRepository.GetCategoryById(id.HasValue?id.Value:0);

            return View(category);
        }
    }
}
