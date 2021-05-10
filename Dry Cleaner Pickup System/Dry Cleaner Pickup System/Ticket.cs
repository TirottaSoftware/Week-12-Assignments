using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dry_Cleaner_Pickup_System
{
    public class Ticket
    {
        private Item[] items;
        public string TicketNumber { get; }
        public string ClientName { get; }
        public Ticket(string ticketNumber, string clientName, Item[] items)
        {
            this.TicketNumber = ticketNumber;
            this.ClientName = clientName;
            this.items = items;
        }
        public string[] GetItems()
        {
            string[] itemsArray = new string[this.items.Length];
            for (int i = 0; i < this.items.Length; i++)
            {
                itemsArray[i] = this.items[i].ToString();
            }
            return itemsArray;
        }
    }
}
