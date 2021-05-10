using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dry_Cleaner_Pickup_System
{
    public partial class Form1 : Form
    {
        private DryCleaner dryCleaner;
        public Form1()
        {
            dryCleaner = new DryCleaner();
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = tbxItemName.Text;
            ServiceType itemType;
            if (rbLaundry.Checked)
            {
                itemType = ServiceType.Laundry;
            }
            else if (rbDryCleaning.Checked)
            {
                itemType = ServiceType.DryCleaning;
            }
            else
            {
                itemType = ServiceType.ShoeRepair;
            }
            dryCleaner.AddItem(itemName, itemType);
            lbxItems.Items.Add(itemName);
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            string clientName = tbxClientName.Text;
            string ticketNumber = tbxTicketNumber.Text;
            dryCleaner.CreateTicket(ticketNumber, clientName);
            lbxItems.Items.Clear();
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            string ticketNumber = tbxTicketNumberRetrieval.Text;
            Ticket ticket = dryCleaner.GetTicket(ticketNumber);
            lblClientNameValue.Text = ticket.ClientName;

            string[] items = ticket.GetItems();
            for (int i = 0; i < items.Length; i++)
            {
                lbxFoundItems.Items.Add(items[i]);
            }
        }

        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            string ticketNumber = tbxTicketNumberRetrieval.Text;
            dryCleaner.CompleteTicket(ticketNumber);
            lbxFoundItems.Items.Clear();
        }
    }
}
