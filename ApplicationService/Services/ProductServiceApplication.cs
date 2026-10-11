using ApplicationService.Dtos.Product;
using Model.DomainModels.Pipeline;
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
        #endregion

        #region [- Post() -]

        public void Post(PostProductDto postProductDto)
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
        #endregion

        #region [- Put() -]

        public void Put(int id, PutProductDto putProductDto)
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
        #endregion

        #region [- Delete() -]

        public void Delete(int id)
        {
            _productServiceModel.Delete(id);
        }
        #endregion

    }
}