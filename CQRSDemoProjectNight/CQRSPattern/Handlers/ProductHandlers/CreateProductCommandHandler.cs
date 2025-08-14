using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.ProductCommands;
using CQRSDemoProjectNight.Entities;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly DemoContext _context;

        public CreateProductCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductStock = command.ProductStock
            });
            await _context.SaveChangesAsync();
        }
    }
}
