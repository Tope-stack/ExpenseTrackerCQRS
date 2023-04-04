using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Dtos
{
    public class AddExpenseDto : AddAndUpdateExpenseDto 
    {

    }

    public class UpdateExpenseDto : AddAndUpdateExpenseDto
    {

    }


    public class AddAndUpdateExpenseDto
    {
        public DateTime ExpenseDate { get; set; }
        public string MerchantName { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
    }
}
