using SystemStores.infra.Data;

namespace SystemStores.App.Repos
{
    public class Category : ICategory
    {
        AppDbContext appDbContext;
        public Category(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public void AddCategory(Domain.Models.Category.AddCategory category)
        {
            appDbContext.Database.EnsureCreated();

            var _category = new Domain.Category()
            {
                Name = category.Name,
            };

            appDbContext.category.Add(_category);

            appDbContext.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            appDbContext.Database.EnsureCreated();

            var _category = appDbContext.category.FirstOrDefault(i => i.Id == id);

            appDbContext.category.Remove(_category);

            appDbContext.SaveChanges();

        }
        public void UpdateCategory(Domain.Models.Category.UpdateCategory updataCategory, int id)
        {
            appDbContext.Database.EnsureCreated();

            var _category = appDbContext.category.FirstOrDefault(i => i.Id == id);

            _category.Name = updataCategory.Name;

            appDbContext.category.Update(_category);

            appDbContext.SaveChanges();
        }
        List<Domain.Category> ICategory.GetList()
        {
            appDbContext.Database.EnsureCreated();
            return appDbContext.category.ToList();
        }
    }
}
