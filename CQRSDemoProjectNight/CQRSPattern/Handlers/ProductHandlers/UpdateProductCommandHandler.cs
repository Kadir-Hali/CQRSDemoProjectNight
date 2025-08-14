using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.ProductCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly DemoContext _context;
        public UpdateProductCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateProductCommand command)
        {
            var product = await _context.Products.FindAsync(command.ProductId);
                product.ProductName = command.ProductName;
                product.ProductPrice = command.ProductPrice;
                product.ProductStock = command.ProductStock;
                await _context.SaveChangesAsync();
  
        }
    }
}
