using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSolution.Models
{
    class Category
    {
        public string category_name { get; set; }

        public Category()
        {
            this.category_name = "";
        }

        public Category(string category_name)
        {
            this.category_name = category_name;
        }
    }
}
