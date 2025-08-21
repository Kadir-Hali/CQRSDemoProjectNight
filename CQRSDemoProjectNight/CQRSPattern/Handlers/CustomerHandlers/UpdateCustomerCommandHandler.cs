using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Commands.CustomerCommands;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler
    {
        private readonly DemoContext _context;
        public UpdateCustomerCommandHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateCustomerCommand command)
        {
            var customer = await _context.Customers.FindAsync(command.CustomerId);
            customer.CustomerName = command.CustomerName;
            customer.CustomerSurname = command.CustomerSurname;
            customer.CustomerCity = command.CustomerCity;
            await _context.SaveChangesAsync();
        }
    }
}
