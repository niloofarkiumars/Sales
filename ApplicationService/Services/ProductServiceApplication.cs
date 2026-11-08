using ApplicationService.Dtos.Product;
using Model.DomainModels;
using Model.ServiceModels;

namespace ApplicationService.Services
{
    public class ProductServiceApplication
    {

        private readonly ProductServiceModel _productServiceModel;
        public ProductServiceApplication()
        {
            _productServiceModel = new ProductServiceModel();
        }

        #region [- GetAll() -]

        public List<GetProductDto> GetAll()
        {
            try
            {
                var products = _productServiceModel.SelectAll();
                var getProductDtos = new List<GetProductDto>();
                foreach (var product in products)
                {
                    var getProductDto = new GetProductDto
                    {
                        Id = product.Id,
                        Code = product.Code,
                        Title = product.Title,
                        UnitPrice = product.UnitPrice,
                        Quantity = product.Quantity
                    };
                    getProductDtos.Add(getProductDto);
                }
                return getProductDtos;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while loading the products.", ex);
            }
            finally
            {
                // Nothing to dispose here (the DbContext is disposed in ProductServiceModel).
                // A good place for logging or cleanup later.
            }
        }
        #endregion

        #region [- Post() -]

        public void Post(PostProductDto postProductDto)
        {
            try
            {
                var product = new Product()
                {
                    Code = postProductDto.Code,
                    Title = postProductDto.Title,
                    UnitPrice = postProductDto.UnitPrice,
                    Quantity = postProductDto.Quantity
                };
                _productServiceModel.Insert(product);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while saving the product.", ex);
            }
            finally
            {
                // Nothing to dispose here.
            }
        }
        #endregion

        #region [- Put() -]

        public void Put(int id, PutProductDto putProductDto)
        {
            try
            {
                var product = new Product()
                {
                    Id = id,
                    Code = putProductDto.Code,
                    Title = putProductDto.Title,
                    UnitPrice = putProductDto.UnitPrice,
                    Quantity = putProductDto.Quantity
                };
                _productServiceModel.Update(product);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the product.", ex);
            }
            finally
            {
                // Nothing to dispose here.
            }
        }
        #endregion

        #region [- Delete() -]

        public void Delete(DeleteProductDto deleteProductDto)
        {
            try
            {
                var product = new Product()
                {
                    Id = deleteProductDto.Id
                };
                _productServiceModel.Delete(product);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the product.", ex);
            }
            finally
            {
                // Nothing to dispose here.
            }
        }
        #endregion

    }
}