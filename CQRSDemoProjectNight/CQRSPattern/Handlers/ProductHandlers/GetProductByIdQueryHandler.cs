using CQRSDemoProjectNight.Context;
using CQRSDemoProjectNight.CQRSPattern.Queries.ProductQueries;
using CQRSDemoProjectNight.CQRSPattern.Results.ProductResults;

namespace CQRSDemoProjectNight.CQRSPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly DemoContext _context;
        public GetProductByIdQueryHandler(DemoContext context)
        {
            _context = context;
        }
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery query)
        {
            var values = await _context.Products.FindAsync(query.Id);
            return new GetProductByIdQueryResult
            {
                ProductName = values.ProductName,
                ProductStock = values.ProductStock,
                ProductPrice = values.ProductPrice,
                ProductId = values.ProductId
            };
        }
    }
}
