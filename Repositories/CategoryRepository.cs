using CoreAndFood.Data.Models;

namespace CoreAndFood.Repositories
{
    public class CategoryRepository : GenericRepositroy<Category>
    {
        Context c = new Context();

        public List<Category> CategoryList()
        {
            return c.Categories.ToList();
        }
        public void CategoriesAdd(Category ct)
        {
            c.Categories.Add(ct);
            c.SaveChanges();
        }
        public void CategoryDelete(Category ct)
        {
            c.Categories.Remove(ct);
            c.SaveChanges();
        }
        public void CategoryUpdate(Category ct)
        {
            c.Categories.Update(ct);
            c.SaveChanges();
        }
        public void GetCategory(int id)
        {
            c.Categories.Find(id);
            
        }

    }
}
