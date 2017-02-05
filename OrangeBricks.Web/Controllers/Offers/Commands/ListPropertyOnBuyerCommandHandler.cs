using Microsoft.AspNet.Identity;
using OrangeBricks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace OrangeBricks.Web.Controllers.Offers.Commands
{
    public class ListPropertyOnBuyerCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public ListPropertyOnBuyerCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(ListPropertyOnBuyerCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);
            property.Offers.Where(x => x.BuyerUserId == Membership.GetUser().ProviderUserKey.ToString());
            _context.SaveChanges();
        }
    }
}