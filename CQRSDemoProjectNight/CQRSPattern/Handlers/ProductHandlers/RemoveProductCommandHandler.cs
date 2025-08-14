using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.ProductCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly DemoContext _context;
        public RemoveProductCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveProductCommand command)
        {
            var product = await _context.Products.FindAsync(command.ProductId);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
