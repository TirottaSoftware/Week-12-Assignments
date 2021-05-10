using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dry_Cleaner_Pickup_System
{
    public class DryCleaner
    {
        private Dictionary<string, Ticket> tickets;
        private List<Item> ticketItems;

        public DryCleaner()
        {
            this.tickets = new Dictionary<string, Ticket>();
            this.ticketItems = new List<Item>();
        }
        public void AddItem(string name, ServiceType type)
        {
            Item item = new Item(name, type);
            this.ticketItems.Add(item);
        }
        public void CreateTicket(string ticketNumber, string clientName)
        {
            Ticket ticket = new Ticket(ticketNumber, clientName, this.ticketItems.ToArray());
            this.tickets.Add(ticket.TicketNumber, ticket);
        }
        public Ticket GetTicket(string ticketNumber) => this.tickets[ticketNumber];
        
        public void CompleteTicket(string ticketNumber)
        {
            this.tickets.Remove(ticketNumber);
        }
    }
}
