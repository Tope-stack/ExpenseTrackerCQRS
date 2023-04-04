using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string MerchantName { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
    }

    public enum Category
    {
        Personal,
        Business,
        Social
    }
}
