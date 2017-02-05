using System.Collections.Generic;
using System.Linq;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
using OrangeBricks.Web.Models;
using System.Data.Entity;

namespace OrangeBricks.Web.Controllers.Offers.Builders
{
    public class BuyerOffersOnPropertyViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public BuyerOffersOnPropertyViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public List<OffersOnPropertyViewModel> Build(string buyerId)
        {
            var filtered = _context.Properties.Include("Offers").Where(x => x.Offers.Any(c => c.BuyerUserId == buyerId)).ToList();
            var model = filtered.Select(c =>
            {
                var item = new OffersOnPropertyViewModel()
                {
                   PropertyType = c.PropertyType,
                   NumberOfBedrooms = c.NumberOfBedrooms,
                   StreetName = c.StreetName,
                   Offers = c.Offers.Where(d => d.BuyerUserId == buyerId).Select(x => new OfferViewModel
                   {
                       Id = x.Id,
                       Amount = x.Amount,
                       CreatedAt = x.CreatedAt,
                       IsPending = x.Status == OfferStatus.Pending,
                       Status = x.Status.ToString(),
                       BuyerUserId = x.BuyerUserId
                   }),
                };
                return item;
            }).ToList();
            //TODO: refactor, shorten linq, duping where clause
            return model;
        }
    }
}