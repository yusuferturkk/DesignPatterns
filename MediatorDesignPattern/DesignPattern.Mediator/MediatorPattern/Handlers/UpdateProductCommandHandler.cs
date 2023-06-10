using DesignPattern.Mediator.DataAccessLayer;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;
using Newtonsoft.Json.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ProductId);
            value.ProductName = request.ProductName;
            value.ProductStock = request.ProductStock;
            value.ProductPrice = request.ProductPrice;
            value.ProductStockType = request.ProductStockType;
            value.ProductCategory = request.ProductCategory;
            await _context.SaveChangesAsync();
        }
    }
}
