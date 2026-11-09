
using Model.DomainModels;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {
        #region [ -Insert ()- ]

        public void Insert(Product product)
        {
            try
            {
                using var context = new ProjectDbContext();

                context.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while inserting the product.", ex);
            }
        }

        #endregion

        #region [ -Update ()- ]

        public void Update(Product product)
        {
            try
            {
                using var context = new ProjectDbContext();

                context.Update(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while updating the product.", ex);
            }
        }

        #endregion

        #region [ -Delete ()- ]

        public void Delete(Product product)
        {
            try
            {
                using var context = new ProjectDbContext();

                context.Remove(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while deleting the product.", ex);
            }
        }

        #endregion

        #region [ -SelectAll ()- ]

        public List<Product> SelectAll()
        {
            try
            {
                using var context = new ProjectDbContext();

                return context.Product.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while retrieving products.", ex);
            }
        }

        #endregion
    }
}
