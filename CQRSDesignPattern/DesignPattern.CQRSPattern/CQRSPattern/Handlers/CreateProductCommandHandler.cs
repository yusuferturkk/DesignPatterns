using DesignPattern.CQRSPattern.CQRSPattern.Commands;
using DesignPattern.CQRSPattern.DataAccessLayer;

namespace DesignPattern.CQRSPattern.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductName = command.ProductName,
                Stock = command.Stock,
                Price = command.Price,
                Description = command.Description,
                Status = true,
            });
            _context.SaveChanges();
        }
    }
}
