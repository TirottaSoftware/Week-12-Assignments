using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dry_Cleaner_Pickup_System
{
    public class Item
    {
        private ServiceType type;
        public string Name { get; set; }
        public Item(string name, ServiceType type)
        {
            this.type = type;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.type}";
        }
    }
}
