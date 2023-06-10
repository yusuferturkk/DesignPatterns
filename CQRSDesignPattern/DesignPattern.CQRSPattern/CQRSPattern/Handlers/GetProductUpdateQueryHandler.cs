using DesignPattern.CQRSPattern.CQRSPattern.Queries;
using DesignPattern.CQRSPattern.CQRSPattern.Results;
using DesignPattern.CQRSPattern.DataAccessLayer;

namespace DesignPattern.CQRSPattern.CQRSPattern.Handlers
{
    public class GetProductUpdateQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Description = value.Description,
                ProductId = value.ProductId,
                ProductName = value.ProductName,
                Price = value.Price,
                Stock = value.Stock
            };
        }
    }
}
