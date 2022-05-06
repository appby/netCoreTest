
using repository_pattern.DataAccess.Abstract;
using repository_pattern.DataAccess.Concrete;
using repository_pattern.Entity;

// var productDal = new EfProductDal();
// var mySqlProductDal = new MySqlProductDal();

//productDal.Create(new Product());
//mySqlProductDal.Create(new Product());

var productRepository = new ProductManager(new EfProductDal());
productRepository.Create(new Product());

// injection olsaydı ==> IProductRepository cagrilan her yerde ==> MySqlProductDal veya tanimlanan ne ise o cagrilabilecekti.

class ProductManager : IProductRepository
{
    IProductRepository _repository;
    public ProductManager(IProductRepository repo)
    {
        _repository = repo;
    }
    public void Create(Product entity)
    {
        _repository.Create(entity);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetByID(int id)
    {
        throw new NotImplementedException();
    }

    public Product[] GetProductsByCategory(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}