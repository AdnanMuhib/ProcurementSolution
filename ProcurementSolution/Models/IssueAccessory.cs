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
            this.issueDate = DateTime.Now;
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
