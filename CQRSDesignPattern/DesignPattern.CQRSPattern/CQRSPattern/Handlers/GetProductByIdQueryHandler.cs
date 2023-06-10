using DesignPattern.CQRSPattern.CQRSPattern.Queries;
using DesignPattern.CQRSPattern.CQRSPattern.Results;
using DesignPattern.CQRSPattern.DataAccessLayer;
using System.Linq;

namespace DesignPattern.CQRSPattern.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                ProductName = value.ProductName,
                Price = value.Price,
                Stock = value.Stock,
                ProductId = value.ProductId
            };
        }
    }
}
