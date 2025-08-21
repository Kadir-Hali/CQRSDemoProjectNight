using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CustomerCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class RemoveCustomerCommandHandler
    {
        private readonly DemoContext _context;
        public RemoveCustomerCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveCustomerCommand command)
        {
            var customer = await _context.Customers.FindAsync(command.CustomerId);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
