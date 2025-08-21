using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Results.CustomerResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.CustomerHandlers
{
    public class GetCustomerQueryHandler
    {
        private readonly DemoContext _context;
        public GetCustomerQueryHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task<List<GetCustomerQueryResult>> Handle()
        {
            var values = await _context.Customers.ToListAsync();
            return values.Select(x => new GetCustomerQueryResult
            {
                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname,
                CustomerCity = x.CustomerCity
            }).ToList();
        }
    }
}
