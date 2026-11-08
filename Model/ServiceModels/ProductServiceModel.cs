using Model.DomainModels;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {

        #region [ -Insert ()- ]
        public void Insert(Product product)
        {
            using (var context = new ProjectDbContext())
            {
                context.Add(product);
                context.SaveChanges();
            }
        }
        #endregion

        #region [ -Update ()- ]
        public void Update(Product product)
        {
            using var context = new ProjectDbContext();
            context.Update(product);
            context.SaveChanges();
        }
        #endregion

        #region [ -Delete ()- ]
        public void Delete(Product product)
        {
            using var context = new ProjectDbContext();
            context.Remove(product);
            context.SaveChanges();
        }
        #endregion

        #region [ -SelectAll ()- ]
        public List<Product> SelectAll()
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var Products = context.Product.ToList();
                    return Products;
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log it)
                    throw new Exception("An error occurred while retrieving Products.", ex);
                }
                finally
                {
                    // Ensure the context is disposed of properly
                    context.Dispose();
                }
            }
        }
        #endregion
    }
}