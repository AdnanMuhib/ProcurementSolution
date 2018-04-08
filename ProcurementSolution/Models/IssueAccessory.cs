using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSolution.Models
{
    class IssueAccessory
    {
        public string email { get; set; }
        public List<Accessory> Accessories { get; set; }
        public DateTime issueDate { get; set; }


        public IssueAccessory()
        {
            Accessories = new List<Accessory>();
            this.issueDate = DateTime.Now;
<<<<<<< HEAD
            
=======
>>>>>>> bed9ff03d18c973b38d4284d83779d4d128b727a
        }

        public void AddAccessory(Accessory acc) {
            Accessories.Add(acc);
        }
        public void AddRecord()
        {
            Record.IssueAccessory(this);
        }
        public void printReceipt()
        {
            // code to generate the pdf and print the receipt
        }
    }
}
