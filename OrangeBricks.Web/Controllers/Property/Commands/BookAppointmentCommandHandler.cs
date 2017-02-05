using System;
using System.Collections.Generic;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookAppointmentCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public BookAppointmentCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(BookAppointmentCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var bookAppointment = new BookAppointment
            {
                PropertyId = command.PropertyId,
                BuyerId = command.BuyerId,
                Accepted = false,
                CreatedAt = DateTime.Now,
                BookAppointmentDate = command.ViewingDateTime
            };

            if (property.BookAppointments == null)
            {
                property.BookAppointments = new List<BookAppointment>();
            }
                
            property.BookAppointments.Add(bookAppointment);
            
            _context.SaveChanges();
        }
    }
}