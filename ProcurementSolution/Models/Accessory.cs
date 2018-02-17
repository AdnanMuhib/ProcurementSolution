using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSolution.Models
{
    class Accessory
    {
        public string title { get; set; }
        public int quantity { get; set; }
        public string category { get; set; }


        public Accessory()
        {
            this.title = "";
            this.quantity = 0;
            this.category = "";
        }

        public Accessory(string title, int quantity, string category)
        {
            this.title = title;
            this.quantity = quantity;
            this.category = category;
        }
    }

}
