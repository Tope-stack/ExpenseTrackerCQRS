using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Dtos
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string MerchantName { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
    }
}
