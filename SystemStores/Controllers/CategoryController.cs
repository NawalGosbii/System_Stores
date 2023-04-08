using Microsoft.AspNetCore.Mvc;
using SystemStores.App.Repos;

namespace SystemStores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        ICategory Category;
        public CategoryController(ICategory _category)
        {
            Category = _category;
        }
        [HttpGet]
        public List<Domain.Category> GetCategories()
        {

            return Category.GetList();
        }
        [HttpPost]
        public void AddCategory(Domain.Models.Category.AddCategory category)
        {
            Category.AddCategory(category);
        }
        [HttpPut("{id}")]
        public void UpdateCategory(Domain.Models.Category.UpdateCategory category, int id)
        {
            Category.UpdateCategory(category,id);
        }
        [HttpDelete("{id}")]
        public void DeleteCategory(int id) 
        {
            Category.DeleteCategory(id);
        }
    }
}
