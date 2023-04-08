using Microsoft.EntityFrameworkCore.ChangeTracking;
using SystemStores.Domain;

namespace SystemStores.App.Repos
{
    public interface ICategory
    {
        List<Domain.Category> GetList();

        public void AddCategory(Domain.Models.Category.AddCategory category);

        public void UpdateCategory(Domain.Models.Category.UpdateCategory updataCategory, int id);

        public void DeleteCategory(int id);
    }
}
