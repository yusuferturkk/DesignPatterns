using DesignPattern.CQRSPattern.CQRSPattern.Results;
using DesignPattern.CQRSPattern.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRSPattern.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult 
            {
                ProductId = x.ProductId, 
                ProductName = x.ProductName, 
                Price = x.Price, 
                Stock = x.Stock 
            }).ToList();
            return values;
        }
    }
}
