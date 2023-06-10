using DesignPattern.CQRSPattern.CQRSPattern.Commands;
using DesignPattern.CQRSPattern.DataAccessLayer;

namespace DesignPattern.CQRSPattern.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            _context.Products.Update(new Product
            {
                ProductId = command.ProductId,
                ProductName = command.ProductName,
                Description = command.Description,
                Price = command.Price,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
